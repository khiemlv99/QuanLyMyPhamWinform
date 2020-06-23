namespace GUI
{
    partial class frmBanHang
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
            this.pnHoaDon = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTienTraKhach = new System.Windows.Forms.TextBox();
            this.txtKhachThanhToan = new System.Windows.Forms.TextBox();
            this.txtKhachCanTra = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDanhSachDaChon = new System.Windows.Forms.DataGridView();
            this.pnTimKiem = new System.Windows.Forms.Panel();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new DAL.DataSet();
            this.pnHoaDon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachDaChon)).BeginInit();
            this.pnTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHoaDon
            // 
            this.pnHoaDon.Controls.Add(this.groupBox1);
            this.pnHoaDon.Controls.Add(this.textBox1);
            this.pnHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnHoaDon.Location = new System.Drawing.Point(689, 0);
            this.pnHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnHoaDon.Name = "pnHoaDon";
            this.pnHoaDon.Size = new System.Drawing.Size(443, 594);
            this.pnHoaDon.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.txtTienTraKhach);
            this.groupBox1.Controls.Add(this.txtKhachThanhToan);
            this.groupBox1.Controls.Add(this.txtKhachCanTra);
            this.groupBox1.Controls.Add(this.txtGiamGia);
            this.groupBox1.Controls.Add(this.txtTongTienHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(403, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThanhToan.Location = new System.Drawing.Point(4, 384);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(395, 58);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtTienTraKhach
            // 
            this.txtTienTraKhach.Location = new System.Drawing.Point(133, 297);
            this.txtTienTraKhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienTraKhach.Name = "txtTienTraKhach";
            this.txtTienTraKhach.Size = new System.Drawing.Size(260, 22);
            this.txtTienTraKhach.TabIndex = 9;
            // 
            // txtKhachThanhToan
            // 
            this.txtKhachThanhToan.Location = new System.Drawing.Point(133, 240);
            this.txtKhachThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKhachThanhToan.Name = "txtKhachThanhToan";
            this.txtKhachThanhToan.Size = new System.Drawing.Size(260, 22);
            this.txtKhachThanhToan.TabIndex = 8;
            // 
            // txtKhachCanTra
            // 
            this.txtKhachCanTra.Location = new System.Drawing.Point(133, 177);
            this.txtKhachCanTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKhachCanTra.Name = "txtKhachCanTra";
            this.txtKhachCanTra.Size = new System.Drawing.Size(260, 22);
            this.txtKhachCanTra.TabIndex = 7;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(133, 118);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(260, 22);
            this.txtGiamGia.TabIndex = 6;
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.Location = new System.Drawing.Point(133, 52);
            this.txtTongTienHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.Size = new System.Drawing.Size(260, 22);
            this.txtTongTienHang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = " Tiền trả khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách cần trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giảm giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDanhSachDaChon);
            this.panel1.Controls.Add(this.pnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 594);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewDanhSachDaChon
            // 
            this.dataGridViewDanhSachDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanhSachDaChon.Location = new System.Drawing.Point(0, 57);
            this.dataGridViewDanhSachDaChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDanhSachDaChon.Name = "dataGridViewDanhSachDaChon";
            this.dataGridViewDanhSachDaChon.Size = new System.Drawing.Size(689, 537);
            this.dataGridViewDanhSachDaChon.TabIndex = 1;
            // 
            // pnTimKiem
            // 
            this.pnTimKiem.Controls.Add(this.cboLoaiSanPham);
            this.pnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimKiem.Location = new System.Drawing.Point(0, 0);
            this.pnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnTimKiem.Name = "pnTimKiem";
            this.pnTimKiem.Size = new System.Drawing.Size(689, 57);
            this.pnTimKiem.TabIndex = 0;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(16, 15);
            this.cboLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(243, 24);
            this.cboLoaiSanPham.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1132, 594);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBanHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "                                                       Bán hàng";
            this.pnHoaDon.ResumeLayout(false);
            this.pnHoaDon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachDaChon)).EndInit();
            this.pnTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTienTraKhach;
        private System.Windows.Forms.TextBox txtKhachThanhToan;
        private System.Windows.Forms.TextBox txtKhachCanTra;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTimKiem;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private DAL.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachDaChon;
    }
}