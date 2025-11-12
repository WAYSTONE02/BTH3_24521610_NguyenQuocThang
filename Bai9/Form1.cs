using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        // Danh sách môn học gốc để reset nhanh
        private List<string> monHocGoc = new List<string>
        {
           "Tiếng Anh", "Lập trình trực quan", "Tư tưởng HCM", "Hệ Điều Hành", "Mạng máy tính"
        };

        public Form1()
        {
            InitializeComponent();

            // ComboBox chuyên ngành
            cB_ChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cB_ChuyenNganh.Items.Add("Công Nghệ Phần Mềm");
            cB_ChuyenNganh.Items.Add("Mạng Máy Tính");
            cB_ChuyenNganh.SelectedIndex = 0;

            // ListBox môn học
            foreach (string mon in monHocGoc)
                listBox1.Items.Add(mon);

            // DataGridView
            dataGridView1.Columns.Add("MSSV", "MSSV");
            dataGridView1.Columns.Add("HoTen", "Họ Tên");
            dataGridView1.Columns.Add("ChuyenNganh", "Chuyên Ngành");
            dataGridView1.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView1.Columns.Add("SoMon", "Số Môn");
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tB_MSSV.Text) ||
                string.IsNullOrWhiteSpace(tB_HoTen.Text) ||
                cB_ChuyenNganh.SelectedIndex == -1 ||
                (!rB_Nam.Checked && !rB_Nu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioiTinh = rB_Nam.Checked ? "Nam" : "Nữ";
            int soMon = listBox2.Items.Count;

            dataGridView1.Rows.Add(tB_MSSV.Text, tB_HoTen.Text, cB_ChuyenNganh.Text, gioiTinh, soMon);
            MessageBox.Show("Lưu thông tin thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form nhập liệu nhưng KHÔNG reset danh sách môn
            tB_MSSV.Clear();
            tB_HoTen.Clear();
            rB_Nam.Checked = false;
            rB_Nu.Checked = false;
            listBox2.Items.Clear();

            // Reset lại listBox1 về danh sách ban đầu
            listBox1.Items.Clear();
            foreach (string mon in monHocGoc)
                listBox1.Items.Add(mon);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                MessageBox.Show("Đã xóa dòng được chọn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }
}
