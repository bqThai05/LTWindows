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
    public partial class Login : UserControl
    {
        public Button btLogin = new Button();
        public Button btExit = new Button();

        public Login()
        {
            InitializeComponent();
            this.Size = new Size(600, 450);

            // Group 1: Thông tin thí sinh
            GroupBox gbInfo = new GroupBox() { Text = "Thông tin thí sinh", Location = new Point(10, 10), Size = new Size(580, 200) };

            int y = 30;
            gbInfo.Controls.Add(new Label() { Text = "Mã", Location = new Point(50, y), AutoSize = true });
            gbInfo.Controls.Add(new TextBox() { Location = new Point(120, y - 3), Size = new Size(150, 20) });

            y += 30;
            gbInfo.Controls.Add(new Label() { Text = "Tên", Location = new Point(50, y), AutoSize = true });
            gbInfo.Controls.Add(new TextBox() { Location = new Point(120, y - 3), Size = new Size(250, 20) });

            y += 30;
            gbInfo.Controls.Add(new Label() { Text = "Ngày sinh", Location = new Point(50, y), AutoSize = true });
            gbInfo.Controls.Add(new TextBox() { Location = new Point(120, y - 3), Size = new Size(150, 20) });

            y += 30;
            gbInfo.Controls.Add(new Label() { Text = "Nơi sinh", Location = new Point(50, y), AutoSize = true });
            gbInfo.Controls.Add(new TextBox() { Location = new Point(120, y - 3), Size = new Size(250, 20) });

            // Group 2: Thông tin kỳ thi
            GroupBox gbExam = new GroupBox() { Text = "Thông tin kỳ thi", Location = new Point(10, 220), Size = new Size(580, 100) };
            gbExam.Controls.Add(new Label() { Text = "Danh sách kỳ thi", Location = new Point(20, 40), AutoSize = true });
            ComboBox cbExam = new ComboBox() { Location = new Point(120, 37), Size = new Size(200, 20) };
            cbExam.Items.Add("Chứng chỉ tin học A tiếng Anh");
            cbExam.SelectedIndex = 0;
            gbExam.Controls.Add(cbExam);

            gbExam.Controls.Add(new Label() { Text = "Số câu hỏi: 60", Location = new Point(350, 40), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) });
            gbExam.Controls.Add(new Label() { Text = "Thời gian: 120", Location = new Point(450, 40), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) });

            // Buttons
            btLogin.Text = "Tiếp tục"; btLogin.Location = new Point(380, 350); btLogin.Size = new Size(90, 30);
            btExit.Text = "Kết thúc"; btExit.Location = new Point(480, 350); btExit.Size = new Size(90, 30);

            this.Controls.Add(gbInfo);
            this.Controls.Add(gbExam);
            this.Controls.Add(btLogin);
            this.Controls.Add(btExit);
        }
    }
}