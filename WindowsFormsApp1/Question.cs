using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Question : UserControl
    {
        public Button btPrev = new Button();
        public Button btNext = new Button();
        public Button btFinish = new Button();

        public Question()
        {
            InitializeComponent();
            this.Size = new Size(600, 450);

            // Group 1: Thông tin (Header)
            GroupBox gbHeader = new GroupBox() { Text = "Thông tin thí sinh", Location = new Point(10, 10), Size = new Size(580, 60) };
            gbHeader.Controls.Add(new Label() { Text = "Mã: 1", Location = new Point(50, 25), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) });
            gbHeader.Controls.Add(new Label() { Text = "Tên: Nguyễn Anh Tú", Location = new Point(200, 25), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) });
            gbHeader.Controls.Add(new Label() { Text = "Ngày sinh: 10/10/1994", Location = new Point(400, 25), AutoSize = true });

            // Group 2: Câu hỏi
            GroupBox gbQues = new GroupBox() { Text = "Câu hỏi", Location = new Point(10, 80), Size = new Size(580, 80) };
            gbQues.Controls.Add(new Label() { Text = "Một cộng một bằng bao nhiêu?", Location = new Point(30, 30), AutoSize = true, Font = new Font("Arial", 12, FontStyle.Bold) });

            // Group 3: Câu trả lời
            GroupBox gbAns = new GroupBox() { Text = "Câu trả lời", Location = new Point(10, 170), Size = new Size(580, 150) };
            gbAns.Controls.Add(new RadioButton() { Text = "Hai", Location = new Point(30, 30), Checked = true });
            gbAns.Controls.Add(new RadioButton() { Text = "Bốn", Location = new Point(30, 60) });
            gbAns.Controls.Add(new RadioButton() { Text = "Năm", Location = new Point(30, 90) });
            gbAns.Controls.Add(new RadioButton() { Text = "Ba", Location = new Point(30, 120) });

            // Buttons
            btPrev.Text = "Quay lại"; btPrev.Location = new Point(280, 350); btPrev.Size = new Size(90, 30);
            btNext.Text = "Tiếp tục"; btNext.Location = new Point(380, 350); btNext.Size = new Size(90, 30);
            btFinish.Text = "Nộp bài"; btFinish.Location = new Point(480, 350); btFinish.Size = new Size(90, 30);

            this.Controls.Add(gbHeader);
            this.Controls.Add(gbQues);
            this.Controls.Add(gbAns);
            this.Controls.Add(btPrev);
            this.Controls.Add(btNext);
            this.Controls.Add(btFinish);
        }
    }
}