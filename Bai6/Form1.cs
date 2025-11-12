using System;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0, result = 0;
        string operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Nút C
            if (btn.Text == "C")
            {
                textBox1.Text = "0";
                a = b = result = 0;
                operation = "";
                return;
            }

            // Nút CE
            if (btn.Text == "CE")
            {
                textBox1.Text = "0";
                return;
            }

            // Nút Backspace
            if (btn.Text == "Backspace")
            {
                if (textBox1.Text.Length > 1)
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                else textBox1.Text = "0";
                return;
            }

            // Nút phép toán
            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/" || btn.Text == "%")
            {
                if (operation != "")
                {
                    b = double.Parse(textBox1.Text);
                    switch (operation)
                    {
                        case "+": a += b; break;
                        case "-": a -= b; break;
                        case "*": a *= b; break;
                        case "/": a = b != 0 ? a / b : 0; break;
                        case "%": a = a * b / 100; break;
                    }
                    textBox1.Text = a.ToString("G15");
                }
                else
                {
                    a = double.Parse(textBox1.Text);
                }
                operation = btn.Text;
                isOperationPerformed = true;
                return;
            }

            // Nút căn bậc 2
            if (btn.Text == "sqrt")
            {
                double val = double.Parse(textBox1.Text);
                textBox1.Text = Math.Sqrt(val).ToString("G15");
                return;
            }

            // Nút 1/x
            if (btn.Text == "1/x")
            {
                double val = double.Parse(textBox1.Text);
                if (val == 0)
                {
                    MessageBox.Show("Khong the chia cho 0!");
                    return;
                }
                textBox1.Text = (1 / val).ToString("G15");
                return;
            }

            // Nút dấu bằng
            if (btn.Text == "=")
            {
                b = double.Parse(textBox1.Text);
                switch (operation)
                {
                    case "+": result = a + b; break;
                    case "-": result = a - b; break;
                    case "*": result = a * b; break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("Khong the chia cho 0!");
                            result = 0;
                        }
                        else result = a / b;
                        break;
                    case "%": result = a * b / 100; break;
                    default: result = b; break;
                }
                textBox1.Text = result.ToString("G15");
                operation = "";
                isOperationPerformed = true;
                return;
            }

            // Nút ±
            if (btn.Text == "+/-")
            {
                double val = double.Parse(textBox1.Text);
                textBox1.Text = (-val).ToString("G15");
                return;
            }

            // Nút dấu chấm
            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text += ".";
                return;
            }

            // Nút số
            if (char.IsDigit(btn.Text[0]))
            {
                if (textBox1.Text == "0" || isOperationPerformed)
                {
                    textBox1.Text = btn.Text;
                    isOperationPerformed = false;
                }
                else textBox1.Text += btn.Text;
            }
        }
    }
}
