using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    
    public partial class Ex01 : Form
    {
        string path = @"D:\2 LTWIN\form.xml";
        public Ex01()
        {
            InitializeComponent();

        }

        public void Write(InfoWindows iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }
        public InfoWindows Read()
        {
            if (!File.Exists(path)) return null;
            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path);
            InfoWindows iw = (InfoWindows)reader.Deserialize(file);
            file.Close();
            return iw;
        }
        private void Ex01_Resize(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
        }

        // 2. Hàm này chỉ chạy khi bạn THẢ CHUỘT ra -> Lúc này mới Ghi file
        private void Ex01_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;
            Write(iw); // Chỉ lưu khi đã kéo xong
        }

        void Ex01_Load(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;
            Write(iw);
        }

    }
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Location { get; set; }
    }

}
