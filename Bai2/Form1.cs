using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = rand.Next(0, this.ClientSize.Width - 120);
            int y = rand.Next(0, this.ClientSize.Height - 40);

            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            Brush brush = new SolidBrush(randomColor);
        
            g.DrawString("Paint Event", new Font("Arial", 14, FontStyle.Bold), brush, x, y);

            brush.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
