namespace robotControllerGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.TextBox();
            this.a3 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.a5 = new System.Windows.Forms.TextBox();
            this.a6 = new System.Windows.Forms.TextBox();
            this.a4 = new System.Windows.Forms.TextBox();
            this.armPosBox = new System.Windows.Forms.GroupBox();
            this.armPort = new System.IO.Ports.SerialPort(this.components);
            this.homeArmBox = new System.Windows.Forms.GroupBox();
            this.homeGripperBtn = new System.Windows.Forms.Button();
            this.homeArmBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectContBtn = new System.Windows.Forms.Button();
            this.armPorts = new System.Windows.Forms.ComboBox();
            this.connectArmBtn = new System.Windows.Forms.Button();
            this.cmdTimer = new System.Windows.Forms.Timer(this.components);
            this.measuredPosBox = new System.Windows.Forms.GroupBox();
            this.a6track = new System.Windows.Forms.TrackBar();
            this.a5track = new System.Windows.Forms.TrackBar();
            this.a4track = new System.Windows.Forms.TrackBar();
            this.a3track = new System.Windows.Forms.TrackBar();
            this.a2track = new System.Windows.Forms.TrackBar();
            this.a1track = new System.Windows.Forms.TrackBar();
            this.a2status = new System.Windows.Forms.TextBox();
            this.a3status = new System.Windows.Forms.TextBox();
            this.a4status = new System.Windows.Forms.TextBox();
            this.a5status = new System.Windows.Forms.TextBox();
            this.a6status = new System.Windows.Forms.TextBox();
            this.a1status = new System.Windows.Forms.TextBox();
            this.a1curr = new System.Windows.Forms.TextBox();
            this.a3curr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.a2curr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.a5curr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.a6curr = new System.Windows.Forms.TextBox();
            this.a4curr = new System.Windows.Forms.TextBox();
            this.poseSequenceBox = new System.Windows.Forms.GroupBox();
            this.stop = new System.Windows.Forms.RadioButton();
            this.pause = new System.Windows.Forms.RadioButton();
            this.loop = new System.Windows.Forms.CheckBox();
            this.play = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.holdTime = new System.Windows.Forms.TrackBar();
            this.loadedSequence = new System.Windows.Forms.TextBox();
            this.saveSequence = new System.Windows.Forms.Button();
            this.savePose = new System.Windows.Forms.Button();
            this.playbackSequence = new System.Windows.Forms.RadioButton();
            this.loadSequence = new System.Windows.Forms.Button();
            this.recordSequence = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modesBox = new System.Windows.Forms.GroupBox();
            this.disableController = new System.Windows.Forms.RadioButton();
            this.poseMode = new System.Windows.Forms.RadioButton();
            this.joystickMode = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.vel = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.TrackBar();
            this.armMotionBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.filter = new System.Windows.Forms.Label();
            this.filterVal = new System.Windows.Forms.TrackBar();
            this.controllerPort = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.gripperPos = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.ForceBar = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.armPosBox.SuspendLayout();
            this.homeArmBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.measuredPosBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a6track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a5track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1track)).BeginInit();
            this.poseSequenceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holdTime)).BeginInit();
            this.modesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc)).BeginInit();
            this.armMotionBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gripperPos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(646, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot Arm Controller";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(70, 34);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(100, 26);
            this.a1.TabIndex = 1;
            this.a1.Text = "0";
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(70, 148);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(100, 26);
            this.a3.TabIndex = 6;
            this.a3.Text = "0";
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(70, 87);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(100, 26);
            this.a2.TabIndex = 7;
            this.a2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Axis 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Axis 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Axis 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Axis 6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Axis 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Axis 4";
            // 
            // a5
            // 
            this.a5.Location = new System.Drawing.Point(70, 254);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(100, 26);
            this.a5.TabIndex = 13;
            this.a5.Text = "0";
            // 
            // a6
            // 
            this.a6.Location = new System.Drawing.Point(70, 307);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(100, 26);
            this.a6.TabIndex = 12;
            this.a6.Text = "0";
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(70, 203);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(100, 26);
            this.a4.TabIndex = 11;
            this.a4.Text = "0";
            // 
            // armPosBox
            // 
            this.armPosBox.Controls.Add(this.a1);
            this.armPosBox.Controls.Add(this.a3);
            this.armPosBox.Controls.Add(this.label5);
            this.armPosBox.Controls.Add(this.a2);
            this.armPosBox.Controls.Add(this.label6);
            this.armPosBox.Controls.Add(this.label2);
            this.armPosBox.Controls.Add(this.label7);
            this.armPosBox.Controls.Add(this.label3);
            this.armPosBox.Controls.Add(this.a5);
            this.armPosBox.Controls.Add(this.label4);
            this.armPosBox.Controls.Add(this.a6);
            this.armPosBox.Controls.Add(this.a4);
            this.armPosBox.Location = new System.Drawing.Point(21, 31);
            this.armPosBox.Name = "armPosBox";
            this.armPosBox.Size = new System.Drawing.Size(268, 376);
            this.armPosBox.TabIndex = 19;
            this.armPosBox.TabStop = false;
            this.armPosBox.Text = "Commanded Position";
            // 
            // armPort
            // 
            this.armPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.armPort_DataReceived);
            // 
            // homeArmBox
            // 
            this.homeArmBox.Controls.Add(this.homeGripperBtn);
            this.homeArmBox.Controls.Add(this.homeArmBtn);
            this.homeArmBox.Location = new System.Drawing.Point(626, 139);
            this.homeArmBox.Name = "homeArmBox";
            this.homeArmBox.Size = new System.Drawing.Size(268, 148);
            this.homeArmBox.TabIndex = 20;
            this.homeArmBox.TabStop = false;
            this.homeArmBox.Text = "Calibrate Arm";
            // 
            // homeGripperBtn
            // 
            this.homeGripperBtn.Location = new System.Drawing.Point(26, 89);
            this.homeGripperBtn.Name = "homeGripperBtn";
            this.homeGripperBtn.Size = new System.Drawing.Size(208, 38);
            this.homeGripperBtn.TabIndex = 18;
            this.homeGripperBtn.Text = "Zero Gripper";
            this.homeGripperBtn.UseVisualStyleBackColor = true;
            this.homeGripperBtn.Click += new System.EventHandler(this.homeGripperBtn_Click);
            // 
            // homeArmBtn
            // 
            this.homeArmBtn.Location = new System.Drawing.Point(26, 35);
            this.homeArmBtn.Name = "homeArmBtn";
            this.homeArmBtn.Size = new System.Drawing.Size(208, 38);
            this.homeArmBtn.TabIndex = 17;
            this.homeArmBtn.Text = "Home Arm";
            this.homeArmBtn.UseVisualStyleBackColor = true;
            this.homeArmBtn.Click += new System.EventHandler(this.homeArmBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectContBtn);
            this.groupBox1.Controls.Add(this.armPorts);
            this.groupBox1.Controls.Add(this.connectArmBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 148);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Arm";
            // 
            // connectContBtn
            // 
            this.connectContBtn.Location = new System.Drawing.Point(18, 91);
            this.connectContBtn.Name = "connectContBtn";
            this.connectContBtn.Size = new System.Drawing.Size(343, 32);
            this.connectContBtn.TabIndex = 20;
            this.connectContBtn.Text = "Connect Controller";
            this.connectContBtn.UseVisualStyleBackColor = true;
            this.connectContBtn.Click += new System.EventHandler(this.connectContBtn_Click);
            // 
            // armPorts
            // 
            this.armPorts.FormattingEnabled = true;
            this.armPorts.Location = new System.Drawing.Point(18, 42);
            this.armPorts.Name = "armPorts";
            this.armPorts.Size = new System.Drawing.Size(164, 28);
            this.armPorts.TabIndex = 19;
            // 
            // connectArmBtn
            // 
            this.connectArmBtn.Location = new System.Drawing.Point(201, 40);
            this.connectArmBtn.Name = "connectArmBtn";
            this.connectArmBtn.Size = new System.Drawing.Size(160, 32);
            this.connectArmBtn.TabIndex = 18;
            this.connectArmBtn.Text = "Connect Arm";
            this.connectArmBtn.UseVisualStyleBackColor = true;
            this.connectArmBtn.Click += new System.EventHandler(this.connectArmBtn_Click);
            // 
            // cmdTimer
            // 
            this.cmdTimer.Tick += new System.EventHandler(this.cmdTimer_Tick);
            // 
            // measuredPosBox
            // 
            this.measuredPosBox.Controls.Add(this.a6track);
            this.measuredPosBox.Controls.Add(this.a5track);
            this.measuredPosBox.Controls.Add(this.a4track);
            this.measuredPosBox.Controls.Add(this.a3track);
            this.measuredPosBox.Controls.Add(this.a2track);
            this.measuredPosBox.Controls.Add(this.a1track);
            this.measuredPosBox.Controls.Add(this.a2status);
            this.measuredPosBox.Controls.Add(this.a3status);
            this.measuredPosBox.Controls.Add(this.a4status);
            this.measuredPosBox.Controls.Add(this.a5status);
            this.measuredPosBox.Controls.Add(this.a6status);
            this.measuredPosBox.Controls.Add(this.a1status);
            this.measuredPosBox.Controls.Add(this.a1curr);
            this.measuredPosBox.Controls.Add(this.a3curr);
            this.measuredPosBox.Controls.Add(this.label8);
            this.measuredPosBox.Controls.Add(this.a2curr);
            this.measuredPosBox.Controls.Add(this.label9);
            this.measuredPosBox.Controls.Add(this.label10);
            this.measuredPosBox.Controls.Add(this.label11);
            this.measuredPosBox.Controls.Add(this.label12);
            this.measuredPosBox.Controls.Add(this.a5curr);
            this.measuredPosBox.Controls.Add(this.label13);
            this.measuredPosBox.Controls.Add(this.a6curr);
            this.measuredPosBox.Controls.Add(this.a4curr);
            this.measuredPosBox.Location = new System.Drawing.Point(307, 32);
            this.measuredPosBox.Name = "measuredPosBox";
            this.measuredPosBox.Size = new System.Drawing.Size(553, 375);
            this.measuredPosBox.TabIndex = 20;
            this.measuredPosBox.TabStop = false;
            this.measuredPosBox.Text = "Measured Position";
            // 
            // a6track
            // 
            this.a6track.Location = new System.Drawing.Point(176, 299);
            this.a6track.Maximum = 100;
            this.a6track.Minimum = -100;
            this.a6track.Name = "a6track";
            this.a6track.Size = new System.Drawing.Size(305, 69);
            this.a6track.TabIndex = 44;
            // 
            // a5track
            // 
            this.a5track.Location = new System.Drawing.Point(176, 245);
            this.a5track.Maximum = 97;
            this.a5track.Minimum = -84;
            this.a5track.Name = "a5track";
            this.a5track.Size = new System.Drawing.Size(305, 69);
            this.a5track.TabIndex = 43;
            // 
            // a4track
            // 
            this.a4track.Location = new System.Drawing.Point(176, 192);
            this.a4track.Maximum = 80;
            this.a4track.Minimum = -101;
            this.a4track.Name = "a4track";
            this.a4track.Size = new System.Drawing.Size(305, 69);
            this.a4track.TabIndex = 42;
            // 
            // a3track
            // 
            this.a3track.Location = new System.Drawing.Point(176, 137);
            this.a3track.Maximum = 148;
            this.a3track.Minimum = -32;
            this.a3track.Name = "a3track";
            this.a3track.Size = new System.Drawing.Size(305, 69);
            this.a3track.TabIndex = 41;
            // 
            // a2track
            // 
            this.a2track.Location = new System.Drawing.Point(176, 78);
            this.a2track.Maximum = 101;
            this.a2track.Minimum = -49;
            this.a2track.Name = "a2track";
            this.a2track.Size = new System.Drawing.Size(305, 69);
            this.a2track.TabIndex = 40;
            // 
            // a1track
            // 
            this.a1track.Location = new System.Drawing.Point(176, 25);
            this.a1track.Maximum = 100;
            this.a1track.Minimum = -100;
            this.a1track.Name = "a1track";
            this.a1track.Size = new System.Drawing.Size(305, 69);
            this.a1track.TabIndex = 39;
            this.a1track.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // a2status
            // 
            this.a2status.BackColor = System.Drawing.Color.White;
            this.a2status.Location = new System.Drawing.Point(487, 91);
            this.a2status.Name = "a2status";
            this.a2status.Size = new System.Drawing.Size(54, 26);
            this.a2status.TabIndex = 22;
            // 
            // a3status
            // 
            this.a3status.BackColor = System.Drawing.Color.White;
            this.a3status.Location = new System.Drawing.Point(487, 149);
            this.a3status.Name = "a3status";
            this.a3status.Size = new System.Drawing.Size(54, 26);
            this.a3status.TabIndex = 21;
            // 
            // a4status
            // 
            this.a4status.BackColor = System.Drawing.Color.White;
            this.a4status.Location = new System.Drawing.Point(487, 204);
            this.a4status.Name = "a4status";
            this.a4status.Size = new System.Drawing.Size(54, 26);
            this.a4status.TabIndex = 20;
            // 
            // a5status
            // 
            this.a5status.BackColor = System.Drawing.Color.White;
            this.a5status.Location = new System.Drawing.Point(487, 256);
            this.a5status.Name = "a5status";
            this.a5status.Size = new System.Drawing.Size(54, 26);
            this.a5status.TabIndex = 19;
            // 
            // a6status
            // 
            this.a6status.BackColor = System.Drawing.Color.White;
            this.a6status.Location = new System.Drawing.Point(487, 308);
            this.a6status.Name = "a6status";
            this.a6status.Size = new System.Drawing.Size(54, 26);
            this.a6status.TabIndex = 18;
            // 
            // a1status
            // 
            this.a1status.BackColor = System.Drawing.Color.White;
            this.a1status.Location = new System.Drawing.Point(487, 35);
            this.a1status.Name = "a1status";
            this.a1status.Size = new System.Drawing.Size(54, 26);
            this.a1status.TabIndex = 17;
            // 
            // a1curr
            // 
            this.a1curr.Location = new System.Drawing.Point(70, 34);
            this.a1curr.Name = "a1curr";
            this.a1curr.Size = new System.Drawing.Size(100, 26);
            this.a1curr.TabIndex = 1;
            // 
            // a3curr
            // 
            this.a3curr.Location = new System.Drawing.Point(70, 148);
            this.a3curr.Name = "a3curr";
            this.a3curr.Size = new System.Drawing.Size(100, 26);
            this.a3curr.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Axis 6";
            // 
            // a2curr
            // 
            this.a2curr.Location = new System.Drawing.Point(70, 87);
            this.a2curr.Name = "a2curr";
            this.a2curr.Size = new System.Drawing.Size(100, 26);
            this.a2curr.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Axis 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Axis 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Axis 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Axis 2";
            // 
            // a5curr
            // 
            this.a5curr.Location = new System.Drawing.Point(70, 254);
            this.a5curr.Name = "a5curr";
            this.a5curr.Size = new System.Drawing.Size(100, 26);
            this.a5curr.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Axis 3";
            // 
            // a6curr
            // 
            this.a6curr.Location = new System.Drawing.Point(70, 307);
            this.a6curr.Name = "a6curr";
            this.a6curr.Size = new System.Drawing.Size(100, 26);
            this.a6curr.TabIndex = 12;
            // 
            // a4curr
            // 
            this.a4curr.Location = new System.Drawing.Point(70, 203);
            this.a4curr.Name = "a4curr";
            this.a4curr.Size = new System.Drawing.Size(100, 26);
            this.a4curr.TabIndex = 11;
            // 
            // poseSequenceBox
            // 
            this.poseSequenceBox.Controls.Add(this.stop);
            this.poseSequenceBox.Controls.Add(this.pause);
            this.poseSequenceBox.Controls.Add(this.loop);
            this.poseSequenceBox.Controls.Add(this.play);
            this.poseSequenceBox.Controls.Add(this.label18);
            this.poseSequenceBox.Controls.Add(this.label17);
            this.poseSequenceBox.Controls.Add(this.label15);
            this.poseSequenceBox.Controls.Add(this.holdTime);
            this.poseSequenceBox.Controls.Add(this.loadedSequence);
            this.poseSequenceBox.Controls.Add(this.saveSequence);
            this.poseSequenceBox.Controls.Add(this.savePose);
            this.poseSequenceBox.Controls.Add(this.playbackSequence);
            this.poseSequenceBox.Controls.Add(this.loadSequence);
            this.poseSequenceBox.Controls.Add(this.recordSequence);
            this.poseSequenceBox.Location = new System.Drawing.Point(925, 439);
            this.poseSequenceBox.Name = "poseSequenceBox";
            this.poseSequenceBox.Size = new System.Drawing.Size(608, 408);
            this.poseSequenceBox.TabIndex = 23;
            this.poseSequenceBox.TabStop = false;
            this.poseSequenceBox.Text = "Pose Sequence Mode";
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Location = new System.Drawing.Point(169, 214);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(68, 24);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.CheckedChanged += new System.EventHandler(this.stop_CheckedChanged);
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.Location = new System.Drawing.Point(84, 214);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(79, 24);
            this.pause.TabIndex = 4;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.CheckedChanged += new System.EventHandler(this.pause_CheckedChanged);
            // 
            // loop
            // 
            this.loop.AutoSize = true;
            this.loop.Location = new System.Drawing.Point(15, 250);
            this.loop.Name = "loop";
            this.loop.Size = new System.Drawing.Size(71, 24);
            this.loop.TabIndex = 37;
            this.loop.Text = "Loop";
            this.loop.UseVisualStyleBackColor = true;
            this.loop.CheckedChanged += new System.EventHandler(this.loop_CheckedChanged);
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Location = new System.Drawing.Point(15, 214);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(63, 24);
            this.play.TabIndex = 3;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.CheckedChanged += new System.EventHandler(this.play_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(532, 333);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "10 s";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "0 s";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Pose Hold Time";
            // 
            // holdTime
            // 
            this.holdTime.Location = new System.Drawing.Point(53, 331);
            this.holdTime.Maximum = 20;
            this.holdTime.Name = "holdTime";
            this.holdTime.Size = new System.Drawing.Size(477, 69);
            this.holdTime.TabIndex = 34;
            this.holdTime.Value = 1;
            this.holdTime.Scroll += new System.EventHandler(this.holdTime_Scroll);
            // 
            // loadedSequence
            // 
            this.loadedSequence.Location = new System.Drawing.Point(153, 173);
            this.loadedSequence.Name = "loadedSequence";
            this.loadedSequence.Size = new System.Drawing.Size(377, 26);
            this.loadedSequence.TabIndex = 23;
            // 
            // saveSequence
            // 
            this.saveSequence.Location = new System.Drawing.Point(160, 68);
            this.saveSequence.Name = "saveSequence";
            this.saveSequence.Size = new System.Drawing.Size(136, 34);
            this.saveSequence.TabIndex = 27;
            this.saveSequence.Text = "Save Sequence";
            this.saveSequence.UseVisualStyleBackColor = true;
            this.saveSequence.Click += new System.EventHandler(this.saveSequence_Click);
            // 
            // savePose
            // 
            this.savePose.Location = new System.Drawing.Point(18, 68);
            this.savePose.Name = "savePose";
            this.savePose.Size = new System.Drawing.Size(136, 34);
            this.savePose.TabIndex = 26;
            this.savePose.Text = "Save Pose";
            this.savePose.UseVisualStyleBackColor = true;
            this.savePose.Click += new System.EventHandler(this.savePose_Click);
            // 
            // playbackSequence
            // 
            this.playbackSequence.AutoSize = true;
            this.playbackSequence.Location = new System.Drawing.Point(14, 130);
            this.playbackSequence.Name = "playbackSequence";
            this.playbackSequence.Size = new System.Drawing.Size(174, 24);
            this.playbackSequence.TabIndex = 25;
            this.playbackSequence.Text = "Playback Sequence";
            this.playbackSequence.UseVisualStyleBackColor = true;
            this.playbackSequence.CheckedChanged += new System.EventHandler(this.playbackSequence_CheckedChanged);
            // 
            // loadSequence
            // 
            this.loadSequence.Location = new System.Drawing.Point(11, 168);
            this.loadSequence.Name = "loadSequence";
            this.loadSequence.Size = new System.Drawing.Size(136, 34);
            this.loadSequence.TabIndex = 19;
            this.loadSequence.Text = "Load File";
            this.loadSequence.UseVisualStyleBackColor = true;
            this.loadSequence.Click += new System.EventHandler(this.loadSequence_Click);
            // 
            // recordSequence
            // 
            this.recordSequence.AutoSize = true;
            this.recordSequence.Checked = true;
            this.recordSequence.Location = new System.Drawing.Point(15, 31);
            this.recordSequence.Name = "recordSequence";
            this.recordSequence.Size = new System.Drawing.Size(163, 24);
            this.recordSequence.TabIndex = 24;
            this.recordSequence.TabStop = true;
            this.recordSequence.Text = "Record Sequence";
            this.recordSequence.UseVisualStyleBackColor = true;
            this.recordSequence.CheckedChanged += new System.EventHandler(this.recordSequence_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1546, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modesBox
            // 
            this.modesBox.Controls.Add(this.disableController);
            this.modesBox.Controls.Add(this.poseMode);
            this.modesBox.Controls.Add(this.joystickMode);
            this.modesBox.Location = new System.Drawing.Point(401, 139);
            this.modesBox.Name = "modesBox";
            this.modesBox.Size = new System.Drawing.Size(216, 147);
            this.modesBox.TabIndex = 21;
            this.modesBox.TabStop = false;
            this.modesBox.Text = "Mode Select";
            // 
            // disableController
            // 
            this.disableController.AutoSize = true;
            this.disableController.Checked = true;
            this.disableController.Location = new System.Drawing.Point(6, 108);
            this.disableController.Name = "disableController";
            this.disableController.Size = new System.Drawing.Size(159, 24);
            this.disableController.TabIndex = 2;
            this.disableController.TabStop = true;
            this.disableController.Text = "Disable Controller";
            this.disableController.UseVisualStyleBackColor = true;
            this.disableController.CheckedChanged += new System.EventHandler(this.disableController_CheckedChanged);
            // 
            // poseMode
            // 
            this.poseMode.AutoSize = true;
            this.poseMode.Location = new System.Drawing.Point(6, 69);
            this.poseMode.Name = "poseMode";
            this.poseMode.Size = new System.Drawing.Size(191, 24);
            this.poseMode.TabIndex = 1;
            this.poseMode.Text = "Pose Sequence Mode";
            this.poseMode.UseVisualStyleBackColor = true;
            this.poseMode.CheckedChanged += new System.EventHandler(this.poseMode_CheckedChanged);
            // 
            // joystickMode
            // 
            this.joystickMode.AutoSize = true;
            this.joystickMode.Location = new System.Drawing.Point(6, 30);
            this.joystickMode.Name = "joystickMode";
            this.joystickMode.Size = new System.Drawing.Size(134, 24);
            this.joystickMode.TabIndex = 0;
            this.joystickMode.Text = "Joystick Mode";
            this.joystickMode.UseVisualStyleBackColor = true;
            this.joystickMode.CheckedChanged += new System.EventHandler(this.joystickMode_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Velocity";
            // 
            // vel
            // 
            this.vel.Location = new System.Drawing.Point(16, 51);
            this.vel.Minimum = -10;
            this.vel.Name = "vel";
            this.vel.Size = new System.Drawing.Size(365, 69);
            this.vel.TabIndex = 36;
            this.vel.Scroll += new System.EventHandler(this.vel_Scroll_1);
            this.vel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vel_MouseDown);
            this.vel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vel_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Acceleration";
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(16, 156);
            this.acc.Minimum = -10;
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(353, 69);
            this.acc.TabIndex = 38;
            this.acc.Scroll += new System.EventHandler(this.acc_Scroll_1);
            this.acc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.acc_MouseDown);
            this.acc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.acc_MouseUp);
            // 
            // armMotionBox
            // 
            this.armMotionBox.Controls.Add(this.groupBox4);
            this.armMotionBox.Controls.Add(this.measuredPosBox);
            this.armMotionBox.Controls.Add(this.armPosBox);
            this.armMotionBox.Location = new System.Drawing.Point(12, 298);
            this.armMotionBox.Name = "armMotionBox";
            this.armMotionBox.Size = new System.Drawing.Size(899, 682);
            this.armMotionBox.TabIndex = 39;
            this.armMotionBox.TabStop = false;
            this.armMotionBox.Text = "Arm Motion ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.filter);
            this.groupBox4.Controls.Add(this.filterVal);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.vel);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.acc);
            this.groupBox4.Location = new System.Drawing.Point(21, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(861, 249);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motion Parameters";
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Location = new System.Drawing.Point(427, 32);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(44, 20);
            this.filter.TabIndex = 39;
            this.filter.Text = "Filter";
            // 
            // filterVal
            // 
            this.filterVal.Location = new System.Drawing.Point(420, 51);
            this.filterVal.Maximum = 20;
            this.filterVal.Minimum = 6;
            this.filterVal.Name = "filterVal";
            this.filterVal.Size = new System.Drawing.Size(365, 69);
            this.filterVal.TabIndex = 40;
            this.filterVal.Value = 10;
            this.filterVal.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // controllerPort
            // 
            this.controllerPort.PortName = "COM4";
            this.controllerPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.controllerPort_DataReceived);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(536, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 20);
            this.label21.TabIndex = 48;
            this.label21.Text = "Opened";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 20);
            this.label22.TabIndex = 49;
            this.label22.Text = "Grip Force";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = "Gripper Position";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 47;
            this.label20.Text = "Closed";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(536, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 20);
            this.label24.TabIndex = 51;
            this.label24.Text = "Max";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // gripperPos
            // 
            this.gripperPos.Location = new System.Drawing.Point(90, 63);
            this.gripperPos.Maximum = 100;
            this.gripperPos.Name = "gripperPos";
            this.gripperPos.Size = new System.Drawing.Size(440, 69);
            this.gripperPos.TabIndex = 45;
            this.gripperPos.Scroll += new System.EventHandler(this.gripperPos_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(46, 165);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 20);
            this.label23.TabIndex = 52;
            this.label23.Text = "Min";
            // 
            // ForceBar
            // 
            this.ForceBar.Location = new System.Drawing.Point(86, 165);
            this.ForceBar.Name = "ForceBar";
            this.ForceBar.Size = new System.Drawing.Size(444, 23);
            this.ForceBar.TabIndex = 42;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ForceBar);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.gripperPos);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(925, 139);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(608, 285);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "End Effector Controller";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 996);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.armMotionBox);
            this.Controls.Add(this.modesBox);
            this.Controls.Add(this.poseSequenceBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.homeArmBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "*";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.armPosBox.ResumeLayout(false);
            this.armPosBox.PerformLayout();
            this.homeArmBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.measuredPosBox.ResumeLayout(false);
            this.measuredPosBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a6track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a5track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1track)).EndInit();
            this.poseSequenceBox.ResumeLayout(false);
            this.poseSequenceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holdTime)).EndInit();
            this.modesBox.ResumeLayout(false);
            this.modesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc)).EndInit();
            this.armMotionBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gripperPos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox a5;
        private System.Windows.Forms.TextBox a6;
        private System.Windows.Forms.TextBox a4;
        private System.Windows.Forms.GroupBox armPosBox;
        private System.IO.Ports.SerialPort armPort;
        private System.Windows.Forms.GroupBox homeArmBox;
        private System.Windows.Forms.Button homeArmBtn;
        private System.Windows.Forms.Button homeGripperBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox armPorts;
        private System.Windows.Forms.Button connectArmBtn;
        private System.Windows.Forms.Button connectContBtn;
        private System.Windows.Forms.Timer cmdTimer;
        private System.Windows.Forms.GroupBox measuredPosBox;
        private System.Windows.Forms.TextBox a1curr;
        private System.Windows.Forms.TextBox a3curr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox a2curr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox a5curr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox a4curr;
        private System.Windows.Forms.TextBox a1status;
        private System.Windows.Forms.TextBox a2status;
        private System.Windows.Forms.TextBox a3status;
        private System.Windows.Forms.TextBox a4status;
        private System.Windows.Forms.TextBox a5status;
        private System.Windows.Forms.TextBox a6status;
        private System.Windows.Forms.GroupBox poseSequenceBox;
        private System.Windows.Forms.Button saveSequence;
        private System.Windows.Forms.Button savePose;
        private System.Windows.Forms.RadioButton playbackSequence;
        private System.Windows.Forms.Button loadSequence;
        private System.Windows.Forms.RadioButton recordSequence;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox modesBox;
        private System.Windows.Forms.RadioButton poseMode;
        private System.Windows.Forms.RadioButton joystickMode;
        private System.Windows.Forms.TextBox a6curr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar holdTime;
        private System.Windows.Forms.TextBox loadedSequence;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar vel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar acc;
        private System.Windows.Forms.GroupBox armMotionBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton disableController;
        private System.IO.Ports.SerialPort controllerPort;
        private System.Windows.Forms.TrackBar a1track;
        private System.Windows.Forms.TrackBar a6track;
        private System.Windows.Forms.TrackBar a5track;
        private System.Windows.Forms.TrackBar a4track;
        private System.Windows.Forms.TrackBar a3track;
        private System.Windows.Forms.TrackBar a2track;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.TrackBar filterVal;
        private System.Windows.Forms.CheckBox loop;
        private System.Windows.Forms.RadioButton stop;
        private System.Windows.Forms.RadioButton pause;
        private System.Windows.Forms.RadioButton play;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar gripperPos;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ProgressBar ForceBar;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

