
namespace GPIBReaderWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPower = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.HomeAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.elementHostHelix = new System.Windows.Forms.Integration.ElementHost();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DatasetSelect = new System.Windows.Forms.ComboBox();
            this.LoadData = new System.Windows.Forms.Button();
            this.JogToHigh = new System.Windows.Forms.Button();
            this.StopScan = new System.Windows.Forms.Button();
            this.RunScan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XDataPoints = new System.Windows.Forms.TextBox();
            this.XSize = new System.Windows.Forms.TextBox();
            this.YDataPoints = new System.Windows.Forms.TextBox();
            this.YSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ScanningPanel = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblPower.Location = new System.Drawing.Point(31, 57);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(97, 30);
            this.lblPower.TabIndex = 0;
            this.lblPower.Text = " --- dBm";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Laser";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(31, 143);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 30);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Laser";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Power: ";
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(31, 201);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(125, 30);
            this.btnViewLog.TabIndex = 4;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(181, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 406);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HomeAll);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Motor Functions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // HomeAll
            // 
            this.HomeAll.Location = new System.Drawing.Point(257, 230);
            this.HomeAll.Name = "HomeAll";
            this.HomeAll.Size = new System.Drawing.Size(106, 42);
            this.HomeAll.TabIndex = 18;
            this.HomeAll.Text = "Home All";
            this.HomeAll.UseVisualStyleBackColor = true;
            this.HomeAll.Click += new System.EventHandler(this.HomeAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Step Res.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "PIC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ThorLabs Stages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zaber Stages";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(290, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 41);
            this.panel1.TabIndex = 12;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(553, 188);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 79);
            this.button11.TabIndex = 11;
            this.button11.Text = "\r\nY\r\n⌄\r\n⌄";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(553, 42);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 83);
            this.button12.TabIndex = 10;
            this.button12.Text = "^\r\n^\r\nY";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(342, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 42);
            this.button7.TabIndex = 9;
            this.button7.Text = "< < Z";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(498, 137);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "Z  > >";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(451, 178);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 79);
            this.button9.TabIndex = 7;
            this.button9.Text = "\r\nX\r\n⌄\r\n⌄";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(451, 52);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 83);
            this.button10.TabIndex = 6;
            this.button10.Text = "^\r\n^\r\nX";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 79);
            this.button5.TabIndex = 5;
            this.button5.Text = "\r\nY\r\n⌄\r\n⌄";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 83);
            this.button6.TabIndex = 4;
            this.button6.Text = "^\r\n^\r\nY";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "< < Z";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Z  > >";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "\r\nX\r\n⌄\r\n⌄";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "^\r\n^\r\nX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.elementHostHelix);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.DatasetSelect);
            this.tabPage2.Controls.Add(this.LoadData);
            this.tabPage2.Controls.Add(this.JogToHigh);
            this.tabPage2.Controls.Add(this.StopScan);
            this.tabPage2.Controls.Add(this.RunScan);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.XDataPoints);
            this.tabPage2.Controls.Add(this.XSize);
            this.tabPage2.Controls.Add(this.YDataPoints);
            this.tabPage2.Controls.Add(this.YSize);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ScanningPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto-Alignment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // elementHostHelix
            // 
            this.elementHostHelix.Location = new System.Drawing.Point(296, 24);
            this.elementHostHelix.Name = "elementHostHelix";
            this.elementHostHelix.Size = new System.Drawing.Size(303, 236);
            this.elementHostHelix.TabIndex = 19;
            this.elementHostHelix.Text = "elementHostHelix";
            this.elementHostHelix.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHostHelix.Child = null;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "X - Axis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Y - Axis";
            // 
            // DatasetSelect
            // 
            this.DatasetSelect.FormattingEnabled = true;
            this.DatasetSelect.Location = new System.Drawing.Point(296, 278);
            this.DatasetSelect.Name = "DatasetSelect";
            this.DatasetSelect.Size = new System.Drawing.Size(121, 21);
            this.DatasetSelect.TabIndex = 16;
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(296, 305);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(121, 23);
            this.LoadData.TabIndex = 15;
            this.LoadData.Text = "Load Data";
            this.LoadData.UseVisualStyleBackColor = true;
            // 
            // JogToHigh
            // 
            this.JogToHigh.Location = new System.Drawing.Point(296, 334);
            this.JogToHigh.Name = "JogToHigh";
            this.JogToHigh.Size = new System.Drawing.Size(121, 23);
            this.JogToHigh.TabIndex = 14;
            this.JogToHigh.Text = "Jog to High Point";
            this.JogToHigh.UseVisualStyleBackColor = true;
            // 
            // StopScan
            // 
            this.StopScan.Location = new System.Drawing.Point(489, 303);
            this.StopScan.Name = "StopScan";
            this.StopScan.Size = new System.Drawing.Size(110, 23);
            this.StopScan.TabIndex = 12;
            this.StopScan.Text = "Stop Scan";
            this.StopScan.UseVisualStyleBackColor = true;
            // 
            // RunScan
            // 
            this.RunScan.Location = new System.Drawing.Point(489, 276);
            this.RunScan.Name = "RunScan";
            this.RunScan.Size = new System.Drawing.Size(110, 23);
            this.RunScan.TabIndex = 11;
            this.RunScan.Text = "Run Scan";
            this.RunScan.UseVisualStyleBackColor = true;
            this.RunScan.Click += new System.EventHandler(this.RunScan_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Data Points";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Data Points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "mm Area";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "mm Area";
            // 
            // XDataPoints
            // 
            this.XDataPoints.Location = new System.Drawing.Point(127, 126);
            this.XDataPoints.Name = "XDataPoints";
            this.XDataPoints.Size = new System.Drawing.Size(45, 20);
            this.XDataPoints.TabIndex = 6;
            // 
            // XSize
            // 
            this.XSize.Location = new System.Drawing.Point(127, 100);
            this.XSize.Name = "XSize";
            this.XSize.Size = new System.Drawing.Size(45, 20);
            this.XSize.TabIndex = 5;
            // 
            // YDataPoints
            // 
            this.YDataPoints.Location = new System.Drawing.Point(127, 57);
            this.YDataPoints.Name = "YDataPoints";
            this.YDataPoints.Size = new System.Drawing.Size(45, 20);
            this.YDataPoints.TabIndex = 4;
            // 
            // YSize
            // 
            this.YSize.Location = new System.Drawing.Point(127, 31);
            this.YSize.Name = "YSize";
            this.YSize.Size = new System.Drawing.Size(45, 20);
            this.YSize.TabIndex = 3;
            this.YSize.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Zaber Auto Scanning";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ScanningPanel
            // 
            this.ScanningPanel.Location = new System.Drawing.Point(12, 42);
            this.ScanningPanel.Name = "ScanningPanel";
            this.ScanningPanel.Size = new System.Drawing.Size(104, 92);
            this.ScanningPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(811, 408);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Name = "MainForm";
            this.Text = "Optical Power Reader";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button HomeAll;
        private System.Windows.Forms.Panel ScanningPanel;
        private System.Windows.Forms.TextBox YSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XDataPoints;
        private System.Windows.Forms.TextBox XSize;
        private System.Windows.Forms.TextBox YDataPoints;
        private System.Windows.Forms.Button StopScan;
        private System.Windows.Forms.Button RunScan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DatasetSelect;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button JogToHigh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Integration.ElementHost elementHostHelix;
    }
}
