using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex22 : Form
    {
        // Khai báo biến (Giống bài trước + thêm pbChicken để code va chạm không lỗi)
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox(); // Cần có cái này vì dòng xEgg = pbChicken.Location.X

        Timer tmEgg = new Timer();
        Timer tmChicken = new Timer();

        int xBasket = 300; int yBasket = 550; int xDeltaBasket = 30;
        int xChicken = 300; int yChicken = 10; int xDeltaChicken = 5;
        int xEgg = 300; int yEgg = 10; int yDeltaEgg = 3;

        public Ex22() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 10; tmEgg.Tick += tmEgg_Tick; tmEgg.Start();
            tmChicken.Interval = 10; tmChicken.Tick += tmChiken_Tick; tmChicken.Start();

            // Basket
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(70, 70);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            try { pbBasket.Image = Image.FromFile("../../Images/basket.png"); } catch { pbBasket.BackColor = Color.Brown; }

            // Egg
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 50);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            try { pbEgg.Image = Image.FromFile("../../Images/egg_gold.png"); } catch { pbEgg.BackColor = Color.Gold; }

            // Chicken
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);
            try { pbChicken.Image = Image.FromFile("../../Images/chicken.png"); } catch { pbChicken.BackColor = Color.White; }
        }

        // --- HÀM NÀY LÀ TRỌNG TÂM CỦA ARTICLE 28 (Giống hệt ảnh cuối) ---
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg;

            // Nếu trứng chạm đáy thì vỡ
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                try { pbEgg.Image = Image.FromFile("../../Images/egg_gold_broken.png"); } catch { }
            }

            // Xử lý va chạm (Rectangle Intersect) - Code y chang ảnh
            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (unionRect.IsEmpty == false)
            {
                yEgg = 30; // Reset vị trí Y
                xEgg = pbChicken.Location.X; // Reset vị trí X theo con gà

                // (Optional) Reset ảnh trứng lại thành nguyên vẹn nếu nãy giờ lỡ bị vỡ
                try { pbEgg.Image = Image.FromFile("../../Images/egg_gold.png"); } catch { }
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }
        // ---------------------------------------------------------------

        void tmChiken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
                xDeltaChicken = -xDeltaChicken;
            pbChicken.Location = new Point(xChicken, yChicken);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 & (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDeltaBasket;
            if (e.KeyValue == 37 & xBasket > 0)
                xBasket -= xDeltaBasket;
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}