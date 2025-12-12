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
    public partial class Ex15 : Form
    {
        List<Employee> lst;

        public Ex15() { InitializeComponent(); }

        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "53418"; em.Name = "Trần Tiến"; em.Age = 20; em.Gender = true;
            lst.Add(em);

            em = new Employee();
            em.Id = "53416"; em.Name = "Nguyễn Cường"; em.Age = 25; em.Gender = false;
            lst.Add(em);

            em = new Employee();
            em.Id = "53417"; em.Name = "Nguyễn Hào"; em.Age = 23; em.Gender = true;
            lst.Add(em);

            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst = GetData();
            // Cách làm trong ảnh Article 21: Duyệt list rồi Add thủ công vào Grid
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int.Parse(tbAge.Text);
            em.Gender = ckGender.Checked;
            lst.Add(em);

            // Add thủ công vào Grid
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Code giống ảnh Article 21
            int idx = dgvEmployee.CurrentCell.RowIndex;
            lst.RemoveAt(idx);
            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Code giống ảnh Article 21
            int idx = e.RowIndex;
            // Vì dòng cuối cùng là dòng NewRow (trống) nên cần check
            if (idx < dgvEmployee.Rows.Count - 1 && dgvEmployee.Rows[idx].Cells[0].Value != null)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
            }
        }

        private void btExit_Click(object sender, EventArgs e) { this.Close(); }
    }

    // Class Employee giống trong ảnh
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
    }
}