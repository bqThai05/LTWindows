namespace WindowsFormsApp1
{
    partial class Ex14
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.TextBox tbId, tbName;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.PictureBox pbImage;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label(); this.label2 = new System.Windows.Forms.Label(); this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox(); this.tbName = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();

            this.label1.Text = "Mã nhân viên"; this.label1.Location = new System.Drawing.Point(20, 20);
            this.tbId.Location = new System.Drawing.Point(100, 17); this.tbId.Size = new System.Drawing.Size(150, 20);

            this.label2.Text = "Tên nhân viên"; this.label2.Location = new System.Drawing.Point(20, 50);
            this.tbName.Location = new System.Drawing.Point(100, 47); this.tbName.Size = new System.Drawing.Size(250, 20);

            this.label3.Text = "Ảnh 3x4"; this.label3.Location = new System.Drawing.Point(20, 80);

            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(100, 80);
            this.pbImage.Size = new System.Drawing.Size(120, 160);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Co giãn ảnh cho vừa khung
            this.pbImage.TabStop = false;

            this.btBrowse.Text = "Chọn ảnh ..."; this.btBrowse.Location = new System.Drawing.Point(240, 80);
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);

            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.pbImage); this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbName); this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3); this.Controls.Add(this.label2); this.Controls.Add(this.label1);
            this.Name = "Ex14"; this.Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}