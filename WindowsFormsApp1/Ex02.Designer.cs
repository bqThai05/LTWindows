namespace WindowsFormsApp1
{
    partial class Ex02
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Ex02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 304);
            this.Name = "Ex02";
            this.Text = "Form1";
            this.KeyPreview = true; 
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ex02_KeyUp);
            this.ResumeLayout(false);
        }

        #endregion
    }
}