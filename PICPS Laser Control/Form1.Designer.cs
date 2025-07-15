
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
            this.SuspendLayout();
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblPower.Location = new System.Drawing.Point(31, 57);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(118, 37);
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
            this.label1.Size = new System.Drawing.Size(66, 20);
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
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(193, 259);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Name = "MainForm";
            this.Text = "Optical Power Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewLog;
    }
}
