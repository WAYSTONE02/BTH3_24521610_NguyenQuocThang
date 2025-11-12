namespace Bai8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_STK = new System.Windows.Forms.TextBox();
            this.tB_SoTien = new System.Windows.Forms.TextBox();
            this.tB_Ten = new System.Windows.Forms.TextBox();
            this.tB_DiaChi = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(632, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản Lý Thông Tin Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số tiền trong tài khoản";
            // 
            // tB_STK
            // 
            this.tB_STK.Location = new System.Drawing.Point(304, 120);
            this.tB_STK.Name = "tB_STK";
            this.tB_STK.Size = new System.Drawing.Size(485, 22);
            this.tB_STK.TabIndex = 5;
        
            // 
            // tB_SoTien
            // 
            this.tB_SoTien.Location = new System.Drawing.Point(304, 238);
            this.tB_SoTien.Name = "tB_SoTien";
            this.tB_SoTien.Size = new System.Drawing.Size(485, 22);
            this.tB_SoTien.TabIndex = 6;
           
            // 
            // tB_Ten
            // 
            this.tB_Ten.Location = new System.Drawing.Point(304, 163);
            this.tB_Ten.Name = "tB_Ten";
            this.tB_Ten.Size = new System.Drawing.Size(485, 22);
            this.tB_Ten.TabIndex = 6;
          
            // tB_DiaChi
            // 
            this.tB_DiaChi.Location = new System.Drawing.Point(304, 202);
            this.tB_DiaChi.Name = "tB_DiaChi";
            this.tB_DiaChi.Size = new System.Drawing.Size(485, 22);
            this.tB_DiaChi.TabIndex = 7;
           
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 302);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(968, 187);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(407, 263);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(130, 33);
            this.bt_Them.TabIndex = 9;
            this.bt_Them.Text = "Thêm / Cập nhật";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(680, 263);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(94, 33);
            this.bt_Thoat.TabIndex = 10;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(562, 263);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(94, 33);
            this.bt_Xoa.TabIndex = 10;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 531);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tB_DiaChi);
            this.Controls.Add(this.tB_Ten);
            this.Controls.Add(this.tB_SoTien);
            this.Controls.Add(this.tB_STK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_STK;
        private System.Windows.Forms.TextBox tB_SoTien;
        private System.Windows.Forms.TextBox tB_Ten;
        private System.Windows.Forms.TextBox tB_DiaChi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Xoa;
    }
}

