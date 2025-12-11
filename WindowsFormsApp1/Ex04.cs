using System;
using System.ComponentModel; // Cần cái này cho CancelEventArgs
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex04 : Form
    {
        public Ex04()
        {
            InitializeComponent();
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Code giống y ảnh: Chặn ký tự không phải số và không phải phím điều khiển (như xóa)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            // Code giống y ảnh: Kiểm tra năm > 2000
            // Lưu ý: Nếu ô trống thì code này sẽ lỗi, nhưng trong ảnh thầy viết vậy nên mình viết y chang
            if (string.IsNullOrEmpty(tbYear.Text)) return;

            int year = int.Parse(tbYear.Text);
            if (year > 2000)
            {
                e.Cancel = true;
            }
        }
    }
}