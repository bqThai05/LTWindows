namespace WindowsFormsApp1
{
    partial class Ex18
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer tmStopwatch;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.tmStopwatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblDisplay.Text = "00:00";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplay.Location = new System.Drawing.Point(50, 30);
            this.lblDisplay.Size = new System.Drawing.Size(200, 50);

            this.btStart.Text = "Start"; this.btStart.Location = new System.Drawing.Point(60, 100);
            this.btStart.Click += new System.EventHandler(this.btStart_Click);

            this.btStop.Text = "Stop"; this.btStop.Location = new System.Drawing.Point(150, 100);
            this.btStop.Click += new System.EventHandler(this.btStop_Click);

            // Timer
            this.tmStopwatch.Interval = 1000; // 1 giây nhảy 1 lần
            this.tmStopwatch.Tick += new System.EventHandler(this.tmStopwatch_Tick);

            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btStop); this.Controls.Add(this.btStart); this.Controls.Add(this.lblDisplay);
            this.Name = "Ex18"; this.Text = "Timer Article";
            this.ResumeLayout(false);
        }
        #endregion
    }
}