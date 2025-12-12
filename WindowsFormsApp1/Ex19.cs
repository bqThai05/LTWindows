using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex19 : Form
    {
        PictureBox pb = new PictureBox();
        int xBall = 0;
        int yBall = 0;
        int xDelta = 5;
        int yDelta = 5;

        public Ex19() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmGame.Interval = 10;
            tmGame.Tick += new EventHandler(tmGame_Tick);
            tmGame.Start();

            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(xBall, yBall);

            // Nhớ chép file ảnh vào ổ D hoặc đổi đường dẫn này nhé
            try { pb.ImageLocation = @"D:\2 LTWIN\ball.jpg"; } catch { }

            this.Controls.Add(pb);
        }

        void tmGame_Tick(object sender, EventArgs e)
        {
            xBall += xDelta;
            yBall += yDelta;

            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
                xDelta = -xDelta;

            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
                yDelta = -yDelta;

            pb.Location = new Point(xBall, yBall);
        }
    }
}