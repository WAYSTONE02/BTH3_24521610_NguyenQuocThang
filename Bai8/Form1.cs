using System;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("STK", 100);
            listView1.Columns.Add("Tên", 150);
            listView1.Columns.Add("Địa chỉ", 200);
            listView1.Columns.Add("Số tiền", 100);
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            string stk = tB_STK.Text.Trim();
            string ten = tB_Ten.Text.Trim();
            string diaChi = tB_DiaChi.Text.Trim();
            string soTien = tB_SoTien.Text.Trim();

            if (stk == "" || ten == "" || diaChi == "" || soTien == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool daTonTai = false;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == stk)
                {

                    item.SubItems[1].Text = ten;
                    item.SubItems[2].Text = diaChi;
                    item.SubItems[3].Text = soTien;
                    daTonTai = true;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (!daTonTai)
            {
                ListViewItem item = new ListViewItem(stk);
                item.SubItems.Add(ten);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(soTien);
                listView1.Items.Add(item);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            double tong = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                double value;
                if (double.TryParse(item.SubItems[3].Text, out value))
                    tong += value;
            }
            this.Text = "Tổng số tiền: " + tong.ToString("N0");
            tB_STK.Clear();
            tB_Ten.Clear();
            tB_DiaChi.Clear();
            tB_SoTien.Clear();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
