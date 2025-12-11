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
namespace WindowsFormsApp1
{
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
        }

        private void Ex02_KeyUp(object sender, KeyEventArgs e)
        {
            
            StreamWriter sw = new StreamWriter(@"D:\2 LTWIN\Key_Logger.txt", true);
            sw.Write(e.KeyCode.ToString() + " ");
            sw.Close();
        }
    }
}
