namespace Bai9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tB_MSSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_HoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_ChuyenNganh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_Nu = new System.Windows.Forms.RadioButton();
            this.rB_Nam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // tB_MSSV
            // 
            this.tB_MSSV.Location = new System.Drawing.Point(140, 32);
            this.tB_MSSV.Name = "tB_MSSV";
            this.tB_MSSV.Size = new System.Drawing.Size(160, 22);
            this.tB_MSSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // tB_HoTen
            // 
            this.tB_HoTen.Location = new System.Drawing.Point(140, 67);
            this.tB_HoTen.Name = "tB_HoTen";
            this.tB_HoTen.Size = new System.Drawing.Size(220, 22);
            this.tB_HoTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyên ngành";
            // 
            // cB_ChuyenNganh
            // 
            this.cB_ChuyenNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_ChuyenNganh.FormattingEnabled = true;
            this.cB_ChuyenNganh.Items.AddRange(new object[] {
            "",
            "Khoa học máy tính",
            "Hệ thống thông tin"});
            this.cB_ChuyenNganh.Location = new System.Drawing.Point(140, 105);
            this.cB_ChuyenNganh.Name = "cB_ChuyenNganh";
            this.cB_ChuyenNganh.Size = new System.Drawing.Size(220, 24);
            this.cB_ChuyenNganh.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_Nu);
            this.groupBox1.Controls.Add(this.rB_Nam);
            this.groupBox1.Location = new System.Drawing.Point(400, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rB_Nu
            // 
            this.rB_Nu.AutoSize = true;
            this.rB_Nu.Location = new System.Drawing.Point(85, 28);
            this.rB_Nu.Name = "rB_Nu";
            this.rB_Nu.Size = new System.Drawing.Size(45, 20);
            this.rB_Nu.TabIndex = 1;
            this.rB_Nu.TabStop = true;
            this.rB_Nu.Text = "Nữ";
            this.rB_Nu.UseVisualStyleBackColor = true;
            // 
            // rB_Nam
            // 
            this.rB_Nam.AutoSize = true;
            this.rB_Nam.Location = new System.Drawing.Point(16, 28);
            this.rB_Nam.Name = "rB_Nam";
            this.rB_Nam.Size = new System.Drawing.Size(57, 20);
            this.rB_Nam.TabIndex = 0;
            this.rB_Nam.TabStop = true;
            this.rB_Nam.Text = "Nam";
            this.rB_Nam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn các môn học tham gia";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 84);
            this.listBox1.TabIndex = 8;

            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(335, 180);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 84);
            this.listBox2.TabIndex = 9;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(245, 190);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 25);
            this.btnThemMon.TabIndex = 10;
            this.btnThemMon.Text = ">";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(245, 225);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(75, 25);
            this.btnXoaMon.TabIndex = 11;
            this.btnXoaMon.Text = "<";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(140, 285);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 30);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu Thông Tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(285, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa Chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(43, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 180);
            this.dataGridView1.TabIndex = 14;
        
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cB_ChuyenNganh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_HoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_MSSV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = ".";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_MSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_HoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_ChuyenNganh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_Nu;
        private System.Windows.Forms.RadioButton rB_Nam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
