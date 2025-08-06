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
            this.lblPower = new System.Windows.Forms.Label();
            this.btnStart = new ModernButton();
            this.btnStop = new ModernButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewLog = new ModernButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.modernPanel1 = new ModernPanel();
            this.HomeAll = new ModernButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new ModernTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modernPanel2 = new ModernPanel();
            this.modernPanel3 = new ModernPanel();
            this.button11 = new ModernButton();
            this.button12 = new ModernButton();
            this.button7 = new ModernButton();
            this.button8 = new ModernButton();
            this.button9 = new ModernButton();
            this.button10 = new ModernButton();
            this.button5 = new ModernButton();
            this.button6 = new ModernButton();
            this.button4 = new ModernButton();
            this.button3 = new ModernButton();
            this.button2 = new ModernButton();
            this.button1 = new ModernButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.modernPanel4 = new ModernPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ZDataPoints = new ModernTextBox();
            this.ZSize = new ModernTextBox();
            this.elementHostHelix = new System.Windows.Forms.Integration.ElementHost();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFitToScreen = new ModernButton();
            this.JogToHigh = new ModernButton();
            this.StopScan = new ModernButton();
            this.RunScan = new ModernButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XDataPoints = new ModernTextBox();
            this.XSize = new ModernTextBox();
            this.YDataPoints = new ModernTextBox();
            this.YSize = new ModernTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.powerPanel = new ModernPanel();
            this.statusIndicator = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.modernPanel1.SuspendLayout();
            this.modernPanel2.SuspendLayout();
            this.modernPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.modernPanel4.SuspendLayout();
            this.powerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 24F, System.Drawing.FontStyle.Bold);
            this.lblPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPower.Location = new System.Drawing.Point(20, 50);
            this.lblPower.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(147, 45);
            this.lblPower.TabIndex = 0;
            this.lblPower.Text = "--- dBm";
            // 
            // btnStart
            // 
            this.btnStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnStart.BorderRadius = 8;
            this.btnStart.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnStart.Location = new System.Drawing.Point(20, 140);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "🚀 Start Laser";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnStop.BorderRadius = 8;
            this.btnStop.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnStop.Location = new System.Drawing.Point(20, 195);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 45);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "⏹ Stop Laser";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Optical Power";
            // 
            // btnViewLog
            // 
            this.btnViewLog.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnViewLog.BorderRadius = 8;
            this.btnViewLog.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Regular);
            this.btnViewLog.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.btnViewLog.Location = new System.Drawing.Point(20, 260);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(140, 40);
            this.btnViewLog.TabIndex = 4;
            this.btnViewLog.Text = "📊 View Log";
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Regular);
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
            // modernPanel1
            // 
            this.modernPanel1.BackgroundColor = System.Drawing.Color.White;
            this.modernPanel1.BorderRadius = 12;
            this.modernPanel1.Controls.Add(this.HomeAll);
            this.modernPanel1.Controls.Add(this.label6);
            this.modernPanel1.Controls.Add(this.label5);
            this.modernPanel1.Controls.Add(this.textBox1);
            this.modernPanel1.HasShadow = true;
            this.modernPanel1.Location = new System.Drawing.Point(20, 450);
            this.modernPanel1.Name = "modernPanel1";
            this.modernPanel1.Size = new System.Drawing.Size(850, 100);
            this.modernPanel1.TabIndex = 20;
            // 
            // HomeAll
            // 
            this.HomeAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.HomeAll.BorderRadius = 8;
            this.HomeAll.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 11F, System.Drawing.FontStyle.Bold);
            this.HomeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeAll.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.HomeAll.Location = new System.Drawing.Point(350, 25);
            this.HomeAll.Name = "HomeAll";
            this.HomeAll.Size = new System.Drawing.Size(150, 50);
            this.HomeAll.TabIndex = 18;
            this.HomeAll.Text = "🏠 Home All";
            this.HomeAll.Click += new System.EventHandler(this.HomeAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(170, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(30, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Step Resolution";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.BorderRadius = 6;
            this.textBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Regular);
            this.textBox1.Location = new System.Drawing.Point(30, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 30);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 8F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(430, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "PIC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(580, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "ThorLabs Stages";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zaber Stages";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // modernPanel2
            // 
            this.modernPanel2.BackgroundColor = System.Drawing.Color.White;
            this.modernPanel2.BorderRadius = 12;
            this.modernPanel2.Controls.Add(this.label2);
            this.modernPanel2.Controls.Add(this.button5);
            this.modernPanel2.Controls.Add(this.button6);
            this.modernPanel2.Controls.Add(this.button4);
            this.modernPanel2.Controls.Add(this.button3);
            this.modernPanel2.Controls.Add(this.button2);
            this.modernPanel2.Controls.Add(this.button1);
            this.modernPanel2.HasShadow = true;
            this.modernPanel2.Location = new System.Drawing.Point(20, 60);
            this.modernPanel2.Name = "modernPanel2";
            this.modernPanel2.Size = new System.Drawing.Size(400, 370);
            this.modernPanel2.TabIndex = 21;
            // 
            // modernPanel3
            // 
            this.modernPanel3.BackgroundColor = System.Drawing.Color.White;
            this.modernPanel3.BorderRadius = 12;
            this.modernPanel3.Controls.Add(this.label3);
            this.modernPanel3.Controls.Add(this.label4);
            this.modernPanel3.Controls.Add(this.button11);
            this.modernPanel3.Controls.Add(this.button12);
            this.modernPanel3.Controls.Add(this.button7);
            this.modernPanel3.Controls.Add(this.button8);
            this.modernPanel3.Controls.Add(this.button9);
            this.modernPanel3.Controls.Add(this.button10);
            this.modernPanel3.HasShadow = true;
            this.modernPanel3.Location = new System.Drawing.Point(450, 60);
            this.modernPanel3.Name = "modernPanel3";
            this.modernPanel3.Size = new System.Drawing.Size(420, 370);
            this.modernPanel3.TabIndex = 22;
            // 
            // button11
            // 
            this.button11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button11.BorderRadius = 8;
            this.button11.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button11.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button11.Location = new System.Drawing.Point(340, 250);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 80);
            this.button11.TabIndex = 11;
            this.button11.Text = "Y\r\n⬇";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button12.BorderRadius = 8;
            this.button12.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button12.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.button12.Location = new System.Drawing.Point(340, 80);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 80);
            this.button12.TabIndex = 10;
            this.button12.Text = "⬆\r\nY";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button7.BorderRadius = 8;
            this.button7.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.button7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button7.Location = new System.Drawing.Point(30, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "⬅ Z";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button8.BorderRadius = 8;
            this.button8.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.button8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.button8.Location = new System.Drawing.Point(170, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Z →";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button9.BorderRadius = 8;
            this.button9.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button9.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button9.Location = new System.Drawing.Point(230, 250);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 80);
            this.button9.TabIndex = 7;
            this.button9.Text = "X\r\n⬇";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button10.BorderRadius = 8;
            this.button10.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button10.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.button10.Location = new System.Drawing.Point(230, 80);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 80);
            this.button10.TabIndex = 6;
            this.button10.Text = "⬆\r\nX";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button5.BorderRadius = 8;
            this.button5.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button5.Location = new System.Drawing.Point(30, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "Y\r\n⬇";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button6.BorderRadius = 8;
            this.button6.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.button6.Location = new System.Drawing.Point(30, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 80);
            this.button6.TabIndex = 4;
            this.button6.Text = "⬆\r\nY";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button4.BorderRadius = 8;
            this.button4.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.button4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button4.Location = new System.Drawing.Point(120, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "⬅ Z";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button3.BorderRadius = 8;
            this.button3.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.button3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.button3.Location = new System.Drawing.Point(260, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Z →";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button2.BorderRadius = 8;
            this.button2.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button2.Location = new System.Drawing.Point(140, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "X\r\n⬇";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button1.BorderRadius = 8;
            this.button1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Bold);
            this.button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.button1.Location = new System.Drawing.Point(140, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "⬆\r\nX";
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // modernPanel4
            // 
            this.modernPanel4.BackgroundColor = System.Drawing.Color.White;
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
            this.modernPanel4.Controls.Add(this.JogToHigh);
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
            this.modernPanel4.Size = new System.Drawing.Size(850, 530);
            this.modernPanel4.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(30, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Z-Axis";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label15.Location = new System.Drawing.Point(180, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 23;
            this.label15.Text = "Data Points";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label16.Location = new System.Drawing.Point(180, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Area (mm)";
            // 
            // ZDataPoints
            // 
            this.ZDataPoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ZDataPoints.BorderRadius = 6;
            this.ZDataPoints.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ZDataPoints.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.ZDataPoints.Location = new System.Drawing.Point(30, 335);
            this.ZDataPoints.Name = "ZDataPoints";
            this.ZDataPoints.Size = new System.Drawing.Size(140, 25);
            this.ZDataPoints.TabIndex = 21;
            this.ZDataPoints.Text = "10";
            // 
            // ZSize
            // 
            this.ZSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ZSize.BorderRadius = 6;
            this.ZSize.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ZSize.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.ZSize.Location = new System.Drawing.Point(30, 305);
            this.ZSize.Name = "ZSize";
            this.ZSize.Size = new System.Drawing.Size(140, 25);
            this.ZSize.TabIndex = 20;
            this.ZSize.Text = "2.0";
            // 
            // elementHostHelix
            // 
            this.elementHostHelix.Location = new System.Drawing.Point(320, 60);
            this.elementHostHelix.Name = "elementHostHelix";
            this.elementHostHelix.Size = new System.Drawing.Size(500, 350);
            this.elementHostHelix.TabIndex = 19;
            this.elementHostHelix.Text = "elementHostHelix";
            this.elementHostHelix.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHostHelix.Child = null;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(30, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "X-Axis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(30, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Y-Axis";
            // 
            // btnFitToScreen
            // 
            this.btnFitToScreen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnFitToScreen.BorderRadius = 8;
            this.btnFitToScreen.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.btnFitToScreen.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.btnFitToScreen.Location = new System.Drawing.Point(320, 430);
            this.btnFitToScreen.Name = "btnFitToScreen";
            this.btnFitToScreen.Size = new System.Drawing.Size(140, 35);
            this.btnFitToScreen.TabIndex = 15;
            this.btnFitToScreen.Text = "🔍 Fit to Screen";
            this.btnFitToScreen.Click += new System.EventHandler(this.btnFitToScreen_Click);
            // 
            // JogToHigh
            // 
            this.JogToHigh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.JogToHigh.BorderRadius = 8;
            this.JogToHigh.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.JogToHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JogToHigh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.JogToHigh.Location = new System.Drawing.Point(480, 430);
            this.JogToHigh.Name = "JogToHigh";
            this.JogToHigh.Size = new System.Drawing.Size(140, 35);
            this.JogToHigh.TabIndex = 14;
            this.JogToHigh.Text = "🎯 Jog to Peak";
            this.JogToHigh.Click += new System.EventHandler(this.JogToHigh_Click);
            // 
            // StopScan
            // 
            this.StopScan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.StopScan.BorderRadius = 8;
            this.StopScan.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.StopScan.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.StopScan.Location = new System.Drawing.Point(680, 470);
            this.StopScan.Name = "StopScan";
            this.StopScan.Size = new System.Drawing.Size(140, 40);
            this.StopScan.TabIndex = 12;
            this.StopScan.Text = "⏹ Stop Scan";
            // 
            // RunScan
            // 
            this.RunScan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.RunScan.BorderRadius = 8;
            this.RunScan.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10F, System.Drawing.FontStyle.Bold);
            this.RunScan.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.RunScan.Location = new System.Drawing.Point(680, 430);
            this.RunScan.Name = "RunScan";
            this.RunScan.Size = new System.Drawing.Size(140, 40);
            this.RunScan.TabIndex = 11;
            this.RunScan.Text = "🚀 Run Scan";
            this.RunScan.Click += new System.EventHandler(this.RunScan_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label11.Location = new System.Drawing.Point(180, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Data Points";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label10.Location = new System.Drawing.Point(180, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Data Points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label9.Location = new System.Drawing.Point(180, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Area (mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label8.Location = new System.Drawing.Point(180, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Area (mm)";
            // 
            // XDataPoints
            // 
            this.XDataPoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.XDataPoints.BorderRadius = 6;
            this.XDataPoints.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.XDataPoints.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.XDataPoints.Location = new System.Drawing.Point(30, 225);
            this.XDataPoints.Name = "XDataPoints";
            this.XDataPoints.Size = new System.Drawing.Size(140, 25);
            this.XDataPoints.TabIndex = 6;
            this.XDataPoints.Text = "20";
            // 
            // XSize
            // 
            this.XSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.XSize.BorderRadius = 6;
            this.XSize.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.XSize.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.XSize.Location = new System.Drawing.Point(30, 195);
            this.XSize.Name = "XSize";
            this.XSize.Size = new System.Drawing.Size(140, 25);
            this.XSize.TabIndex = 5;
            this.XSize.Text = "5.0";
            // 
            // YDataPoints
            // 
            this.YDataPoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.YDataPoints.BorderRadius = 6;
            this.YDataPoints.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.YDataPoints.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.YDataPoints.Location = new System.Drawing.Point(30, 115);
            this.YDataPoints.Name = "YDataPoints";
            this.YDataPoints.Size = new System.Drawing.Size(140, 25);
            this.YDataPoints.TabIndex = 4;
            this.YDataPoints.Text = "20";
            // 
            // YSize
            // 
            this.YSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.YSize.BorderRadius = 6;
            this.YSize.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.YSize.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.YSize.Location = new System.Drawing.Point(30, 85);
            this.YSize.Name = "YSize";
            this.YSize.Size = new System.Drawing.Size(140, 25);
            this.YSize.TabIndex = 3;
            this.YSize.Text = "5.0";
            this.YSize.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(30, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Automated Scanning";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // powerPanel
            // 
            this.powerPanel.BackgroundColor = System.Drawing.Color.White;
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
            this.powerPanel.Size = new System.Drawing.Size(200, 340);
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
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1140, 640);
            this.Controls.Add(this.powerPanel);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9F, System.Drawing.FontStyle.Regular);
            this.Name = "MainForm";
            this.Text = "PICPS Laser Control System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.modernPanel1.ResumeLayout(false);
            this.modernPanel1.PerformLayout();
            this.modernPanel2.ResumeLayout(false);
            this.modernPanel2.PerformLayout();
            this.modernPanel3.ResumeLayout(false);
            this.modernPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.modernPanel4.ResumeLayout(false);
            this.modernPanel4.PerformLayout();
            this.powerPanel.ResumeLayout(false);
            this.powerPanel.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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
        private ModernButton JogToHigh;
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
    }
}