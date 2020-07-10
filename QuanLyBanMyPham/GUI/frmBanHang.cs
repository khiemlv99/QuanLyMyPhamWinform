using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using System.Data;


namespace GUI
{
    public partial class frmBanHang : Form
    {
        GioHang_BLL_DAL GioHang = new GioHang_BLL_DAL();
        List<SanPhamHoaDon> lstGioHang = new List<SanPhamHoaDon>();
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            cboSanPham.DataSource = GioHang.getAllSanPham();
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int ma = int.Parse(cboSanPham.SelectedValue.ToString());
            
            SanPham s = GioHang.getSanPhamTheoMa(ma);
            int giaBan = (int)s.GiaBanSP;
            string tenSP = s.TenSP;
            string moTa = s.MoTaSP;
            txtTenSanPham.Text = s.TenSP;
            txtMaSanPham.Text = ma+"";
            txtTenSanPham.Text = tenSP;
            txtMoTa.Text = moTa;
            txtGiaBan.Text = giaBan+"";
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if(txtMaSanPham.Text=="")
                MessageBox.Show("Cần chọn sản phẩm trước khi thêm vào giỏ ", "Thông báo !!!");
            else if (cbSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn số lượng", "Thông báo !!!");

            }
            else
            {            
                SanPhamHoaDon sp = new SanPhamHoaDon();
                sp.MaSP = int.Parse(txtMaSanPham.Text);
                sp.TenSP = txtTenSanPham.Text;
                sp.MoTaSP = txtMoTa.Text;
                sp.GiaBan = int.Parse(txtGiaBan.Text);
                sp.SoLuong = int.Parse(cbSoLuong.Text.ToString());
                MessageBox.Show("Tới đây rồi", "Thông báo !!!");
                lstGioHang.Add(sp);
                LoadDataGridView();
                
                
                
            }
        }


        public void LoadDataGridView()
        {
            dataGridViewDanhSachDaChon.DataSource = "";
            dataGridViewDanhSachDaChon.DataSource = lstGioHang;

            
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            for (int i = 0; i < lstGioHang.Count; i++)
            {
                tongtien += lstGioHang[i].GiaBan * lstGioHang[i].SoLuong;
            }
            txtTongTienHang.Text = tongtien+"";
            txtKhachCanTra.Text = (tongtien - (int.Parse(txtGiamGia.Text)))+"";
            DateTime time = DateTime.Now;
            String nv = TaiKhoanHienTai.TaiKhoan1;
            int maKhachHang = 1;
            GioHang.TaoHoaDon(nv, time, maKhachHang, tongtien);
        }


        
    }
}
