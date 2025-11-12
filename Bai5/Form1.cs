using System;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TryGetNumbers(out double a, out double b)
        {
            bool okA = double.TryParse(textBoxNum1.Text, out a);
            bool okB = double.TryParse(textBoxNum2.Text, out b);

            if (!okA || !okB)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void Plusbtn_Click(object sender, EventArgs e)
        {
            if (!TryGetNumbers(out double a, out double b)) return;
            textBoxResult.Text = (a + b).ToString();
        }

        private void Minusbtn_Click(object sender, EventArgs e)
        {
         
        }

        private void Minusbtn_Click_1(object sender, EventArgs e)
        {
            if (!TryGetNumbers(out double a, out double b)) return;
            textBoxResult.Text = (a - b).ToString();
        }

        private void Mulbtn_Click(object sender, EventArgs e)
        {
            if (!TryGetNumbers(out double a, out double b)) return;
            textBoxResult.Text = (a * b).ToString();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if(!TryGetNumbers(out double a, out double b)) return;
            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxResult.Text = (a / b).ToString("0.###");
        }
    }
}
