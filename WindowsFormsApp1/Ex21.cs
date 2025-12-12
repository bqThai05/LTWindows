using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex21 : Form
    {
        // 1. Khai báo biến (Giống hệt ảnh 4)
        PictureBox pbBasket = new PictureBox();
        int xBasket = 300;
        int yBasket = 500;
        int xDelta = 30;

        public Ex21()
        {
            InitializeComponent();
        }

        // 2. Form Load (Giống hệt ảnh 5 - phần trên)
        private void Form1_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);

            // Đường dẫn ảnh giống y code mẫu
            // Anh nhớ tạo thư mục Images và bỏ file basket.png vào nhé
            pbBasket.Image = Image.FromFile("../../Images/gio.jpg");
        }

        // 3. Sự kiện bấm phím (Giống hệt ảnh 5 - phần dưới)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 & (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDelta;

            if (e.KeyValue == 37 & xBasket > 0)
                xBasket -= xDelta;

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}