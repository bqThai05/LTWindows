using System;
using System.Collections; // Nhớ dòng này để dùng ArrayList
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ex12 : Form
    {
        public Ex12()
        {
            InitializeComponent();
        }

        // Hàm tạo dữ liệu giả lập y chang ảnh
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            lbSong.DataSource = lst;
            lbSong.DisplayMember = "Name"; // Chỉ hiển thị Tên bài hát
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang chọn bài nào không để tránh lỗi
            if (lbSong.SelectedItem != null)
            {
                // Ép kiểu item đang chọn về Class Song
                Song song = (Song)lbSong.SelectedItem;

                string id = song.Id.ToString();
                string name = song.Name;
                string author = song.Author;

                // Nối chuỗi và thêm vào list bên phải y chang ảnh
                lbFavorite.Items.Add(id + " - " + name + " - " + author);
            }
        }
    }

    // Class Song nằm ở đây luôn cho tiện
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}