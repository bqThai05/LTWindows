namespace WindowsFormsApp1
{
    partial class Ex06
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay;
        // Khai báo hàng loạt nút
        private System.Windows.Forms.Button btMC, btMR, btMS, btMPlus, btMMinus;
        private System.Windows.Forms.Button btBack, btCE, btC, btNeg, btSqrt;
        private System.Windows.Forms.Button bt7, bt8, bt9, btDiv, btPercent;
        private System.Windows.Forms.Button bt4, bt5, bt6, btMul, btInv;
        private System.Windows.Forms.Button bt1, bt2, bt3, btSub;
        private System.Windows.Forms.Button bt0, btDot, btAdd, btEquals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // txtDisplay
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(320, 38);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Hàm hỗ trợ tạo nút nhanh để code đỡ dài
            int w = 60, h = 40, gap = 5, x = 12, y = 60;

            // Hàng 1: MC MR MS M+ M-
            CreateBtn(ref btMC, "MC", x, y, w, h); x += w + gap;
            CreateBtn(ref btMR, "MR", x, y, w, h); x += w + gap;
            CreateBtn(ref btMS, "MS", x, y, w, h); x += w + gap;
            CreateBtn(ref btMPlus, "M+", x, y, w, h); x += w + gap;
            CreateBtn(ref btMMinus, "M-", x, y, w, h);

            // Hàng 2: <- CE C ± √
            x = 12; y += h + gap;
            CreateBtn(ref btBack, "←", x, y, w, h); x += w + gap;
            CreateBtn(ref btCE, "CE", x, y, w, h); x += w + gap;
            CreateBtn(ref btC, "C", x, y, w, h); x += w + gap;
            CreateBtn(ref btNeg, "±", x, y, w, h); x += w + gap;
            CreateBtn(ref btSqrt, "√", x, y, w, h);

            // Hàng 3: 7 8 9 / %
            x = 12; y += h + gap;
            CreateBtn(ref bt7, "7", x, y, w, h); x += w + gap;
            CreateBtn(ref bt8, "8", x, y, w, h); x += w + gap;
            CreateBtn(ref bt9, "9", x, y, w, h); x += w + gap;
            CreateBtn(ref btDiv, "/", x, y, w, h); x += w + gap;
            CreateBtn(ref btPercent, "%", x, y, w, h);

            // Hàng 4: 4 5 6 * 1/x
            x = 12; y += h + gap;
            CreateBtn(ref bt4, "4", x, y, w, h); x += w + gap;
            CreateBtn(ref bt5, "5", x, y, w, h); x += w + gap;
            CreateBtn(ref bt6, "6", x, y, w, h); x += w + gap;
            CreateBtn(ref btMul, "*", x, y, w, h); x += w + gap;
            CreateBtn(ref btInv, "1/x", x, y, w, h);

            // Hàng 5: 1 2 3 - 
            x = 12; y += h + gap;
            CreateBtn(ref bt1, "1", x, y, w, h); x += w + gap;
            CreateBtn(ref bt2, "2", x, y, w, h); x += w + gap;
            CreateBtn(ref bt3, "3", x, y, w, h); x += w + gap;
            CreateBtn(ref btSub, "-", x, y, w, h);

            // Hàng 6: 0 . + = (Nút = to hơn chút)
            x = 12; y += h + gap;
            CreateBtn(ref bt0, "0", x, y, w * 2 + gap, h); x += w * 2 + gap + gap; // Nút 0 rộng gấp đôi
            CreateBtn(ref btDot, ".", x, y, w, h); x += w + gap;
            CreateBtn(ref btAdd, "+", x, y, w, h); x += w + gap;

            // Nút = nằm dọc ở góc (theo logic ảnh MyCalc thì nó nằm ở vị trí M- nhưng to, ở đây mình để ở cuối cho gọn)
            CreateBtn(ref btEquals, "=", x, y - (h + gap), w, h * 2 + gap); // Cao gấp đôi

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 350);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Ex06";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CreateBtn(ref System.Windows.Forms.Button btn, string text, int x, int y, int w, int h)
        {
            btn = new System.Windows.Forms.Button();
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.Text = text;
            btn.UseVisualStyleBackColor = true;
            // Gán chung sự kiện Click vào hàm Button_Click (Quan trọng nhất bài này)
            btn.Click += new System.EventHandler(this.Button_Click);
            this.Controls.Add(btn);
        }

        #endregion
    }
}