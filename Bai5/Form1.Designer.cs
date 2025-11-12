using System;

namespace Bai5
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
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.Plusbtn = new System.Windows.Forms.Button();
            this.Minusbtn = new System.Windows.Forms.Button();
            this.Mulbtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(180, 88);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(45, 16);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "Num1:";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Location = new System.Drawing.Point(180, 160);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(45, 16);
            this.Num2.TabIndex = 1;
            this.Num2.Text = "Num2:";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(243, 85);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(310, 22);
            this.textBoxNum1.TabIndex = 2;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(243, 154);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(310, 22);
            this.textBoxNum2.TabIndex = 3;
            // 
            // Plusbtn
            // 
            this.Plusbtn.Location = new System.Drawing.Point(243, 239);
            this.Plusbtn.Name = "Plusbtn";
            this.Plusbtn.Size = new System.Drawing.Size(63, 50);
            this.Plusbtn.TabIndex = 4;
            this.Plusbtn.Text = "+";
            this.Plusbtn.UseVisualStyleBackColor = true;
            this.Plusbtn.Click += new System.EventHandler(this.Plusbtn_Click);
            // 
            // Minusbtn
            // 
            this.Minusbtn.Location = new System.Drawing.Point(345, 239);
            this.Minusbtn.Name = "Minusbtn";
            this.Minusbtn.Size = new System.Drawing.Size(63, 50);
            this.Minusbtn.TabIndex = 5;
            this.Minusbtn.Text = "-";
            this.Minusbtn.UseVisualStyleBackColor = true;
            this.Minusbtn.Click += new System.EventHandler(this.Minusbtn_Click_1);
            // 
            // Mulbtn
            // 
            this.Mulbtn.Location = new System.Drawing.Point(447, 239);
            this.Mulbtn.Name = "Mulbtn";
            this.Mulbtn.Size = new System.Drawing.Size(63, 50);
            this.Mulbtn.TabIndex = 5;
            this.Mulbtn.Text = "X";
            this.Mulbtn.UseVisualStyleBackColor = true;
            this.Mulbtn.Click += new System.EventHandler(this.Mulbtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(533, 239);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(63, 50);
            this.divBtn.TabIndex = 6;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result: ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(243, 362);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(310, 22);
            this.textBoxResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.Minusbtn);
            this.Controls.Add(this.Mulbtn);
            this.Controls.Add(this.Plusbtn);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Button Plusbtn;
        private System.Windows.Forms.Button Minusbtn;
        private System.Windows.Forms.Button Mulbtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

