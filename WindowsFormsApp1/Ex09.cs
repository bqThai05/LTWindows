using System;
using System.Collections; 
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
    public partial class Ex09 : Form
    {
        public Ex09()
        {
            InitializeComponent();
        }

        // Tạo dữ liệu giả lập giống hệt trong ảnh (giữ nguyên lỗi chính tả như yêu cầu)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doan"; // Giữ nguyên lỗi thiếu chữ 'h' giống ảnh
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02"; // Giữ nguyên lỗi lặp mã K02 giống ảnh
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name"; // Hiển thị Tên khoa
        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Khi thay đổi chọn lựa, lấy ID ra để hiển thị
            // Lưu ý: Trong ảnh đặt ValueMember ở đây là "Id"
            cb_Faculty.ValueMember = "Id";
            if (cb_Faculty.SelectedValue != null)
            {
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // Khi bấm OK, đổi ValueMember thành "Name" để lấy tên
            cb_Faculty.ValueMember = "Name";
            if (cb_Faculty.SelectedValue != null)
            {
                string name = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
            }
        }
    }

    // Class Faculty nằm cùng namespace nhưng bên ngoài class Form
    public class Faculty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}