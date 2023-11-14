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
            this.moveArmBtn = new System.Windows.Forms.Button();
            this.armPosBox = new System.Windows.Forms.GroupBox();
            this.armPort = new System.IO.Ports.SerialPort(this.components);
            this.homeArmBox = new System.Windows.Forms.GroupBox();
            this.homeGripperBtn = new System.Windows.Forms.Button();
            this.homeArmBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.controllerPorts = new System.Windows.Forms.ComboBox();
            this.connectContBtn = new System.Windows.Forms.Button();
            this.armPorts = new System.Windows.Forms.ComboBox();
            this.connectArmBtn = new System.Windows.Forms.Button();
            this.cmdTimer = new System.Windows.Forms.Timer(this.components);
            this.measuredPosBox = new System.Windows.Forms.GroupBox();
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
            this.a1status = new System.Windows.Forms.TextBox();
            this.a6status = new System.Windows.Forms.TextBox();
            this.a5status = new System.Windows.Forms.TextBox();
            this.a4status = new System.Windows.Forms.TextBox();
            this.a3status = new System.Windows.Forms.TextBox();
            this.a2status = new System.Windows.Forms.TextBox();
            this.armPosBox.SuspendLayout();
            this.homeArmBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.measuredPosBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot Arm Controller";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(71, 34);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(100, 26);
            this.a1.TabIndex = 1;
            this.a1.Text = "0";
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(71, 120);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(100, 26);
            this.a3.TabIndex = 6;
            this.a3.Text = "0";
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(71, 75);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(100, 26);
            this.a2.TabIndex = 7;
            this.a2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Axis 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Axis 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Axis 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Axis 6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Axis 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Axis 4";
            // 
            // a5
            // 
            this.a5.Location = new System.Drawing.Point(71, 207);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(100, 26);
            this.a5.TabIndex = 13;
            this.a5.Text = "0";
            // 
            // a6
            // 
            this.a6.Location = new System.Drawing.Point(71, 252);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(100, 26);
            this.a6.TabIndex = 12;
            this.a6.Text = "0";
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(71, 166);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(100, 26);
            this.a4.TabIndex = 11;
            this.a4.Text = "0";
            // 
            // moveArmBtn
            // 
            this.moveArmBtn.Location = new System.Drawing.Point(18, 300);
            this.moveArmBtn.Name = "moveArmBtn";
            this.moveArmBtn.Size = new System.Drawing.Size(208, 38);
            this.moveArmBtn.TabIndex = 17;
            this.moveArmBtn.Text = "Execute Position";
            this.moveArmBtn.UseVisualStyleBackColor = true;
            this.moveArmBtn.Click += new System.EventHandler(this.moveArmBtn_Click);
            // 
            // armPosBox
            // 
            this.armPosBox.Controls.Add(this.a1);
            this.armPosBox.Controls.Add(this.moveArmBtn);
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
            this.armPosBox.Location = new System.Drawing.Point(12, 229);
            this.armPosBox.Name = "armPosBox";
            this.armPosBox.Size = new System.Drawing.Size(268, 373);
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
            this.homeArmBox.Location = new System.Drawing.Point(411, 65);
            this.homeArmBox.Name = "homeArmBox";
            this.homeArmBox.Size = new System.Drawing.Size(268, 148);
            this.homeArmBox.TabIndex = 20;
            this.homeArmBox.TabStop = false;
            this.homeArmBox.Text = "Calibrate Arm";
            // 
            // homeGripperBtn
            // 
            this.homeGripperBtn.Location = new System.Drawing.Point(25, 89);
            this.homeGripperBtn.Name = "homeGripperBtn";
            this.homeGripperBtn.Size = new System.Drawing.Size(208, 38);
            this.homeGripperBtn.TabIndex = 18;
            this.homeGripperBtn.Text = "Zero Gripper";
            this.homeGripperBtn.UseVisualStyleBackColor = true;
            // 
            // homeArmBtn
            // 
            this.homeArmBtn.Location = new System.Drawing.Point(25, 36);
            this.homeArmBtn.Name = "homeArmBtn";
            this.homeArmBtn.Size = new System.Drawing.Size(208, 38);
            this.homeArmBtn.TabIndex = 17;
            this.homeArmBtn.Text = "Home Arm";
            this.homeArmBtn.UseVisualStyleBackColor = true;
            this.homeArmBtn.Click += new System.EventHandler(this.homeArmBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.controllerPorts);
            this.groupBox1.Controls.Add(this.connectContBtn);
            this.groupBox1.Controls.Add(this.armPorts);
            this.groupBox1.Controls.Add(this.connectArmBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 148);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Arm";
            // 
            // controllerPorts
            // 
            this.controllerPorts.FormattingEnabled = true;
            this.controllerPorts.Location = new System.Drawing.Point(18, 92);
            this.controllerPorts.Name = "controllerPorts";
            this.controllerPorts.Size = new System.Drawing.Size(164, 28);
            this.controllerPorts.TabIndex = 21;
            // 
            // connectContBtn
            // 
            this.connectContBtn.Location = new System.Drawing.Point(201, 91);
            this.connectContBtn.Name = "connectContBtn";
            this.connectContBtn.Size = new System.Drawing.Size(160, 32);
            this.connectContBtn.TabIndex = 20;
            this.connectContBtn.Text = "Connect Controller";
            this.connectContBtn.UseVisualStyleBackColor = true;
            // 
            // armPorts
            // 
            this.armPorts.FormattingEnabled = true;
            this.armPorts.Location = new System.Drawing.Point(18, 41);
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
            this.measuredPosBox.Location = new System.Drawing.Point(299, 234);
            this.measuredPosBox.Name = "measuredPosBox";
            this.measuredPosBox.Size = new System.Drawing.Size(287, 373);
            this.measuredPosBox.TabIndex = 20;
            this.measuredPosBox.TabStop = false;
            this.measuredPosBox.Text = "Measured Position";
            // 
            // a1curr
            // 
            this.a1curr.Location = new System.Drawing.Point(71, 34);
            this.a1curr.Name = "a1curr";
            this.a1curr.Size = new System.Drawing.Size(100, 26);
            this.a1curr.TabIndex = 1;
            // 
            // a3curr
            // 
            this.a3curr.Location = new System.Drawing.Point(71, 120);
            this.a3curr.Name = "a3curr";
            this.a3curr.Size = new System.Drawing.Size(100, 26);
            this.a3curr.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Axis 6";
            // 
            // a2curr
            // 
            this.a2curr.Location = new System.Drawing.Point(71, 75);
            this.a2curr.Name = "a2curr";
            this.a2curr.Size = new System.Drawing.Size(100, 26);
            this.a2curr.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Axis 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Axis 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Axis 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Axis 2";
            // 
            // a5curr
            // 
            this.a5curr.Location = new System.Drawing.Point(71, 207);
            this.a5curr.Name = "a5curr";
            this.a5curr.Size = new System.Drawing.Size(100, 26);
            this.a5curr.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Axis 3";
            // 
            // a6curr
            // 
            this.a6curr.Location = new System.Drawing.Point(71, 252);
            this.a6curr.Name = "a6curr";
            this.a6curr.Size = new System.Drawing.Size(100, 26);
            this.a6curr.TabIndex = 12;
            // 
            // a4curr
            // 
            this.a4curr.Location = new System.Drawing.Point(71, 166);
            this.a4curr.Name = "a4curr";
            this.a4curr.Size = new System.Drawing.Size(100, 26);
            this.a4curr.TabIndex = 11;
            // 
            // a1status
            // 
            this.a1status.BackColor = System.Drawing.Color.White;
            this.a1status.Location = new System.Drawing.Point(190, 34);
            this.a1status.Name = "a1status";
            this.a1status.Size = new System.Drawing.Size(53, 26);
            this.a1status.TabIndex = 17;
            // 
            // a6status
            // 
            this.a6status.BackColor = System.Drawing.Color.White;
            this.a6status.Location = new System.Drawing.Point(190, 252);
            this.a6status.Name = "a6status";
            this.a6status.Size = new System.Drawing.Size(53, 26);
            this.a6status.TabIndex = 18;
            // 
            // a5status
            // 
            this.a5status.BackColor = System.Drawing.Color.White;
            this.a5status.Location = new System.Drawing.Point(190, 210);
            this.a5status.Name = "a5status";
            this.a5status.Size = new System.Drawing.Size(53, 26);
            this.a5status.TabIndex = 19;
            // 
            // a4status
            // 
            this.a4status.BackColor = System.Drawing.Color.White;
            this.a4status.Location = new System.Drawing.Point(190, 166);
            this.a4status.Name = "a4status";
            this.a4status.Size = new System.Drawing.Size(53, 26);
            this.a4status.TabIndex = 20;
            // 
            // a3status
            // 
            this.a3status.BackColor = System.Drawing.Color.White;
            this.a3status.Location = new System.Drawing.Point(190, 120);
            this.a3status.Name = "a3status";
            this.a3status.Size = new System.Drawing.Size(53, 26);
            this.a3status.TabIndex = 21;
            // 
            // a2status
            // 
            this.a2status.BackColor = System.Drawing.Color.White;
            this.a2status.Location = new System.Drawing.Point(190, 78);
            this.a2status.Name = "a2status";
            this.a2status.Size = new System.Drawing.Size(53, 26);
            this.a2status.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 932);
            this.Controls.Add(this.measuredPosBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.homeArmBox);
            this.Controls.Add(this.armPosBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.armPosBox.ResumeLayout(false);
            this.armPosBox.PerformLayout();
            this.homeArmBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.measuredPosBox.ResumeLayout(false);
            this.measuredPosBox.PerformLayout();
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
        private System.Windows.Forms.Button moveArmBtn;
        private System.Windows.Forms.GroupBox armPosBox;
        private System.IO.Ports.SerialPort armPort;
        private System.Windows.Forms.GroupBox homeArmBox;
        private System.Windows.Forms.Button homeArmBtn;
        private System.Windows.Forms.Button homeGripperBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox armPorts;
        private System.Windows.Forms.Button connectArmBtn;
        private System.Windows.Forms.ComboBox controllerPorts;
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
        private System.Windows.Forms.TextBox a6curr;
        private System.Windows.Forms.TextBox a4curr;
        private System.Windows.Forms.TextBox a1status;
        private System.Windows.Forms.TextBox a2status;
        private System.Windows.Forms.TextBox a3status;
        private System.Windows.Forms.TextBox a4status;
        private System.Windows.Forms.TextBox a5status;
        private System.Windows.Forms.TextBox a6status;
    }
}

