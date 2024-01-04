using Microsoft.Win32;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace robotControllerGUI
{
    public partial class Form1 : Form
    {

        const int NUM_AXES = 7;
        bool connectedArm = false;
        double[] cmdPos = new double[NUM_AXES];
        double[] prevPos = new double[NUM_AXES-1];
        char[] cmdChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        char[] cmdCharsAccel = { 'H', 'I', 'J', 'K', 'L', 'N' };
        double[] red = { 50.0, 160.0, 92.3077, 43.936, 57.0, 5.0, 108.0};
        int[] maxSpeedAngle = { 20, 20, 20, 20, 30, 30 };
        int[] maxAccelAngle = { 25, 25, 25, 25, 40, 40 };
        int[] speedDelta = {0, 0, 0, 0, 0, 0 };
        int[] accelDelta = {0, 0, 0, 0, 0, 0 };
        int[] currSpeed = {0,0,0,0,0,0};
        int[] currAccel = {0,0,0,0,0,0};
        int[] poseSpeed = { 0, 0, 0, 0, 0, 0 };
        int[] poseAccel = { 0, 0, 0, 0, 0, 0 }; 
        int[] maxSpeed = {0,0,0,0,0,0};
        int[] maxAccel = {0,0,0,0,0,0};
        int gripperForceSens = 0;

        double endEffPos = 100;

        List<(double, double, double, double, double, double, double)> poses = new List<(double, double, double, double, double, double, double)>();

        int[] homeCompAngles = { 53, 49, 32, 100, 83, 0, 0 };
        int[] maxAngles = { 153, 150, 180, 180, 180, 100, 0 };
        int[] minAngles = { 0, 0, 0, 0, 0, 0, 0 };

        System.Windows.Forms.TextBox[] statusColor;
        System.Windows.Forms.TextBox[] currPosText;
        System.Windows.Forms.TrackBar[] currPosTrack;
        System.Windows.Forms.TextBox[] cmdPosText;
        Mutex serialLock = new Mutex();


        int[] axisDir = { -1, -1, -1, 1, 1, -1, 1 };
        double ppr = 400.0;
        double[] currPos = new double[NUM_AXES];
        String outMsg = "";
        String parameterMsg = "";
        int iAngles;
        bool homeFlag = false;
        bool mouseDown = false;
        bool openEE = false;
        bool endEffFlag = false;
        bool closeEE = false;
        bool wheelFlag = false;
        int mode = 0;
        public int poseModeSelect = 0;
        int accVal = 0;
        int velVal = 0;
        bool fileLoaded = false;
        int encVal = 0;
        int gripperOpenBtn = 0;
        int gripperCloseBtn = 0;
        int savePoseBtn = 0;
        int encVal_0 = 0;
        int encValPrev = 0;
        int filterPeriod_0 = 8;
        int poseDelay = 0;
        


        //Parsa added vars
        //serial com
        bool connectedController = false;
        string controllerPortName = "COM4";       //set like a constant
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();    //queue where incoming data is stored
        //state machine
        int packetState = 0;  //state of packet, 0 = not synched, 1 = synched
        int byteState = 1;    //state of individual byte inside packet

        //Joint Data
        double[] angles = new double[6];                      //int array for angles to be stored in
        double[] filteredAngles = new double[6];                      //int array for averaged angles to be stored in
        int i = 0;                                            //index for angles array
        MovingAverageFilter filteredA1 = new MovingAverageFilter(5);    //Filtered Axis 1 angles, window size: 6
        MovingAverageFilter filteredA2 = new MovingAverageFilter(5);    //Filtered Axis 2 angles, window size: 6
        MovingAverageFilter filteredA3 = new MovingAverageFilter(5);    //Filtered Axis 3 angles, window size: 6
        MovingAverageFilter filteredA4 = new MovingAverageFilter(5);    //Filtered Axis 4 angles, window size: 6
        MovingAverageFilter filteredA5 = new MovingAverageFilter(5);    //Filtered Axis 5 angles, window size: 6
        MovingAverageFilter filteredA6 = new MovingAverageFilter(5);    //Filtered Axis 6 angles, window size: 6
        MovingAverageFilter[] filters;
        PoseSequenceSave poseSequence = new PoseSequenceSave();
        PoseSequencePlayback posePlayback = new PoseSequencePlayback(4);

        double[] offset = { 516, 404, 292, 556, 764, 370 };    //offset voltages used to zero measured pot angles
        double[] sensitivity = { 0.2573671, 0.2555519, 0.2591009, 0.2536076, -0.27769, -0.2564069 }; //sign convection to match with robot


        public Form1()
        {
            InitializeComponent();
            disableControls();
            cmdTimer.Enabled = true;
            armPorts.Items.Clear();
            armPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            statusColor = new System.Windows.Forms.TextBox[] { a1status, a2status, a3status, a4status, a5status, a6status };
            currPosText = new System.Windows.Forms.TextBox[] { a1curr, a2curr, a3curr, a4curr, a5curr, a6curr };
            currPosTrack = new System.Windows.Forms.TrackBar[] { a1track, a2track, a3track, a4track, a5track, a6track };
            cmdPosText = new System.Windows.Forms.TextBox[] { a1, a2, a3, a4, a5, a6 };
            filters = new MovingAverageFilter[] { filteredA1, filteredA2, filteredA3, filteredA4, filteredA5, filteredA6 };


            this.KeyPreview = true;

            if (armPorts.Items.Count == 0)
            {
                armPorts.Text = "NO COM PORTS";
            }

            else
            {
                armPorts.SelectedIndex = 0;
            }

            for (i = 0; i < NUM_AXES; i++)
            {
                minAngles[i] = -homeCompAngles[i];
                maxAngles[i] = (maxAngles[i] - homeCompAngles[i]);
            }

            minAngles[0] = -maxAngles[0];
            minAngles[5] = -maxAngles[5];

            initSpeed();

            armPort.PortName = "COM3";
            armPort.BaudRate = 9600;
            connectedArm = false;

            controllerPort.PortName = controllerPortName;
            connectedController = false;

            cmdPos[6] = 29000;
            poseModeSelect = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdTimer.Enabled = true;
        }

        private void connectArmBtn_Click(object sender, EventArgs e)
        {
            if (!connectedArm)
            {
                try
                {
                    Debug.WriteLine("Opening Arm Serial Port");
                    armPort.Open();

                    if (armPort.IsOpen)
                    {
                        connectedArm = true;
                        Debug.WriteLine("Arm Successfully Connected");
                        sendMotionParams(currSpeed, currAccel);
                        connectArmBtn.Text = "Disconnect Arm Device";
                        homeArmBox.Enabled = true;
                        modesBox.Enabled = true;

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error opening the Arm serial port: " + ex.Message);
                }
            }
            else
            {
                armPort.Close();
                disableControls();
                Debug.WriteLine("Closing Serial Port");
                connectArmBtn.Text = "Connect Device";
                connectedArm = false;
            }
        }

        private void initSpeed()
        {
            for(int i=0; i<NUM_AXES-1; i++)
            {
                maxSpeed[i] = (int)(maxSpeedAngle[i] * red[i] * ppr / 360);
                maxAccel[i] = (int)(maxAccelAngle[i] * red[i] * ppr / 360);
                currSpeed[i] = maxSpeed[i];
                currAccel[i] = maxAccel[i];
                speedDelta[i] = maxSpeed[i] / 15;
                accelDelta[i] = maxAccel[i] / 15;
            }
        }

        private void homeArmBtn_Click(object sender, EventArgs e)
        {
            outMsg = "SHM";
            sendMessage(outMsg);

        }

        private void sendMessage(String msg)
        {
            serialLock.WaitOne(1000);

            if (armPort.IsOpen)
            {
                armPort.WriteLine(msg);
            }

            serialLock.ReleaseMutex();
        }

        private void updatePos()
        {
            for (i = 0; i < NUM_AXES - 1; i++)
            {
                cmdPos[i] = Convert.ToDouble(cmdPosText[i].Text) * 100;
            }
        }

        private void armPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (armPort.BytesToRead > 0)
            {
                string inMsg = armPort.ReadLine();
                Debug.WriteLine(inMsg);
                if (inMsg[0] == 'R')
                {
                    currPos = parseArmPos(inMsg);
                }

                else if (inMsg[0] == 'H')
                {
                    Debug.WriteLine("ARM CALIBRATED, READY TO CONTROL");
                    joystickMode.Enabled = true;
                    disableController.Enabled = true;
                    poseMode.Enabled = true;
                    homeFlag = true;
                }
            }
        }

        private double[] parseArmPos(string armMsg)
        {
            char[] delimiters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'Z' };
            string[] parts = armMsg.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            double[] positions = new double[NUM_AXES];

            for (int i = 1; i < NUM_AXES+1; i++)
            {
                    double position = Convert.ToDouble(parts[i]);
                    positions[i - 1] = position / (axisDir[i - 1] * ppr * red[i - 1]) * 360.0;
            }

            gripperForceSens = (int)Convert.ToDouble(parts[parts.Length-2]);
            return positions;
        }

        private void populateCurrPos()
        {

            for (i = 0; i < NUM_AXES - 1; i++)
            {
                currPosText[i].Text = currPos[i].ToString("F1");
                currPosTrack[i].Value = (int)currPos[i];

                if (Math.Abs(currPos[i] - cmdPos[i] / 100.0) <= 1)
                {
                    statusColor[i].BackColor = Color.Green;
                }
                else
                {
                    statusColor[i].BackColor = Color.Red;
                }
            }

            gripperPos.Value = (int)currPos[6];
            endEffPos = currPos[6] * red[6] * ppr / 360.0;
        }

        private void cmdTimer_Tick(object sender, EventArgs e)
        {
            int tempData;
            int rightByte = 0;
            int escByte;
            int combinedByte = 0;

            // Unpack MSP430 Sensor Data into Program
            if (controllerPort.IsOpen)
            {
                while (dataQueue.TryDequeue(out tempData))
                {
                    if (tempData == 255) //determine if we are at start of packet
                    {
                        packetState = 1;      //start of packet, synched
                    }
                    else if (packetState == 1 && byteState < angles.Length * 3 + 1)
                    {  //reciving data
                        if (byteState % 3 == 1)
                        {
                            combinedByte = tempData << 8;
                        }
                        else if (byteState % 3 == 2)
                        {
                            escByte = tempData;
                            if (escByte == 1) { rightByte = 255; }
                            combinedByte |= rightByte;  //add LSB
                            angles[iAngles] = (double)combinedByte;
                            iAngles++;
                        }
                        else                            //right  byte
                        {
                            rightByte = tempData;   //add LSB
                        }
                        byteState++;
                    }

                    // recieving gripper info
                    if(packetState == 1 && byteState < (angles.Length*3 + 5) && byteState >= (angles.Length*3+1))
                    {
                        if(byteState == angles.Length * 3 + 1)
                        {
                            savePoseBtn = tempData;
                        }

                        else if(byteState == angles.Length *3 + 2)
                        {
                            gripperCloseBtn = tempData;
                        }
                        else if(byteState == angles.Length*3 + 3)
                        {
                            gripperOpenBtn = tempData;
                        }
                        else if(byteState == angles.Length*3 + 4)
                        {
                            encValPrev = encVal;
                            encVal = tempData;
                        }

                        byteState++;

                    }
                    else if (byteState == angles.Length * 3 + 5)   //done packet
                    {
                        byteState = 0;      //reset both states
                        packetState = 0;    //reset both states
                        iAngles = 0;              //reset index of angles array
                    }
                }

                for (int i = 0; i < NUM_AXES - 1; i++)
                {
                    filters[i].AddDataPoint(angles[i]);
                    filteredAngles[i] = filters[i].ComputeAverage();
                    filteredAngles[i] = ((filteredAngles[i] - offset[i]) * sensitivity[i]);
                }


                if(savePoseBtn == 1 && poseDelay > 10)
                {
                    saveArmPose();
                    poseDelay = 0;
                }

                if(mode != 2)
                {
                    if (gripperOpenBtn == 1)
                    {
                        cmdPos[6] = 30000;
                    }

                    else if (gripperCloseBtn == 1)
                    {
                        cmdPos[6] = 31000;
                    }

                    else
                    {
                        cmdPos[6] = 29000;
                    }
                }

                if (encVal != encValPrev)
                {
                    int targetVal = encVal - 120;

                    if(targetVal >= 0)
                    {
                        vel.Value = Math.Min(targetVal, vel.Maximum);
                        acc.Value = Math.Min(targetVal, acc.Maximum);
                    }

                    else if (targetVal < 0)
                    {
                        vel.Value = Math.Max(targetVal, vel.Minimum);
                        acc.Value = Math.Max(targetVal, acc.Minimum);
                    }

                    updateSpeed();
                    updateAccel();
                }

                poseDelay++;
            }

            // Update GUI Display
            if (homeFlag) // edge case for first time homing
            {
                for (i = 0; i < NUM_AXES - 1; i++)
                {
                    cmdPos[i] = 0;
                    currPos[i] = 0;
                }

                cmdPos[6] = 29000;

                if (mode != 0)
                {
                    enableControls();
                }

                homeFlag = false;
            }

            if (!homeFlag && mode != 0 && armPort.IsOpen)
            {
                if(!(poseModeSelect == 1 && mode == 2))
                {
                    displayAxisAngles(); 
                }

                updatePos();
                populateCurrPos();
                ForceBar.Value = (100-((gripperForceSens*100)/1023))*(int)(100/75.0);
                if (ForceBar.Value <= 75)
                {
                    ForceBar.ForeColor = Color.Yellow;
                }
                else if(ForceBar.Value > 75)
                {
                    ForceBar.ForeColor = Color.Green;
                }
                

                // Send position commands to arm
                outMsg = "SMT";

                for (i = 0; i < NUM_AXES; i++)
                {
                    outMsg += cmdChars[i];
                    outMsg += cmdPos[i].ToString();
                }

                sendMessage(outMsg);
            }

            // Pose Sequence mode playback execution
            if(!homeFlag && poseModeSelect == 1 && mode == 2  && posePlayback.firstPose && !posePlayback.paused)
            {
                if (posePlayback.sequenceComplete)
                {
                    play.Checked = false;
                    posePlayback.paused = true;
                    posePlayback.sequenceComplete = false;
                    posePlayback.firstPose = false;
                }

                int count = 0;

                // shares commanded angles from pose sequence class and form class and update speeds for smooth motion
                if (posePlayback.moveStarted)
                {
                    for (int i = 0; i < NUM_AXES - 1; i++)
                    {
                        prevPos[i] = cmdPos[i];
                    }
                }

                posePlayback.sync(cmdPos);

                if(posePlayback.moveStarted)
                {
                    posePlayback.moveStarted = false;
                    calculateTrajectory();
                    sendMotionParams(poseSpeed, poseAccel);
                }

                endEffPos = cmdPos[6];

                if (Math.Abs(endEffPos / (ppr * red[6]) * 360.0 - currPos[6]) < 1)
                {
                    count++;
                }

                // checks that pose position has been reached before starting timer for pause between poses
                for (i=0; i < NUM_AXES-1; i++)
                {

                    cmdPosText[i].Text = (cmdPos[i] / 100.0).ToString();

                    if (Math.Abs(currPos[i] - cmdPos[i] / 100.0) < 0.3)
                    {
                        count++;
                        
                        if (count == NUM_AXES)
                        {
                            posePlayback.startTimer();

                        }
                    }
                }
            }
        }

        private void calculateTrajectory()
        {
            double[] delta = new double[NUM_AXES - 1];
            double maxTime = 0;
            int limitingAxis = 0;

            for (i = 0; i < NUM_AXES - 1; i++)
            {
                delta[i] = Math.Abs(cmdPos[i] - prevPos[i]) / 100.0;
                delta[i] = delta[i] * red[i] * ppr / 360;

                double t = 0;

                if (delta[i] != 0)
                {
                    t = delta[i] / (double)currSpeed[i] + currSpeed[i] / (double)currAccel[i];
                }

                if (t > maxTime)
                {
                    maxTime = t;
                    limitingAxis = i;
                }
            }

            for (i = 0; i < NUM_AXES - 1; i++)
            {
                if (i != limitingAxis)
                {
                    if (delta[i] != 0)
                    {
                        poseSpeed[i] = (int)Math.Round((currAccel[i] * maxTime - Math.Sqrt(Math.Pow(currAccel[i] * maxTime, 2) - 4 * currAccel[i] * delta[i])) / 2.0, 0);
                        poseAccel[i] = currAccel[i];
                    }
                    else
                    {
                        poseSpeed[i] = 0;
                        poseAccel[i] = 0;
                    }
                }
                else
                {
                    poseSpeed[i] = currSpeed[i];
                    poseAccel[i] = currAccel[i];
                }
            }
            Debug.WriteLine("");
            Debug.Write("Pose Time: ");
            Debug.WriteLine(maxTime);
        }


        private void disableController_CheckedChanged(object sender, EventArgs e)
        {
            if (disableController.Checked)
            {
                mode = 0;
                armMotionBox.Enabled = false;
                poseSequenceBox.Enabled = false;
                homeArmBox.Enabled = true;
                posePlayback.paused = true;
            }
        }

        private void joystickMode_CheckedChanged(object sender, EventArgs e)
        {
            if (joystickMode.Checked)
            {
                mode = 1;
                armMotionBox.Enabled = true;
                poseSequenceBox.Enabled = true;
                posePlayback.paused = true;

                sendMotionParams(currSpeed, currAccel);
            }
        }

        private void poseMode_CheckedChanged(object sender, EventArgs e)
        {
            if (poseMode.Checked)
            {
                mode = 2;
                armMotionBox.Enabled = true;
                poseSequenceBox.Enabled = true;
            }
        }

        private void disableControls()
        {
            modesBox.Enabled = false;
            homeArmBox.Enabled = false;
            armMotionBox.Enabled = false;
            poseSequenceBox.Enabled = false;
        }

        private void enableControls()
        {
            modesBox.Enabled = true;
            poseMode.Enabled = true;
            joystickMode.Enabled = true;
            disableController.Enabled = true;
            homeArmBox.Enabled = true;
            armMotionBox.Enabled = true;
            poseSequenceBox.Enabled = true;
        }

        private void vel_Scroll_1(object sender, EventArgs e)
        {
            updateSpeed();
        }

        private void acc_Scroll_1(object sender, EventArgs e)
        {
            updateAccel();
        }

        private void updateSpeed()
        {
            for (int i = 0; i < NUM_AXES - 1; i++)
            {
                currSpeed[i] = maxSpeed[i] + vel.Value * speedDelta[i];
            }
            if (mode != 2)
            {
                sendMotionParams(currSpeed, currAccel);
            }
        }

        private void updateAccel()
        {
            for (int i = 0; i < NUM_AXES - 1; i++)
            {
                currAccel[i] = maxAccel[i] + acc.Value * accelDelta[i];
            }
            if (mode != 2)
            {
                sendMotionParams(currSpeed, currAccel);
            }
        }

        private void vel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void acc_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void acc_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (accVal != acc.Value)
            {
                accVal = acc.Value;
                for (int i = 0; i < NUM_AXES - 1; i++)
                {
                    currAccel[i] = maxAccel[i] + acc.Value * accelDelta[i];
                }

                if(mode != 2)
                {
                    sendMotionParams(currSpeed, currAccel);
                }
            }
        }

        private void vel_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
            if (velVal != vel.Value)
            {
                velVal = vel.Value;
                for (int i = 0; i < NUM_AXES - 1; i++)
                {
                    currSpeed[i] = maxSpeed[i] + vel.Value * speedDelta[i];
                }
                if(mode != 2)
                {
                    sendMotionParams(currSpeed, currAccel);
                }
            }
        }

        private void sendMotionParams(int[] speed, int[] accel)
        {
            if(!mouseDown)
            {
                parameterMsg = "SMP";

                for (int i = 0; i < NUM_AXES - 1; i++)
                {
                    parameterMsg += cmdChars[i];
                    parameterMsg += accel[i].ToString();
                }

                for (int i=0; i < NUM_AXES - 1; i++)
                {
                    parameterMsg += cmdCharsAccel[i];
                    parameterMsg += speed[i].ToString();
                }


                sendMessage(parameterMsg);
            }
        }

        private void recordSequence_CheckedChanged(object sender, EventArgs e)
        {
            if (recordSequence.Checked)
            {
                poseModeSelect = 0;
            }
        }

        private void playbackSequence_CheckedChanged(object sender, EventArgs e)
        {
            if (playbackSequence.Checked)
            {
                poseModeSelect = 1;
                loop.Checked = false;
            }
        }

        private void savePose_Click(object sender, EventArgs e)
        {

            saveArmPose();
        }

        private void saveArmPose()
        {
            double[] cmdPosSave = { 0, 0, 0, 0, 0, 0 };

            if (true)
            {
                for (int i = 0; i < NUM_AXES - 1; i++)
                {
                    if (cmdPos[i] / 100 > maxAngles[i])
                    {
                        cmdPosSave[i] = maxAngles[i] * 100.0;
                    }
                    else if (cmdPos[i] / 100 < minAngles[i])
                    {
                        cmdPosSave[i] = minAngles[i] * 100.0;
                    }
                    else
                    {
                        cmdPosSave[i] = cmdPos[i];
                    }
                    
                }
                Debug.WriteLine("POSE SAVED!");
                poseSequence.savePose(cmdPosSave[0], cmdPosSave[1], cmdPosSave[2], cmdPosSave[3], cmdPosSave[4], cmdPosSave[5], endEffPos);
            }
        }

        private void saveSequence_Click(object sender, EventArgs e)
        {
            if (poseModeSelect == 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "CSV FILES|*.csv|All Files|*.*",
                    Title = "Save CSV File",
                    RestoreDirectory = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    poseSequence.saveSequence(fileName);
                }
            }
        }


        private void connectContBtn_Click(object sender, EventArgs e)
        {
            if (!connectedController)
            {
                try
                {
                    Debug.WriteLine("Opening Controller Serial Port");
                    controllerPort.Open();

                    if (controllerPort.IsOpen)
                    {
                        connectedController = true;
                        connectContBtn.Text = "Disconnect Device";
                        Debug.WriteLine("Controller Successfully Connected");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error opening the controller serial port: " + ex.Message);
                }
            }
            else
            {
                controllerPort.Close();
                Debug.WriteLine("Closing Controller Serial Port");
                connectContBtn.Text = "Connect Device";
                connectedController = false;
            }
        }

        private void controllerPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int newByte = 0;
            int bytesToRead;
            bytesToRead = controllerPort.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = controllerPort.ReadByte();
                dataQueue.Enqueue(newByte);
                bytesToRead = controllerPort.BytesToRead;
            }
        }


        private void displayAxisAngles()
        {

            for (i = 0; i < NUM_AXES - 1; i++)
            {
                cmdPosText[i].Text = Math.Round(filteredAngles[i], 0).ToString();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                cmdPos[6] = 30000;
            }

            else if (e.KeyCode == Keys.E)
            {
                cmdPos[6] = 31000;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E || e.KeyCode == Keys.R)
            {
                cmdPos[6] = 29000;
            }


        }

        private void homeGripperBtn_Click(object sender, EventArgs e)
        {
            outMsg = "SEEH";
            sendMessage(outMsg);
        }

        private void gripperPos_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            updateFilterPeriod();
        }

        private void updateFilterPeriod()
        {
            for (i = 0; i < NUM_AXES - 1; i++)
            {
                filters[i].updateFilterWindow(Convert.ToInt16(filterVal.Value));
            }
        }

        private void loadSequence_Click(object sender, EventArgs e)
        {
            if (poseModeSelect == 1 && mode == 2)
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string file = ofd.FileName;
                    posePlayback.clear();
                    posePlayback.loadSequence(file);
                    loadedSequence.Text = file;
                    fileLoaded = true;
                }
            }
        }


        private void play_CheckedChanged(object sender, EventArgs e)
        {
            if (play.Checked && fileLoaded)
            {
                posePlayback.play();
            }
        }

        private void pause_CheckedChanged(object sender, EventArgs e)
        {
            if (pause.Checked && fileLoaded)
            {
                posePlayback.pause();
            }
        }

        private void stop_CheckedChanged(object sender, EventArgs e)
        {
            if(stop.Checked && fileLoaded)
            {
                posePlayback.stop();
            }
        }

        private void loop_CheckedChanged(object sender, EventArgs e)
        {
            if (loop.Checked)
            {
                posePlayback.loop = true;
            }
        }

        private void holdTime_Scroll(object sender, EventArgs e)
        {
            posePlayback.updateTimer(holdTime.Value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            armPort.Close();
            controllerPort.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }


    public class MovingAverageFilter
    {
        private Queue<double> dataQueue;
        public int windowSize;

        public MovingAverageFilter(int windowSize)
        {
            if (windowSize <= 0)
            {
                throw new ArgumentException("Window size must be greater than zero.");
            }

            this.windowSize = windowSize;
            this.dataQueue = new Queue<double>(windowSize);
        }

        public void AddDataPoint(double dataPoint)
        {
            dataQueue.Enqueue(dataPoint);

            if (dataQueue.Count > windowSize)
            {
                dataQueue.Dequeue(); // Remove oldest data point if the queue exceeds the window size
            }

        }

        public double ComputeAverage()
        {
            if (dataQueue.Count == 0)
            {
                throw new InvalidOperationException("No data points to compute the average.");
            }

            return dataQueue.Average();
        }

        public void updateFilterWindow(int windowSize)
        {
            this.windowSize = windowSize;
        }

    }

    public class PoseSequenceSave
    {
        public List<(double, double, double, double, double, double, double)> poses = new List<(double, double, double, double, double, double, double)>();

        public void savePose(double a1, double a2, double a3, double a4, double a5, double a6, double ee)
        {
            poses.Add((a1, a2, a3, a4, a5, a6, ee));
        }

        public void saveSequence(string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file, false, Encoding.UTF8))
                {

                    foreach (var pose in poses)
                    {
                        string line = $"{pose.Item1},{pose.Item2},{pose.Item3},{pose.Item4},{pose.Item5},{pose.Item6},{pose.Item7}";

                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poses.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


    public class PoseSequencePlayback
    {
        List<(double, double, double, double, double, double, double)> loadedPoses = new List<(double, double, double, double, double, double, double)>();
        public bool playing = false;
        public bool paused = false;
        public bool loop = false;
        public bool firstPose = false;
        public bool moveStarted = false;
        public bool sequenceComplete = false;
        private static System.Timers.Timer poseTimer;
        int i = 0;
        private double[] currPose = new double[7];

        public PoseSequencePlayback(int playbackSpeed)
        {
            poseTimer = new System.Timers.Timer(playbackSpeed * 500);
            poseTimer.Elapsed += updatePose;
        }


        public void loadSequence(string fileName)
        {
            using (StreamReader poseSequence = new StreamReader(fileName))
            {
                string line;
                while ((line = poseSequence.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    double a1 = double.Parse(values[0]);
                    double a2 = double.Parse(values[1]);
                    double a3 = double.Parse(values[2]);
                    double a4 = double.Parse(values[3]);
                    double a5 = double.Parse(values[4]);
                    double a6 = double.Parse(values[5]);
                    double ee = double.Parse(values[6]);

                    loadedPoses.Add((a1, a2, a3, a4, a5, a6, ee));
                }
            }
        }

        public void play()
        {
            paused = false;
            if (!firstPose)
            {
                firstPoseCmd();
                firstPose = true;
            }
        }

        public void pause()
        {
            paused = true;
            poseTimer.Stop();
        }

        public void stop()
        {
            paused = true;
            poseTimer.Stop();
            firstPose = false;
            i = 0;
        }

        public void clear()
        {
            loadedPoses.Clear();
        }

        private void updatePose(object source, ElapsedEventArgs e)
        {

            currPose[0] = loadedPoses[i].Item1;
            currPose[1] = loadedPoses[i].Item2;
            currPose[2] = loadedPoses[i].Item3;
            currPose[3] = loadedPoses[i].Item4;
            currPose[4] = loadedPoses[i].Item5;
            currPose[5] = loadedPoses[i].Item6;
            currPose[6] = loadedPoses[i].Item7;

            i++;

            if (i == loadedPoses.Count)
            {
                i = 0;
                if (!loop)
                {
                    sequenceComplete = true;
                }
            }

            poseTimer.Stop();
            moveStarted = true;
        }

        private void firstPoseCmd()
        {

            currPose[0] = loadedPoses[i].Item1;
            currPose[1] = loadedPoses[i].Item2;
            currPose[2] = loadedPoses[i].Item3;
            currPose[3] = loadedPoses[i].Item4;
            currPose[4] = loadedPoses[i].Item5;
            currPose[5] = loadedPoses[i].Item6;
            currPose[6] = loadedPoses[i].Item7;

            i++;
            if (i == loadedPoses.Count)
            {
                i = 0;
                if (!loop)
                {
                    sequenceComplete = true;
                }
            }

            moveStarted = true;
            
        }

        public void sync(double[] targetArray)
        {
            for(int j=0; j<7; j++)
            {
                targetArray[j] = currPose[j];
            }
        }

        public void updateTimer(int playbackSpeed)
        {
            poseTimer.Interval = (playbackSpeed)*500+500;
        }

        public void startTimer()
        {
            poseTimer.Start();
        }
    }
}


