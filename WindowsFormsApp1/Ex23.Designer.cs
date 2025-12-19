namespace WindowsFormsApp1
{
    partial class Ex23
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500); // Chỉnh to to cho giống ảnh
            this.Name = "Ex23";
            this.Text = "Chương trình thi trắc nghiệm";
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        #endregion
    }
}