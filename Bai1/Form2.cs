using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;

            this.Load += FormCon_Load;
            this.FormClosing += FormCon_FormClosing;
        }

        private void FormCon_Load(object sender, EventArgs e)
        {
            parentForm.GhiSuKienCon("FormCon_Load");
        }

        private void FormCon_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.GhiSuKienCon("FormCon_FormClosing");
        }

        // Nút đóng Form Con
       

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
