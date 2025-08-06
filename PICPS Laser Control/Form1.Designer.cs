namespace GPIBReaderWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPower;
        private ModernButton btnStart;
        private ModernButton btnStop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.powerPanel = new GPIBReaderWinForms.ModernPanel();
            this.statusIndicator = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.btnStart = new GPIBReaderWinForms.ModernButton();
            this.btnStop = new GPIBReaderWinForms.ModernButton();
            this.btnViewLog = new GPIBReaderWinForms.ModernButton();
            this.modernPanel1 = new GPIBReaderWinForms.ModernPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeAll = new GPIBReaderWinForms.ModernButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new GPIBReaderWinForms.ModernTextBox();
            this.modernPanel2 = new GPIBReaderWinForms.ModernPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new GPIBReaderWinForms.ModernButton();
            this.button6 = new GPIBReaderWinForms.ModernButton();
            this.button4 = new GPIBReaderWinForms.ModernButton();
            this.button3 = new GPIBReaderWinForms.ModernButton();
            this.button2 = new GPIBReaderWinForms.ModernButton();
            this.button1 = new GPIBReaderWinForms.ModernButton();
            this.modernPanel3 = new GPIBReaderWinForms.ModernPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.button11 = new GPIBReaderWinForms.ModernButton();
            this.button12 = new GPIBReaderWinForms.ModernButton();
            this.button7 = new GPIBReaderWinForms.ModernButton();
            this.button8 = new GPIBReaderWinForms.ModernButton();
            this.button9 = new GPIBReaderWinForms.ModernButton();
            this.button10 = new GPIBReaderWinForms.ModernButton();
            this.modernPanel4 = new GPIBReaderWinForms.ModernPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ZDataPoints = new GPIBReaderWinForms.ModernTextBox();
            this.ZSize = new GPIBReaderWinForms.ModernTextBox();
            this.elementHostHelix = new System.Windows.Forms.Integration.ElementHost();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFitToScreen = new GPIBReaderWinForms.ModernButton();
            this.StopScan = new GPIBReaderWinForms.ModernButton();
            this.RunScan = new GPIBReaderWinForms.ModernButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XDataPoints = new GPIBReaderWinForms.ModernTextBox();
            this.XSize = new GPIBReaderWinForms.ModernTextBox();
            this.YDataPoints = new GPIBReaderWinForms.ModernTextBox();
            this.YSize = new GPIBReaderWinForms.ModernTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.powerPanel.SuspendLayout();
            this.modernPanel1.SuspendLayout();
            this.modernPanel2.SuspendLayout();
            this.modernPanel3.SuspendLayout();
            this.modernPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(220, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 600);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabPage1.Controls.Add(this.modernPanel1);
            this.tabPage1.Controls.Add(this.modernPanel2);
            this.tabPage1.Controls.Add(this.modernPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage1.Size = new System.Drawing.Size(892, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "🎛 Motor Control";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabPage2.Controls.Add(this.modernPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage2.Size = new System.Drawing.Size(892, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "🎯 Auto-Alignment";
            // 
            // powerPanel
            // 
            this.powerPanel.BackColor = System.Drawing.Color.Transparent;
            this.powerPanel.BackgroundColor = System.Drawing.Color.White;
            this.powerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.powerPanel.BorderRadius = 12;
            this.powerPanel.Controls.Add(this.statusIndicator);
            this.powerPanel.Controls.Add(this.label1);
            this.powerPanel.Controls.Add(this.lblPower);
            this.powerPanel.Controls.Add(this.btnStart);
            this.powerPanel.Controls.Add(this.btnStop);
            this.powerPanel.Controls.Add(this.btnViewLog);
            this.powerPanel.HasShadow = true;
            this.powerPanel.Location = new System.Drawing.Point(20, 20);
            this.powerPanel.Name = "powerPanel";
            this.powerPanel.SeamlessMode = false;
            this.powerPanel.Size = new System.Drawing.Size(200, 382);
            this.powerPanel.TabIndex = 6;
            // 
            // statusIndicator
            // 
            this.statusIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.statusIndicator.Location = new System.Drawing.Point(140, 25);
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(12, 12);
            this.statusIndicator.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Optical Power";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPower.Location = new System.Drawing.Point(20, 50);
            this.lblPower.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(138, 45);
            this.lblPower.TabIndex = 0;
            this.lblPower.Text = "--- dBm";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnStart.BorderRadius = 8;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnStart.Location = new System.Drawing.Point(32, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "🚀 Start Laser";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStop.BorderRadius = 8;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.Gray;
            this.btnStop.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStop.Location = new System.Drawing.Point(32, 232);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 45);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "⏹ Stop Laser";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.BackColor = System.Drawing.Color.Transparent;
            this.btnViewLog.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnViewLog.BorderRadius = 8;
            this.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewLog.ForeColor = System.Drawing.Color.White;
            this.btnViewLog.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.btnViewLog.Location = new System.Drawing.Point(32, 306);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(140, 47);
            this.btnViewLog.TabIndex = 4;
            this.btnViewLog.Text = "📊 View Log";
            this.btnViewLog.UseVisualStyleBackColor = false;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // modernPanel1
            // 
            this.modernPanel1.BackColor = System.Drawing.Color.Transparent;
            this.modernPanel1.BackgroundColor = System.Drawing.Color.White;
            this.modernPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.modernPanel1.BorderRadius = 12;
            this.modernPanel1.Controls.Add(this.label3);
            this.modernPanel1.Controls.Add(this.HomeAll);
            this.modernPanel1.Controls.Add(this.label6);
            this.modernPanel1.Controls.Add(this.label5);
            this.modernPanel1.Controls.Add(this.textBox1);
            this.modernPanel1.HasShadow = true;
            this.modernPanel1.Location = new System.Drawing.Point(315, 60);
            this.modernPanel1.Name = "modernPanel1";
            this.modernPanel1.SeamlessMode = false;
            this.modernPanel1.Size = new System.Drawing.Size(241, 416);
            this.modernPanel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(75, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Settings";
            // 
            // HomeAll
            // 
            this.HomeAll.BackColor = System.Drawing.Color.Transparent;
            this.HomeAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.HomeAll.BorderRadius = 8;
            this.HomeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.HomeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeAll.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.HomeAll.Location = new System.Drawing.Point(49, 306);
            this.HomeAll.Name = "HomeAll";
            this.HomeAll.Size = new System.Drawing.Size(150, 50);
            this.HomeAll.TabIndex = 18;
            this.HomeAll.Text = "🏠 Home All";
            this.HomeAll.UseVisualStyleBackColor = false;
            this.HomeAll.Click += new System.EventHandler(this.HomeAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(170, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(30, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Step Resolution";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.BorderRadius = 6;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(30, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 18);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "1.0";
            // 
            // modernPanel2
            // 
            this.modernPanel2.BackColor = System.Drawing.Color.Transparent;
            this.modernPanel2.BackgroundColor = System.Drawing.Color.White;
            this.modernPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.modernPanel2.BorderRadius = 12;
            this.modernPanel2.Controls.Add(this.label2);
            this.modernPanel2.Controls.Add(this.button5);
            this.modernPanel2.Controls.Add(this.button6);
            this.modernPanel2.Controls.Add(this.button4);
            this.modernPanel2.Controls.Add(this.button3);
            this.modernPanel2.Controls.Add(this.button2);
            this.modernPanel2.Controls.Add(this.button1);
            this.modernPanel2.HasShadow = true;
            this.modernPanel2.Location = new System.Drawing.Point(23, 60);
            this.modernPanel2.Name = "modernPanel2";
            this.modernPanel2.SeamlessMode = false;
            this.modernPanel2.Size = new System.Drawing.Size(250, 416);
            this.modernPanel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(59, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zaber Stages";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.BorderRadius = 8;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(38, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "Y\r\n⬇";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button6.BorderRadius = 8;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(38, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 80);
            this.button6.TabIndex = 4;
            this.button6.Text = "⬆\r\nY";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.BorderRadius = 8;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(37, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "⬅ Z";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button3.BorderRadius = 8;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(131, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Z →";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.BorderRadius = 8;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(148, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "X\r\n⬇";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.BorderRadius = 8;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(148, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "⬆\r\nX";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modernPanel3
            // 
            this.modernPanel3.BackColor = System.Drawing.Color.Transparent;
            this.modernPanel3.BackgroundColor = System.Drawing.Color.White;
            this.modernPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.modernPanel3.BorderRadius = 12;
            this.modernPanel3.Controls.Add(this.label17);
            this.modernPanel3.Controls.Add(this.button11);
            this.modernPanel3.Controls.Add(this.button12);
            this.modernPanel3.Controls.Add(this.button7);
            this.modernPanel3.Controls.Add(this.button8);
            this.modernPanel3.Controls.Add(this.button9);
            this.modernPanel3.Controls.Add(this.button10);
            this.modernPanel3.HasShadow = true;
            this.modernPanel3.Location = new System.Drawing.Point(598, 60);
            this.modernPanel3.Name = "modernPanel3";
            this.modernPanel3.SeamlessMode = false;
            this.modernPanel3.Size = new System.Drawing.Size(255, 416);
            this.modernPanel3.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(51, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "Thorlabs Stages";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.BorderRadius = 8;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button11.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.Location = new System.Drawing.Point(153, 261);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 80);
            this.button11.TabIndex = 11;
            this.button11.Text = "Y\r\n⬇";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button12.BorderRadius = 8;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button12.Location = new System.Drawing.Point(153, 91);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 80);
            this.button12.TabIndex = 10;
            this.button12.Text = "⬆\r\nY";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button7.BorderRadius = 8;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(43, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "⬅ Z";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.BorderRadius = 8;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.Location = new System.Drawing.Point(135, 189);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Z →";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.BorderRadius = 8;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button9.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button9.Location = new System.Drawing.Point(43, 261);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 80);
            this.button9.TabIndex = 7;
            this.button9.Text = "X\r\n⬇";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button10.BorderRadius = 8;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button10.Location = new System.Drawing.Point(43, 91);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 80);
            this.button10.TabIndex = 6;
            this.button10.Text = "⬆\r\nX";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // modernPanel4
            // 
            this.modernPanel4.BackColor = System.Drawing.Color.Transparent;
            this.modernPanel4.BackgroundColor = System.Drawing.Color.White;
            this.modernPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.modernPanel4.BorderRadius = 12;
            this.modernPanel4.Controls.Add(this.label14);
            this.modernPanel4.Controls.Add(this.label15);
            this.modernPanel4.Controls.Add(this.label16);
            this.modernPanel4.Controls.Add(this.ZDataPoints);
            this.modernPanel4.Controls.Add(this.ZSize);
            this.modernPanel4.Controls.Add(this.elementHostHelix);
            this.modernPanel4.Controls.Add(this.label13);
            this.modernPanel4.Controls.Add(this.label12);
            this.modernPanel4.Controls.Add(this.btnFitToScreen);
            this.modernPanel4.Controls.Add(this.StopScan);
            this.modernPanel4.Controls.Add(this.RunScan);
            this.modernPanel4.Controls.Add(this.label11);
            this.modernPanel4.Controls.Add(this.label10);
            this.modernPanel4.Controls.Add(this.label9);
            this.modernPanel4.Controls.Add(this.label8);
            this.modernPanel4.Controls.Add(this.XDataPoints);
            this.modernPanel4.Controls.Add(this.XSize);
            this.modernPanel4.Controls.Add(this.YDataPoints);
            this.modernPanel4.Controls.Add(this.YSize);
            this.modernPanel4.Controls.Add(this.label7);
            this.modernPanel4.HasShadow = true;
            this.modernPanel4.Location = new System.Drawing.Point(20, 20);
            this.modernPanel4.Name = "modernPanel4";
            this.modernPanel4.SeamlessMode = false;
            this.modernPanel4.Size = new System.Drawing.Size(850, 530);
            this.modernPanel4.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(30, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Z-Axis";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label15.Location = new System.Drawing.Point(175, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 23;
            this.label15.Text = "Data Points";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label16.Location = new System.Drawing.Point(175, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Distance (mm)";
            // 
            // ZDataPoints
            // 
            this.ZDataPoints.BackColor = System.Drawing.Color.White;
            this.ZDataPoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ZDataPoints.BorderRadius = 6;
            this.ZDataPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZDataPoints.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ZDataPoints.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ZDataPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZDataPoints.Location = new System.Drawing.Point(30, 335);
            this.ZDataPoints.Name = "ZDataPoints";
            this.ZDataPoints.Size = new System.Drawing.Size(140, 16);
            this.ZDataPoints.TabIndex = 21;
            this.ZDataPoints.Text = "10";
            // 
            // ZSize
            // 
            this.ZSize.BackColor = System.Drawing.Color.White;
            this.ZSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ZSize.BorderRadius = 6;
            this.ZSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZSize.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ZSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ZSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZSize.Location = new System.Drawing.Point(30, 305);
            this.ZSize.Name = "ZSize";
            this.ZSize.Size = new System.Drawing.Size(140, 16);
            this.ZSize.TabIndex = 20;
            this.ZSize.Text = "2.0";
            // 
            // elementHostHelix
            // 
            this.elementHostHelix.Location = new System.Drawing.Point(265, 52);
            this.elementHostHelix.Name = "elementHostHelix";
            this.elementHostHelix.Size = new System.Drawing.Size(573, 350);
            this.elementHostHelix.TabIndex = 19;
            this.elementHostHelix.Text = "elementHostHelix";
            this.elementHostHelix.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHostHelix.Child = null;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(30, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "X-Axis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(30, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Y-Axis";
            // 
            // btnFitToScreen
            // 
            this.btnFitToScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnFitToScreen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnFitToScreen.BorderRadius = 8;
            this.btnFitToScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFitToScreen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFitToScreen.ForeColor = System.Drawing.Color.White;
            this.btnFitToScreen.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.btnFitToScreen.Location = new System.Drawing.Point(504, 430);
            this.btnFitToScreen.Name = "btnFitToScreen";
            this.btnFitToScreen.Size = new System.Drawing.Size(140, 35);
            this.btnFitToScreen.TabIndex = 15;
            this.btnFitToScreen.Text = "🔍 Fit to Screen";
            this.btnFitToScreen.UseVisualStyleBackColor = false;
            this.btnFitToScreen.Click += new System.EventHandler(this.btnFitToScreen_Click);
            // 
            // StopScan
            // 
            this.StopScan.BackColor = System.Drawing.Color.Transparent;
            this.StopScan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.StopScan.BorderRadius = 8;
            this.StopScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopScan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.StopScan.ForeColor = System.Drawing.Color.White;
            this.StopScan.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.StopScan.Location = new System.Drawing.Point(680, 470);
            this.StopScan.Name = "StopScan";
            this.StopScan.Size = new System.Drawing.Size(140, 40);
            this.StopScan.TabIndex = 12;
            this.StopScan.Text = "⏹ Stop Scan";
            this.StopScan.UseVisualStyleBackColor = false;
            // 
            // RunScan
            // 
            this.RunScan.BackColor = System.Drawing.Color.Transparent;
            this.RunScan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.RunScan.BorderRadius = 8;
            this.RunScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunScan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RunScan.ForeColor = System.Drawing.Color.White;
            this.RunScan.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.RunScan.Location = new System.Drawing.Point(680, 430);
            this.RunScan.Name = "RunScan";
            this.RunScan.Size = new System.Drawing.Size(140, 40);
            this.RunScan.TabIndex = 11;
            this.RunScan.Text = "🚀 Run Scan";
            this.RunScan.UseVisualStyleBackColor = false;
            this.RunScan.Click += new System.EventHandler(this.RunScan_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label11.Location = new System.Drawing.Point(175, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Data Points";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label10.Location = new System.Drawing.Point(175, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Data Points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label9.Location = new System.Drawing.Point(175, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Distance (mm)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label8.Location = new System.Drawing.Point(175, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Distance (mm)";
            // 
            // XDataPoints
            // 
            this.XDataPoints.BackColor = System.Drawing.Color.White;
            this.XDataPoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.XDataPoints.BorderRadius = 6;
            this.XDataPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.XDataPoints.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.XDataPoints.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XDataPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.XDataPoints.Location = new System.Drawing.Point(30, 225);
            this.XDataPoints.Name = "XDataPoints";
            this.XDataPoints.Size = new System.Drawing.Size(140, 16);
            this.XDataPoints.TabIndex = 6;
            this.XDataPoints.Text = "20";
            // 
            // XSize
            // 
            this.XSize.BackColor = System.Drawing.Color.White;
            this.XSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.XSize.BorderRadius = 6;
            this.XSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.XSize.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.XSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.XSize.Location = new System.Drawing.Point(30, 195);
            this.XSize.Name = "XSize";
            this.XSize.Size = new System.Drawing.Size(140, 16);
            this.XSize.TabIndex = 5;
            this.XSize.Text = "5.0";
            // 
            // YDataPoints
            // 
            this.YDataPoints.BackColor = System.Drawing.Color.White;
            this.YDataPoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.YDataPoints.BorderRadius = 6;
            this.YDataPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YDataPoints.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.YDataPoints.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.YDataPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YDataPoints.Location = new System.Drawing.Point(30, 115);
            this.YDataPoints.Name = "YDataPoints";
            this.YDataPoints.Size = new System.Drawing.Size(140, 16);
            this.YDataPoints.TabIndex = 4;
            this.YDataPoints.Text = "20";
            // 
            // YSize
            // 
            this.YSize.BackColor = System.Drawing.Color.White;
            this.YSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.YSize.BorderRadius = 6;
            this.YSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YSize.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.YSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.YSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YSize.Location = new System.Drawing.Point(30, 85);
            this.YSize.Name = "YSize";
            this.YSize.Size = new System.Drawing.Size(140, 16);
            this.YSize.TabIndex = 3;
            this.YSize.Text = "5.0";
            this.YSize.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(25, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Automated Reciever Scanning";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1140, 640);
            this.Controls.Add(this.powerPanel);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MainForm";
            this.Text = "PICPS Laser Control System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.powerPanel.ResumeLayout(false);
            this.powerPanel.PerformLayout();
            this.modernPanel1.ResumeLayout(false);
            this.modernPanel1.PerformLayout();
            this.modernPanel2.ResumeLayout(false);
            this.modernPanel2.PerformLayout();
            this.modernPanel3.ResumeLayout(false);
            this.modernPanel3.PerformLayout();
            this.modernPanel4.ResumeLayout(false);
            this.modernPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private ModernButton btnViewLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ModernButton button1;
        private ModernButton button2;
        private ModernButton button3;
        private ModernButton button5;
        private ModernButton button6;
        private ModernButton button4;
        private ModernButton button11;
        private ModernButton button12;
        private ModernButton button7;
        private ModernButton button8;
        private ModernButton button9;
        private ModernButton button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private ModernTextBox textBox1;
        private System.Windows.Forms.Label label6;
        private ModernButton HomeAll;
        private ModernTextBox YSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private ModernTextBox XDataPoints;
        private ModernTextBox XSize;
        private ModernTextBox YDataPoints;
        private ModernButton StopScan;
        private ModernButton RunScan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private ModernButton btnFitToScreen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Integration.ElementHost elementHostHelix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private ModernTextBox ZDataPoints;
        private ModernTextBox ZSize;
        private ModernPanel modernPanel1;
        private ModernPanel modernPanel2;
        private ModernPanel modernPanel3;
        private ModernPanel modernPanel4;
        private ModernPanel powerPanel;
        private System.Windows.Forms.Panel statusIndicator;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
    }
}