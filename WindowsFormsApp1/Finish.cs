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
    public partial class Finish : UserControl
    {
        public Button btExit = new Button();

        public Finish()
        {
            InitializeComponent();
            this.Size = new Size(600, 450);

            // Group 1: Thông tin
            GroupBox gbInfo = new GroupBox() { Text = "Thông tin thí sinh", Location = new Point(50, 30), Size = new Size(500, 150) };
            int x = 150, y = 30;
            gbInfo.Controls.Add(new Label() { Text = "Mã: 0001", Location = new Point(x, y), AutoSize = true }); y += 30;
            gbInfo.Controls.Add(new Label() { Text = "Tên: Nguyễn Văn A", Location = new Point(x, y), AutoSize = true }); y += 30;
            gbInfo.Controls.Add(new Label() { Text = "Ngày sinh: 01/01/1996", Location = new Point(x, y), AutoSize = true }); y += 30;
            gbInfo.Controls.Add(new Label() { Text = "Nơi sinh: TP. Hồ Chí Minh", Location = new Point(x, y), AutoSize = true });

            // Group 2: Kết quả
            GroupBox gbResult = new GroupBox() { Text = "Kết quả thi", Location = new Point(50, 200), Size = new Size(500, 150) };
            y = 30;
            gbResult.Controls.Add(new Label() { Text = "Tổng số câu hỏi: 100", Location = new Point(x, y), AutoSize = true }); y += 30;
            gbResult.Controls.Add(new Label() { Text = "Tổng số câu trả lời: 85", Location = new Point(x, y), AutoSize = true }); y += 30;
            gbResult.Controls.Add(new Label() { Text = "Tổng số câu trả lời đúng: 62", Location = new Point(x, y), AutoSize = true }); y += 30;
            gbResult.Controls.Add(new Label() { Text = "Tổng số điểm đạt được: 6.2", Location = new Point(x, y), AutoSize = true });

            // Button
            btExit.Text = "Kết thúc"; btExit.Location = new Point(450, 380); btExit.Size = new Size(90, 30);

            this.Controls.Add(gbInfo);
            this.Controls.Add(gbResult);
            this.Controls.Add(btExit);
        }
    }
}