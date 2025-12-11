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
    public partial class Ex06 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";

        public Ex06()
        {
            InitializeComponent();
        }

        // Hàm xử lý chung cho TẤT CẢ các nút
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            // 1. Nhập số hoặc dấu chấm
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }
            // 2. Các phép toán 2 ngôi (+ - * /)
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            // 3. Dấu Bằng (=)
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+":
                        txtDisplay.Text = (workingMemory + secondValue).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (workingMemory - secondValue).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (workingMemory * secondValue).ToString();
                        break;
                    case "/":
                        // Tránh chia cho 0 nếu cần, nhưng code mẫu ko có nên mình ko thêm
                        txtDisplay.Text = (workingMemory / secondValue).ToString();
                        break;
                }
            }
            // 4. Các phép toán 1 ngôi (±, √, %, 1/x)
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = 1 / currVal;
                txtDisplay.Text = currVal.ToString();
            }
            // 5. Xóa ký tự (←)
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
            }
            // 6. Các phím nhớ (Memory)
            else if (bt.Text == "MC") { memory = 0; }
            else if (bt.Text == "MR") { txtDisplay.Text = memory.ToString(); }
            else if (bt.Text == "MS") { memory = decimal.Parse(txtDisplay.Text); txtDisplay.Clear(); }
            else if (bt.Text == "M+") { memory += decimal.Parse(txtDisplay.Text); }
            else if (bt.Text == "M-") { memory -= decimal.Parse(txtDisplay.Text); }

            // 7. Các phím xóa màn hình (C, CE)
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }
        }
    }
}
