using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex20 : Form
    {
        // 1. Khai báo biến (Giống ảnh 4)
        PictureBox pbEgg = new PictureBox();
        Timer tmEgg = new Timer();

        int xEgg = 300;
        int yEgg = 0;
        int xDelta = 3;
        int yDelta = 3;

        public Ex20()
        {
            InitializeComponent();
        }

        // 2. Code Form Load (Giống ảnh 5)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình Timer
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            // Cấu hình PictureBox Quả trứng
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);

            try
            {
                pbEgg.Image = Image.FromFile("../../Images/egg.png");
            }
            catch
            {
                pbEgg.BackColor = Color.Gold;
            }
        }

        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDelta;

            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                try
                {
                    pbEgg.Image = Image.FromFile("../../Images/eggv.png");
                }
                catch
                {
                    pbEgg.BackColor = Color.Red; 
                }
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}