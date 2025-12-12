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
    public partial class Ex18 : Form
    {
        int second = 0;

        public Ex18()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            // Định dạng hiển thị phút:giây cho đẹp (hoặc chỉ giây như code mẫu)
            // Code mẫu chỉ là second.ToString()
            lblDisplay.Text = second.ToString();
        }
    }
}