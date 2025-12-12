namespace WindowsFormsApp1
{
    partial class Ex20
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
            this.ClientSize = new System.Drawing.Size(600, 500); // Chỉnh form to ra chút
            this.Name = "Ex20";
            this.Text = "Catch Egg"; // Tiêu đề giống ảnh
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        #endregion
    }
}