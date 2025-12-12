namespace WindowsFormsApp1
{
    partial class Ex15
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;

        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAdd, btDelete, btExit;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            // ... Khởi tạo các textbox button label
            this.label1 = new System.Windows.Forms.Label(); this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label(); this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label(); this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAdd = new System.Windows.Forms.Button(); this.btDelete = new System.Windows.Forms.Button(); this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            // DataGridView setup cột thủ công giống ảnh Article 20/21
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colName, this.colAge, this.colGender });
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Size = new System.Drawing.Size(460, 150);
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);

            this.colId.HeaderText = "Mã nhân viên"; this.colId.Name = "colId";
            this.colName.HeaderText = "Tên nhân viên"; this.colName.Name = "colName"; this.colName.Width = 150;
            this.colAge.HeaderText = "Tuổi"; this.colAge.Name = "colAge"; this.colAge.Width = 50;
            this.colGender.HeaderText = "Giới tính (Nam)"; this.colGender.Name = "colGender";

            // Form inputs
            int y = 180;
            this.label1.Text = "Mã"; this.label1.Location = new System.Drawing.Point(20, y);
            this.tbId.Location = new System.Drawing.Point(80, y - 3); this.tbId.Size = new System.Drawing.Size(100, 20);

            y += 30;
            this.label2.Text = "Tên"; this.label2.Location = new System.Drawing.Point(20, y);
            this.tbName.Location = new System.Drawing.Point(80, y - 3); this.tbName.Size = new System.Drawing.Size(200, 20);

            y += 30;
            this.label3.Text = "Tuổi"; this.label3.Location = new System.Drawing.Point(20, y);
            this.tbAge.Location = new System.Drawing.Point(80, y - 3); this.tbAge.Size = new System.Drawing.Size(100, 20);

            y += 30;
            this.ckGender.Text = "Nam"; this.ckGender.Location = new System.Drawing.Point(80, y - 3);

            // Buttons
            this.btAdd.Text = "Thêm"; this.btAdd.Location = new System.Drawing.Point(200, 300);
            this.btAdd.Click += new System.EventHandler(this.btAddNew_Click);

            this.btDelete.Text = "Xóa"; this.btDelete.Location = new System.Drawing.Point(290, 300);
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            this.btExit.Text = "Thoát"; this.btExit.Location = new System.Drawing.Point(380, 300);
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            this.ClientSize = new System.Drawing.Size(484, 340);
            this.Controls.Add(this.btExit); this.Controls.Add(this.btDelete); this.Controls.Add(this.btAdd);
            this.Controls.Add(this.ckGender); this.Controls.Add(this.tbAge); this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName); this.Controls.Add(this.label2); this.Controls.Add(this.tbId); this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Ex15"; this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}