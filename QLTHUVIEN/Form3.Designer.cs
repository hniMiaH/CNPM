﻿namespace WindowsFormsApplication1
{
    partial class theloaisach
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
            this.luoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatheloai = new System.Windows.Forms.TextBox();
            this.txttentheloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(12, 153);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(291, 189);
            this.luoi.TabIndex = 0;
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(73, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẬP NHẬT THỂ LOẠI SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã thể loại";
            // 
            // txtmatheloai
            // 
            this.txtmatheloai.Location = new System.Drawing.Point(127, 79);
            this.txtmatheloai.Name = "txtmatheloai";
            this.txtmatheloai.Size = new System.Drawing.Size(130, 20);
            this.txtmatheloai.TabIndex = 3;
            // 
            // txttentheloai
            // 
            this.txttentheloai.Location = new System.Drawing.Point(127, 120);
            this.txttentheloai.Name = "txttentheloai";
            this.txttentheloai.Size = new System.Drawing.Size(130, 20);
            this.txttentheloai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên thể loại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(310, 107);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 6;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(310, 153);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 7;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(310, 194);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(310, 273);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 9;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(310, 232);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 10;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // theloaisach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 354);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txttentheloai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmatheloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luoi);
            this.MaximizeBox = false;
            this.Name = "theloaisach";
            this.Text = "Thể loại sách";
            this.Load += new System.EventHandler(this.nhaxuatban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatheloai;
        private System.Windows.Forms.TextBox txttentheloai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button luu;
    }
}