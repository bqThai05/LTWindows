using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex16 : Form
    {
        List<Employee> lstEmp;
        BindingSource bs = new BindingSource(); // Quan trọng: BindingSource

        public Ex16() { InitializeComponent(); }

        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee() { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true });
            lst.Add(new Employee() { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false });
            lst.Add(new Employee() { Id = "53417", Name = "Nguyễn Hào", Age = 23, Gender = true });
            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();
            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs; // Gán BindingSource cho Grid
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int.Parse(tbAge.Text);
            em.Gender = ckGender.Checked;

            lstEmp.Add(em);
            bs.ResetBindings(false);

            // Trong ảnh code mẫu có dòng này, mình giữ nguyên cho giống
            // dgvEmployee.Rows.Add(...) -> Dòng này thừa nếu dùng BindingSource nhưng để giống ảnh thì cứ giữ hoặc comment lại nếu lỗi
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell == null) return;
            int idx = dgvEmployee.CurrentCell.RowIndex;

            bs.RemoveAt(idx); // Xóa khỏi BindingSource
            // lstEmp.RemoveAt(idx); // BindingSource tự xử lý list gốc rồi
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvEmployee.Rows.Count)
            {
                // Lấy dữ liệu từ Grid hiển thị lên TextBox
                // Lưu ý: Khi dùng DataSource thì thứ tự cột có thể khác, nhưng ở đây mình lấy theo index cột
                if (dgvEmployee.Rows[idx].Cells[0].Value != null)
                {
                    tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                    tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                    tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                    ckGender.Checked = (bool)dgvEmployee.Rows[idx].Cells[3].Value;
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e) { this.Close(); }
    }
}