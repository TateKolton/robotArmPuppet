/*
Created By: Tate Kolton, Parsa Khodabakhshi
Created On: October 15, 2023
Description: Header file for driving a 6 axis robot arm and communicating with a host PC software
*/

#include <AccelStepper.h>
#include <Encoder.h>

// general parameters
#define NUM_AXES 6
#define ON 0
#define OFF 1
#define SW_ON 0
#define SW_OFF 1
#define FWD 1
#define REV 0

// Motor pins
int stepPins[6] =   {6, 8, 0, 10, 12, 25}; 
int dirPins[6] =    {26, 7, 1, 9, 11, 24}; 

// Encoder pins
int encPinA[6] = {17, 38, 40, 36, 13, 15};
int encPinB[6] = {16, 37, 39, 35, 41, 14};

// limit switch pins
int limPins[6] = {18, 19, 20, 21, 23, 22};

//force sensor feedback
int forceSensPin = A13; //pin 27

// pulses per revolution for motors
long ppr[6] = {400, 400, 400, 400, 400, 400};

// Gear Reductions
float red[6] = {50.0, 160.0, 92.3077, 43.936, 57.0, 5.0};

// End effector variables
const int closePos = 0;
const int openPos = 500; 
const int EEstepPin = 4;
const int endEffMax = 12000;
const int EEdirPin = 3;
const int speedEE = 2000;
const int accEE = 6000;
const int MOTOR_DIR_EE = 1;
const int forcePin = 12;


// Position
double currPos[NUM_AXES], cmdArmAngle[NUM_AXES];
double cmdEE;
int cmdArmSteps[NUM_AXES];
int cmdEESteps;

// Motor speeds and accelerations
const int maxSpeedAngle[6] = {15, 15, 15, 15, 30, 30}; 
const int maxAccelAngle[6] = {20, 20, 20, 20, 50, 50};
long maxSpeed[6] = {0};
long maxAccel[6] = {0};
const int homeSpeed[6] = {800, 800, 800, 1000, 800, 200}; 
const int homeAccel[6] = {800, 800, 800, 800, 800, 200}; 
int speedDelta[6] = {0};
int accelDelta[6] = {0};
int currSpeed[6] = {0, 0, 0, 0, 0, 0};
int currAccel[6] = {0, 0, 0, 0, 0, 0};

// Stepper motor objects for AccelStepper library
AccelStepper steppers[6];
AccelStepper endEff(1, EEstepPin, EEdirPin);

// Encoder objects for Encoder library
Encoder enc1(encPinA[0], encPinB[0]);
Encoder enc2(encPinA[1], encPinB[1]);
Encoder enc3(encPinA[2], encPinB[2]);
Encoder enc4(encPinA[3], encPinB[3]);
Encoder enc5(encPinA[4], encPinB[4]);
Encoder enc6(encPinA[5], encPinB[5]);

// General Global Variable declarations
const int axisDir[6] = {-1, -1, -1, 1, 1, -1};  
int i;
bool initFlag = false;
bool jointFlag = false; 
bool IKFlag = false;
bool resetEE = false;

// Variables for homing / arm calibration
long homePosConst = -99000;
long homePos[] = {axisDir[0]*homePosConst, axisDir[1]*homePosConst, axisDir[2]*homePosConst, axisDir[3]*homePosConst, axisDir[4]*homePosConst, axisDir[5]*homePosConst};
double homeCompAngles[] = {53, 45, 32, 100.5, 83.5, 0};
//100.5
long homeCompConst[] = {500, 1000, 1000, 500, 500, 0};
long homeComp[] = {axisDir[0]*homeCompConst[0], axisDir[1]*homeCompConst[1], axisDir[2]*homeCompConst[2], axisDir[3]*homeCompConst[3], axisDir[4]*homeCompConst[4], axisDir[5]*homeCompConst[5]};
long homeCompSteps[] = {axisDir[0]*homeCompAngles[0]*red[0]*ppr[0]/360.0, axisDir[1]*homeCompAngles[1]*red[1]*ppr[1]/360.0, axisDir[2]*homeCompAngles[2]*red[2]*ppr[2]/360.0, axisDir[3]*homeCompAngles[3]*red[3]*ppr[3]/360.0, axisDir[4]*homeCompAngles[4]*red[4]*ppr[4]/360.0, axisDir[5]*homeCompAngles[5]*red[5]*ppr[5]/360.0};

// Range of motion (degrees) for each axis
int maxAngles[6] = {153, 150, 180, 180, 180, 100};
long max_steps[] = {axisDir[0]*red[0]*maxAngles[0]/360.0*ppr[0], axisDir[1]*red[1]*maxAngles[1]/360.0*ppr[1], axisDir[2]*red[2]*maxAngles[2]/360.0*ppr[2], axisDir[3]*red[3]*maxAngles[3]/360.0*ppr[3], axisDir[4]*red[4]*maxAngles[4]/360.0*ppr[4], axisDir[5]*red[5]*maxAngles[5]/360.0*ppr[5]};
long min_steps[NUM_AXES]; 
char value;


//****// FUNCTION PROTOTYPES //****//

// Waits for a message to be published to the serial port.
void recieveCommand();

// Parses the message passed to it and determines which subfunction to call for control of arm.
void parseMessage(String inMsg);

// Sets the max speed and acceleration for each joint and motor to its Joint Mode speed.
void setJointSpeed();

// Prints the current encoder position for each axis to serial.
void sendArmFeedback();

// Sets target position for all motors
void cmdArm();

// Main function for homing the entire arm.
void homeArm();

// Runs through and checks if each axis has reached its limit switch, then runs it a couple steps away from switch for 0 position.
void homeAxes();

// sets homing speed and acceleration for axes 1-6 and sets target homing position.
void initializeHomingMotion();

// sets main program speeds for each axis.
void initializeMotion();

// Runs all stepper motors to target position (if no target defined, motors will not move).
void runSteppers();

// Waits for the user to press the home button before continuing with other functions. Reads serial port and homes the arm if "HM___" is read.
void waitForHome();

// Move arm to controller specified pose
void commandArmPose(String inMsg);

// Convert axes angles to motor steps
void angleToSteps();

// Function to command end effector
void endEffectorCommands(String inMsg);

// Homes end effector
void homeEndEffector();

// Function to move end effector
void cmdEndEff();
