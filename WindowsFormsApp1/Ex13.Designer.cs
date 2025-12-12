namespace WindowsFormsApp1
{
    partial class Ex13
    {
        private System.ComponentModel.IContainer components = null;
        // Khai báo control
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();

            // Setup giao diện giống ảnh
            this.lbName.Text = "Họ và tên"; this.lbName.Location = new System.Drawing.Point(20, 20);
            this.tbName.Location = new System.Drawing.Point(100, 17); this.tbName.Size = new System.Drawing.Size(200, 20);

            this.lbDob.Text = "Ngày sinh"; this.lbDob.Location = new System.Drawing.Point(20, 50);
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(100, 47); this.dtpDob.Size = new System.Drawing.Size(200, 20);

            this.gbGender.Text = "Giới tính"; this.gbGender.Location = new System.Drawing.Point(100, 80); this.gbGender.Size = new System.Drawing.Size(200, 50);
            this.rbMale.Text = "Nam"; this.rbMale.Location = new System.Drawing.Point(20, 20); this.rbMale.Checked = true;
            this.rbFemale.Text = "Nữ"; this.rbFemale.Location = new System.Drawing.Point(100, 20);
            this.gbGender.Controls.Add(this.rbMale); this.gbGender.Controls.Add(this.rbFemale);

            this.lbFaculty.Text = "Khoa"; this.lbFaculty.Location = new System.Drawing.Point(20, 140);
            this.cbFaculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Kế toán", "Cơ khí", "Điện" });
            this.cbFaculty.Text = "Công nghệ thông tin";
            this.cbFaculty.Location = new System.Drawing.Point(100, 137); this.cbFaculty.Size = new System.Drawing.Size(200, 21);

            this.lbStatus.Text = "Trạng thái"; this.lbStatus.Location = new System.Drawing.Point(20, 170);
            this.lbInfo.Location = new System.Drawing.Point(100, 170); this.lbInfo.Size = new System.Drawing.Size(200, 100);

            this.btAdd.Text = "Thêm"; this.btAdd.Location = new System.Drawing.Point(120, 280);
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);

            this.btExit.Text = "Thoát"; this.btExit.Location = new System.Drawing.Point(210, 280);
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            this.ClientSize = new System.Drawing.Size(340, 330);
            this.Controls.Add(this.btExit); this.Controls.Add(this.btAdd); this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbStatus); this.Controls.Add(this.cbFaculty); this.Controls.Add(this.lbFaculty);
            this.Controls.Add(this.gbGender); this.Controls.Add(this.dtpDob); this.Controls.Add(this.lbDob);
            this.Controls.Add(this.tbName); this.Controls.Add(this.lbName);
            this.Name = "Ex13"; this.Text = "Quản lý sinh viên";
            this.gbGender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}