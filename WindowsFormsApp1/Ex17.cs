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
    public partial class Ex17 : Form
    {
        // Khai báo PictureBox bằng code y hệt ảnh mẫu
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;

        public Ex17()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            // Cấu hình PictureBox
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(x, y);
            this.Controls.Add(pb);

            // Chọn ảnh
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = dlg.FileName;
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x, y);
        }
    }
}
