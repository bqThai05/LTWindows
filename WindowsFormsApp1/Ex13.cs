using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Ex13 : Form
    {
        public Ex13() { InitializeComponent(); }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Logic thêm thông tin vào ListBox
            // 1. Nguyễn Văn A
            //    -Giới tính: Nam
            //    ...

            int count = lbInfo.Items.Count + 1; // Số thứ tự giả lập
            string name = count.ToString() + "." + tbName.Text;
            string gender = rbMale.Checked ? "Nam" : "Nữ";
            string dob = dtpDob.Value.ToString("dd/MM/yyyy");
            string faculty = cbFaculty.Text;

            lbInfo.Items.Add(name);
            lbInfo.Items.Add("   -Giới tính: " + gender);
            lbInfo.Items.Add("   -Ngày sinh: " + dob);
            lbInfo.Items.Add("   -Khoa: " + faculty);
        }

        private void btExit_Click(object sender, EventArgs e) { this.Close(); }
    }
}
