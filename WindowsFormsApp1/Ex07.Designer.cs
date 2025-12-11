namespace WindowsFormsApp1
{
    partial class Ex07
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cb_Faculty;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            // Thêm các mục giống hệt trong ảnh
            this.cb_Faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kế toán",
            "Cơ khí",
            "Điện",
            "Hóa"});
            this.cb_Faculty.Location = new System.Drawing.Point(30, 30);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(200, 21);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.Text = "Điện"; // Giá trị mặc định hiển thị
            // 
            // Ex07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Ex07";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}