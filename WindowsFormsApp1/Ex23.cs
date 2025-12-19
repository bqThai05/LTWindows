using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex23 : Form
    {
        // Khai báo 3 màn hình
        Login l = new Login();
        Question q = new Question();
        Finish f = new Finish();

        public Ex23()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Xếp chồng lên nhau tại tọa độ 0,0
            l.Location = new Point(0, 0);
            q.Location = new Point(0, 0);
            f.Location = new Point(0, 0);

            // Hiện Login trước
            this.Controls.Add(l);

            // Gán sự kiện cho các nút (Giờ thì không lỗi nữa nhé)
            l.btLogin.Click += btLogin_Click;
            q.btNext.Click += btNext_Click;
            q.btPrev.Click += btPrev_Click;
            q.btFinish.Click += btFinish_Click;
            f.btExit.Click += btExit_Click;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(l);
            this.Controls.Add(q); // Chuyển sang câu hỏi
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            // Logic chuyển câu tiếp theo (để trống theo ảnh)
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(q);
            this.Controls.Add(l); // Quay lại login
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(q);
            this.Controls.Add(f); // Chuyển sang kết thúc
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Thoát chương trình
        }
    }
}