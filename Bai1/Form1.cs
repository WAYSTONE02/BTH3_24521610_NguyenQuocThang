using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GhiSuKien("Constructor Form1()");

            // Gắn các sự kiện vòng đời của Form
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;

            button1.Click += button1_Click; // nút mở FormCon
        }

        private void GhiSuKien(string tenSuKien)
        {
            string thoiGian = DateTime.Now.ToString("HH:mm:ss.fff");
            listBox1.Items.Add($"{thoiGian} - {tenSuKien}");
        }

        private void Form1_Load(object sender, EventArgs e) => GhiSuKien("Form1_Load");
        private void Form1_Shown(object sender, EventArgs e) => GhiSuKien("Form1_Shown");
        private void Form1_Activated(object sender, EventArgs e) => GhiSuKien("Form1_Activated");
        private void Form1_Deactivate(object sender, EventArgs e) => GhiSuKien("Form1_Deactivate");
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => GhiSuKien("Form1_FormClosing");
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) => GhiSuKien("Form1_FormClosed");

        private void button1_Click(object sender, EventArgs e)
        {
            GhiSuKien("Tạo FormCon()");
            Form2 f2 = new Form2(this);
            f2.Show();
        }

  
        public void GhiSuKienCon(string tenSuKien)
        {
            string thoiGian = DateTime.Now.ToString("HH:mm:ss.fff");
            listBox1.Items.Add($"{thoiGian} - [FormCon] {tenSuKien}");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
