/*
Created By: Tate Kolton, Parsa Khodabakhshi
Created On: October 15, 2023
Description: Teensy 4.1 code for driving a 6 axis robot arm and communicating with a host PC software
*/

// header file with all constants defined and libraries included
#include "armFirmware.h"

// setup function to initialize pins and provide initial homing to the arm.
void setup() {

  Serial.begin(9600);

  // initializes end effector motor
  pinMode(EEstepPin, OUTPUT);
  pinMode(EEdirPin, OUTPUT);
  endEff.setMinPulseWidth(10);
  endEff.setMaxSpeed(speedEE);
  endEff.setAcceleration(accEE);
  endEff.setCurrentPosition(endEffMax);

  // initializes step pins, direction pins, limit switch pins, and stepper motor objects for accelStepper library
  for (i = 0; i < NUM_AXES; i++) {
    pinMode(dirPins[i], OUTPUT);
    pinMode(stepPins[i], OUTPUT);
    pinMode(limPins[i], INPUT_PULLUP);
    min_steps[i] = -homeCompSteps[i];
    max_steps[i] = max_steps[i] - homeCompSteps[i];
    steppers[i] = AccelStepper(1, stepPins[i], dirPins[i]);
    steppers[i].setMinPulseWidth(10);
    steppers[i].setCurrentPosition(0);
    maxSpeed[i] = maxSpeedAngle[i]*red[i]*ppr[i]/360;
    maxAccel[i] = maxAccelAngle[i]*red[i]*ppr[i]/360;
    currSpeed[i] = maxSpeed[i];
    currAccel[i] = maxAccel[i];
    speedDelta[i] = maxSpeed[i]/15;
    accelDelta[i] = maxAccel[i]/15;
  }

  min_steps[0] = -max_steps[0];
  min_steps[5] = -max_steps[5];

  //sensor pin setup
  pinMode(forceSensPin, INPUT);

}

// main program loop
void loop() {

  // receives command from serial and executes accoringly
  recieveCommand();

  // run steppers to target position
  runSteppers();
}

void recieveCommand() {
  String inData = "";
  char recieved = '\0';
  char firstChar;

  // if a message is present, copy it to inData
  if (Serial.available() > 0) {

    firstChar = Serial.read();
    if(firstChar == 'S') { // start char for message
      while (recieved != '\n') {
        recieved = Serial.read();
        inData += String(recieved);
      }
      parseMessage(inData);
    }
  }
}

void parseMessage(String inMsg) {
  String function = inMsg.substring(0, 2);

  // choose which function to run
  if (function == "MT") {
    commandArmPose(inMsg);
  }
  else if(function == "EE"){
    endEffectorCommands(inMsg);
  }
  else if(function == "MP") {
    updateMotionParams(inMsg);
  }
  else if (function == "HM") {
    homeArm();
    return;
  }

  // Send arm angles and gripper force to hardware driver
  sendArmFeedback();
}

// Move arm based on inputted angles
void commandArmPose(String inMsg) {
  // get new position commands

  int msgIdxJ1 = inMsg.indexOf('A');
  int msgIdxJ2 = inMsg.indexOf('B');
  int msgIdxJ3 = inMsg.indexOf('C');
  int msgIdxJ4 = inMsg.indexOf('D');
  int msgIdxJ5 = inMsg.indexOf('E');
  int msgIdxJ6 = inMsg.indexOf('F');
  int msgIdxJ7 = inMsg.indexOf('G');
  cmdArmAngle[0] = inMsg.substring(msgIdxJ1 + 1, msgIdxJ2).toInt();
  cmdArmAngle[1] = inMsg.substring(msgIdxJ2 + 1, msgIdxJ3).toInt();
  cmdArmAngle[2] = inMsg.substring(msgIdxJ3 + 1, msgIdxJ4).toInt();
  cmdArmAngle[3] = inMsg.substring(msgIdxJ4 + 1, msgIdxJ5).toInt();
  cmdArmAngle[4] = inMsg.substring(msgIdxJ5 + 1, msgIdxJ6).toInt();
  cmdArmAngle[5] = inMsg.substring(msgIdxJ6 + 1, msgIdxJ7).toInt();
  cmdEE = inMsg.substring(msgIdxJ7 + 1).toInt();

  angleToSteps();
  cmdArm();
}

void updateMotionParams(String inMsg) {
  
  int msgIdxJ1 = inMsg.indexOf('A');
  int msgIdxJ2 = inMsg.indexOf('B');
  int msgIdxJ3 = inMsg.indexOf('C');
  int msgIdxJ4 = inMsg.indexOf('D');
  int msgIdxJ5 = inMsg.indexOf('E');
  int msgIdxJ6 = inMsg.indexOf('F');
  int msgIdxJ7 = inMsg.indexOf('H');
  int msgIdxJ8 = inMsg.indexOf('I');
  int msgIdxJ9 = inMsg.indexOf('J');
  int msgIdxJ10 = inMsg.indexOf('K');
  int msgIdxJ11= inMsg.indexOf('L');
  int msgIdxJ12 = inMsg.indexOf('N');
  
  currAccel[0] = inMsg.substring(msgIdxJ1 + 1, msgIdxJ2).toInt();
  currAccel[1] = inMsg.substring(msgIdxJ2 + 1, msgIdxJ3).toInt();
  currAccel[2] = inMsg.substring(msgIdxJ3 + 1, msgIdxJ4).toInt();
  currAccel[3] = inMsg.substring(msgIdxJ4 + 1, msgIdxJ5).toInt();
  currAccel[4] = inMsg.substring(msgIdxJ5 + 1, msgIdxJ6).toInt();
  currAccel[5] = inMsg.substring(msgIdxJ6 + 1, msgIdxJ7).toInt();
  currSpeed[0] = inMsg.substring(msgIdxJ7 + 1, msgIdxJ8).toInt();
  currSpeed[1] = inMsg.substring(msgIdxJ8 + 1, msgIdxJ9).toInt();
  currSpeed[2] = inMsg.substring(msgIdxJ9 + 1, msgIdxJ10).toInt();
  currSpeed[3] = inMsg.substring(msgIdxJ10 + 1, msgIdxJ11).toInt();
  currSpeed[4] = inMsg.substring(msgIdxJ11 + 1, msgIdxJ12).toInt();
  currSpeed[5] = inMsg.substring(msgIdxJ12 + 1).toInt();


  setJointSpeed(currSpeed, currAccel);
}

void endEffectorCommands(String inMsg) {
  homeEndEffector();
}

// Handles homing of end effector
void homeEndEffector() {
  endEff.setCurrentPosition(0);
    char garbage;
  while (Serial.available() > 0) {
    garbage = Serial.read();
  }
  Serial.println("H");
}

// Send arm angles back to PC
void sendArmFeedback() {

  char garbage;
  while (Serial.available() > 0) {
    garbage = Serial.read();
  }
  
  String outMsg = String("R") + String("A") + String(steppers[0].currentPosition()) + String("B") + String(steppers[1].currentPosition()) + String("C") + String(steppers[2].currentPosition())
                  + String("D") + String(steppers[3].currentPosition()) + String("E") + String(steppers[4].currentPosition()) + String("F") + String(steppers[5].currentPosition()) + String("H") + String(endEff.currentPosition())
                  + String("G") + String(analogRead(forceSensPin)) + String("Z");
  //
  Serial.println(outMsg);
}

// execute steppers to target positions
void runSteppers() {

  for (i = 0; i < NUM_AXES; i++) {
    steppers[i].run();
  }

  endEff.run();
}

void setJointSpeed(long speed[], long accel[]) {
  for (i = 0; i < NUM_AXES; i++) {
    steppers[i].setMaxSpeed(speed[i]);
    steppers[i].setAcceleration(accel[i]);
  }
}

// converts angles to steps for motors
void angleToSteps() {
  for(int i=0; i<NUM_AXES; i++){
    cmdArmSteps[i] = (cmdArmAngle[i]/100.0)*axisDir[i]*ppr[i]*red[i]/360.0;

    if(cmdArmSteps[i]/axisDir[i] > max_steps[i]/axisDir[i]) {
      cmdArmSteps[i] = max_steps[i];
    }

    else if(cmdArmSteps[i]/axisDir[i] < min_steps[i]/axisDir[i]) {
      cmdArmSteps[i] = min_steps[i];
    }
  }
}

// sets target positions (in steps) for motors
void cmdArm() {
  for(int i=0; i<NUM_AXES; i++) {
    steppers[i].moveTo(cmdArmSteps[i]);
  }

  // command end effector
  if(cmdEE == 29000)
  {
    endEff.stop();
  }

  else if(cmdEE == 30000){
    endEff.moveTo(endEffMax);
  }
    else if(cmdEE == 31000){
    endEff.moveTo(0);
  }

  else{
    endEff.moveTo(cmdEE);
  }
}

//****// ARM CALIBRATION FUNCTIONS//****//

void homeArm() {  // main function for full arm homing

  //initializeHomingMotion();
  //homeAxes();
  initializeMotion();
  
  char garbage;
  while (Serial.available() > 0) {
    garbage = Serial.read();
  }

  Serial.println("H");
}

// Runs through and checks if each axis has reached its limit switch, then runs it to specified home position
void homeAxes() {
  bool stopFlags[6] = { false, false, false, false, false, false };
  bool finishFlags[6] = { false, false, false, false, false, false };
  bool completeFlag = false;
  int count = 0;

  while (!completeFlag) {

    for (i = 0; i < NUM_AXES; i++) {

      if (!finishFlags[i]) {

        if (!digitalRead(limPins[i]) && !stopFlags[i]) {
          steppers[i].run();
        }

        else if (!stopFlags[i]) {
          steppers[i].setCurrentPosition(-homeComp[i]);
          steppers[i].stop();
          steppers[i].setMaxSpeed(maxSpeed[i]);
          steppers[i].setAcceleration(homeAccel[i]);
          steppers[i].moveTo(homeCompSteps[i]);
          stopFlags[i] = true;
        }

        else if (steppers[i].distanceToGo() != 0) {
          steppers[i].run();
        }

        else {
          finishFlags[i] = true;
          count++;
        }
      }
    }
    if (count == NUM_AXES) {
      completeFlag = true;
    }
  }
}

void initializeHomingMotion() {  // sets homing speed and acceleration and sets target homing position

  setJointSpeed(homeSpeed, homeAccel);

  for (i = 0; i < NUM_AXES; i++) {
    steppers[i].move(homePos[i]);

     if (i == 0 || i==5)  // Special case for axis 1
     {
       if ((axisDir[i] * steppers[i].currentPosition() > -homeCompSteps[i])) {
         steppers[i].move(-homePos[i]);
       } else {
         steppers[i].move(homePos[i]);
       }
     }
  }
}

void initializeMotion() {  // sets main program speeds for each axis and zeros position

  setJointSpeed(currSpeed, currAccel);

  for (int i = 0; i < NUM_AXES; i++) {
    steppers[i].setCurrentPosition(0);
  }
}
