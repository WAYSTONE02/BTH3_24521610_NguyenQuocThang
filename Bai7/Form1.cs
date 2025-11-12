using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btn8.BackColor == Color.White)
            {
                btn8.BackColor = Color.Blue;
                capnhatB();
                btn8.Enabled = false;
            }
        }

        public void capnhatA()
        {
            int tongtien = int.Parse(label3.Text);
            tongtien += 5000;
            label3.Text = tongtien.ToString();
        }

        public void capnhatB()
        {
            int tongtien = int.Parse(label3.Text);
            tongtien += 6500;
            label3.Text = tongtien.ToString();
        }

        public void capnhatC()
        {
            int tongtien = int.Parse(label3.Text);
            tongtien += 8000;
            label3.Text = tongtien.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.White)
            {
                btn1.BackColor = Color.Blue;
                capnhatA();
                btn1.Enabled = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor == Color.White)
            {
                btn2.BackColor = Color.Blue;
                capnhatA();
                btn2.Enabled = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.White)
            {
                btn3.BackColor = Color.Blue;
                capnhatA();
                btn3.Enabled = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.White)
            {
                btn4.BackColor = Color.Blue;
                capnhatA();
                btn4.Enabled = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.White)
            {
                btn5.BackColor = Color.Blue;
                capnhatB();
                btn5.Enabled = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.White)
            {
                btn6.BackColor = Color.Blue;
                capnhatB();
                btn6.Enabled = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.White)
            {
                btn7.BackColor = Color.Blue;
                capnhatB();
                btn7.Enabled = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.White)
            {
                btn9.BackColor = Color.Blue;
                capnhatC();
                btn9.Enabled = false;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.White)
            {
                btn10.BackColor = Color.Blue;
                capnhatC();
                btn10.Enabled = false;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.BackColor == Color.White)
            {
                btn11.BackColor = Color.Blue;
                capnhatC();
                btn11.Enabled = false;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.BackColor == Color.White)
            {
                btn12.BackColor = Color.Blue;
                capnhatC();
                btn12.Enabled = false;
            }
        }

       

        private void btn_huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                    btn.Enabled = true;
                    label3.Text = 0.ToString();
                }
            }
        }

        private void btn_ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.Yellow;
                    
                }
            }
            MessageBox.Show("Xac Nhan Thanh Toan: " + label3.Text);
            label3.Text = 0.ToString();
        }
    }
}
