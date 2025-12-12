namespace WindowsFormsApp1
{
    partial class Ex17
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btLeft, btRight, btFile;
        // PictureBox được tạo bằng code trong file .cs như ảnh mẫu
        // Nhưng để dễ thiết kế, mình khai báo ở đây luôn, còn code logic vẫn giữ nguyên

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btLeft.Text = "<-"; this.btLeft.Location = new System.Drawing.Point(100, 200);
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);

            this.btRight.Text = "->"; this.btRight.Location = new System.Drawing.Point(180, 200);
            this.btRight.Click += new System.EventHandler(this.btRight_Click);

            this.btFile.Text = "File ..."; this.btFile.Location = new System.Drawing.Point(260, 200);
            this.btFile.Click += new System.EventHandler(this.btFile_Click);

            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btFile); this.Controls.Add(this.btRight); this.Controls.Add(this.btLeft);
            this.Name = "Ex17"; this.Text = "Simple Game";
            this.ResumeLayout(false);
        }
        #endregion
    }
}   