using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotControllerGUI
{
    public partial class Form1 : Form
    {
        const int NUM_AXES = 7;
        bool connected = false;
        double[] cmdPos = new double[NUM_AXES];
        char[] cmdChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G'};
        double[] red = { 50.0, 160.0, 92.3077, 43.936, 57.0, 14.0, 1};

        int[] homeCompAngles = { 50, 0, 0, 100, 30, 90, 0};
        int[] maxAngles = { 200, 100, 180, 180, 120, 320, 0 };
        int[] minAngles = { 0, 0, 0, 0, 0, 0, 0 };

        TextBox[] statusColor;
        TextBox[] currPosText;


        int[] axisDir = { 1, -1, -1, 1, -1, -1 , 1};
        double ppr = 400.0;
        double[] currPos = new double[NUM_AXES];
        String outMsg = "";
        int i;
        bool homeFlag = false;
        bool timerFlag = false;

        public Form1()
        {
            InitializeComponent();
            homeArmBox.Enabled = false;
            armPosBox.Enabled = false;
            measuredPosBox.Enabled = false;
            cmdTimer.Enabled = true;
            armPorts.Items.Clear();
            armPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            statusColor = new TextBox[] { a1status, a2status, a3status, a4status, a5status, a6status };
            currPosText = new TextBox[] { a1curr, a2curr, a3curr, a4curr, a5curr, a6curr };

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
                minAngles[i] = -homeCompAngles[i]*axisDir[i];
                maxAngles[i] = (maxAngles[i] - homeCompAngles[i])*axisDir[i];
            }

            armPort.PortName = armPorts.Text;
            armPort.BaudRate = 9600;
            connected = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectArmBtn_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                try
                {
                    Debug.WriteLine("Opening Serial Port");
                    armPort.Open();

                    if (armPort.IsOpen)
                    {
                        connected = true;
                        connectArmBtn.Text = "Disconnect Device";
                        homeArmBox.Enabled = true;

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error opening the serial port: " + ex.Message);
                }
            }
            else
            {
                armPort.Close();
                homeArmBox.Enabled = false;
                armPosBox.Enabled = false;
                measuredPosBox.Enabled = false;
                Debug.WriteLine("Closing Serial Port");
                connectArmBtn.Text = "Connect Device";
                connected = false;
            }
        }

        private void moveArmBtn_Click(object sender, EventArgs e)
        {
            updatePos();
            outMsg = "SMT";

            for (i = 0; i < NUM_AXES; i++)
            {
                outMsg += cmdChars[i];
                outMsg += cmdPos[i].ToString();
            }

            sendMessage(outMsg);
        }

        private void homeArmBtn_Click(object sender, EventArgs e)
        {
            outMsg = "SHM";
            sendMessage(outMsg);

        }

        private void sendMessage(String msg)
        {
            if (armPort.IsOpen)
            {
                armPort.WriteLine(msg);
            }
        }

        private void updatePos()
        {
            cmdPos[0] = Convert.ToDouble(a1.Text) * 100;
            cmdPos[1] = Convert.ToDouble(a2.Text) * 100;
            cmdPos[2] = Convert.ToDouble(a3.Text) * 100;
            cmdPos[3] = Convert.ToDouble(a4.Text) * 100;
            cmdPos[4] = Convert.ToDouble(a5.Text) * 100;
            cmdPos[5] = Convert.ToDouble(a6.Text) * 100;
            cmdPos[6] = 0;
        }

        private void armPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(armPort.BytesToRead > 0)
            {
                string inMsg = armPort.ReadLine();

                if (inMsg[0] == 'R')
                {
                    currPos = parseArmPos(inMsg);
                }

                else if (inMsg[0] == 'H')
                {
                    Debug.WriteLine("ARM CALIBRATED, READY TO CONTROL");
                    homeFlag = true;
                }
            }
        }

        private double[] parseArmPos(string armMsg)
        {
            char[] delimiters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'Z' };
            string[] parts = armMsg.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            double[] positions = new double[NUM_AXES];

            for (int i = 1; i < positions.Length && i < parts.Length; i++)
            {
                if (double.TryParse(parts[i], out double position))
                {
                    // Assuming axisDir, ppr, and red are arrays defined elsewhere in your code
                    positions[i-1] = position / (axisDir[i-1] * ppr * red[i-1]) * 360.0;
                }
                else
                {
                    Console.WriteLine($"Error parsing position {i}: {parts[i]}");
                }
            }

            return positions;
        }

        private void populateCurrPos()
        {

            for(i=0; i< NUM_AXES-1; i++)
            {
                currPosText[i].Text = currPos[i].ToString("F1");
                if (Math.Abs(currPos[i] - cmdPos[i]/100.0) < 1)
                {
                    statusColor[i].BackColor = Color.Green;
                }
                else
                {
                    statusColor[i].BackColor = Color.Red;
                }
            }
        }

        private void cmdTimer_Tick(object sender, EventArgs e)
        {

            if (homeFlag)
            {
                for (i = 0; i < NUM_AXES; i++)
                {
                    cmdPos[i] = 0;
                    currPos[i] = 0;
                }
                armPosBox.Enabled = true;
                measuredPosBox.Enabled = true;
                homeFlag = false;
                timerFlag = true;
            }

            if (timerFlag)
            {
                populateCurrPos();
                outMsg = "SMT";

                for (i = 0; i < NUM_AXES; i++)
                {
                    outMsg += cmdChars[i];
                    outMsg += cmdPos[i].ToString();

                }

                sendMessage(outMsg);
            }
        }
    }
}
