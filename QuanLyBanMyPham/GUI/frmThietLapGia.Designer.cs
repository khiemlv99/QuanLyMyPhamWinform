﻿namespace GUI
{
    partial class frmThietLapGia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaLoai = new System.Windows.Forms.Button();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.lstLoaiSP = new System.Windows.Forms.ListBox();
            this.dataGridSanPham = new System.Windows.Forms.DataGridView();
            this.pnThemLoai = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnLuuLoai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSanPham)).BeginInit();
            this.pnThemLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lstLoaiSP);
            this.panel1.Controls.Add(this.dataGridSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 489);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnSuaSP);
            this.panel2.Controls.Add(this.btnXoaSP);
            this.panel2.Controls.Add(this.btnThemSP);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.txtGiaNhap);
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 202);
            this.panel2.TabIndex = 15;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(351, 49);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(164, 20);
            this.txtGiaBan.TabIndex = 25;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(351, 16);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(164, 20);
            this.txtGiaNhap.TabIndex = 24;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(98, 16);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(164, 20);
            this.txtTenSP.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "THIẾT LẬP GIÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnThemLoai);
            this.panel3.Controls.Add(this.btnXoaLoai);
            this.panel3.Controls.Add(this.btnThemLoai);
            this.panel3.Location = new System.Drawing.Point(111, 23);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(151, 258);
            this.panel3.TabIndex = 17;
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoaLoai.Location = new System.Drawing.Point(10, 46);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Padding = new System.Windows.Forms.Padding(3);
            this.btnXoaLoai.Size = new System.Drawing.Size(131, 35);
            this.btnXoaLoai.TabIndex = 1;
            this.btnXoaLoai.Text = "Xóa loại sản phẩm";
            this.btnXoaLoai.UseVisualStyleBackColor = true;
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemLoai.Location = new System.Drawing.Point(10, 10);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(131, 36);
            this.btnThemLoai.TabIndex = 0;
            this.btnThemLoai.Text = "Thêm loại sản phẩm";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // lstLoaiSP
            // 
            this.lstLoaiSP.FormattingEnabled = true;
            this.lstLoaiSP.Location = new System.Drawing.Point(0, 23);
            this.lstLoaiSP.Name = "lstLoaiSP";
            this.lstLoaiSP.Size = new System.Drawing.Size(105, 251);
            this.lstLoaiSP.TabIndex = 16;
            this.lstLoaiSP.SelectedIndexChanged += new System.EventHandler(this.lstLoaiSP_SelectedIndexChanged);
            // 
            // dataGridSanPham
            // 
            this.dataGridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSanPham.Location = new System.Drawing.Point(268, 23);
            this.dataGridSanPham.Name = "dataGridSanPham";
            this.dataGridSanPham.Size = new System.Drawing.Size(598, 245);
            this.dataGridSanPham.TabIndex = 18;
            this.dataGridSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSanPham_CellClick);
            // 
            // pnThemLoai
            // 
            this.pnThemLoai.Controls.Add(this.btnLuuLoai);
            this.pnThemLoai.Controls.Add(this.txtTenLoai);
            this.pnThemLoai.Controls.Add(this.label6);
            this.pnThemLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThemLoai.Location = new System.Drawing.Point(10, 81);
            this.pnThemLoai.Name = "pnThemLoai";
            this.pnThemLoai.Size = new System.Drawing.Size(131, 167);
            this.pnThemLoai.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên loại:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenLoai.Location = new System.Drawing.Point(0, 23);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(131, 20);
            this.txtTenLoai.TabIndex = 1;
            // 
            // btnLuuLoai
            // 
            this.btnLuuLoai.Location = new System.Drawing.Point(23, 81);
            this.btnLuuLoai.Name = "btnLuuLoai";
            this.btnLuuLoai.Size = new System.Drawing.Size(78, 29);
            this.btnLuuLoai.TabIndex = 2;
            this.btnLuuLoai.Text = "Lưu";
            this.btnLuuLoai.UseVisualStyleBackColor = true;
            this.btnLuuLoai.Click += new System.EventHandler(this.btnLuuLoai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(593, 11);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(260, 67);
            this.txtMoTa.TabIndex = 27;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(98, 111);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(112, 35);
            this.btnThemSP.TabIndex = 28;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(283, 111);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(112, 35);
            this.btnXoaSP.TabIndex = 29;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(461, 111);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(112, 35);
            this.btnSuaSP.TabIndex = 30;
            this.btnSuaSP.Text = "Sửa giá";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(630, 111);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThietLapGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 489);
            this.Controls.Add(this.panel1);
            this.Name = "frmThietLapGia";
            this.Text = "frmThietLapGia";
            this.Load += new System.EventHandler(this.frmThietLapGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSanPham)).EndInit();
            this.pnThemLoai.ResumeLayout(false);
            this.pnThemLoai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaLoai;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.ListBox lstLoaiSP;
        private System.Windows.Forms.DataGridView dataGridSanPham;
        private System.Windows.Forms.Panel pnThemLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuuLoai;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu;

    }
}