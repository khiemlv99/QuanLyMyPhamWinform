using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DanhMuc_BLL
    {
        QLMyPhamDataContext qlmypham = new QLMyPhamDataContext();
        public DanhMuc_BLL() { }

        public void getDataLoaiSP(ListBox lst)
        {
            var sps = from sp in qlmypham.NhomSPs select new { sp.MaNhomSP, sp.TenNhomSP };
            lst.DataSource = sps;
        }

        public void getDataSanPhamForGridView(int masp, DataGridView da)
        {
            var sps = from sp in qlmypham.SanPhams.Where(t => t.MaNhomSP == masp) select new { sp.MaSP, sp.TenSP, sp.MaNhomSP, sp.GiaNhapSP, sp.GiaBanSP, sp.MoTaSP, sp.HinhAnh };
            da.DataSource = sps;
        }

        public void themLoaiSanPham(string tenloai)
        {
            NhomSP nhom = new NhomSP();
            nhom.TenNhomSP = tenloai;
            qlmypham.NhomSPs.InsertOnSubmit(nhom);
            qlmypham.SubmitChanges();
        }

        public void xoaLoaiSanPham(int maloai)
        {
            var loais = qlmypham.NhomSPs.Where(t => t.MaNhomSP == maloai).FirstOrDefault();
            var sp = qlmypham.SanPhams.Where(t1 => t1.MaNhomSP == maloai).FirstOrDefault();
            if (sp == null && loais != null)
            {
                qlmypham.NhomSPs.DeleteOnSubmit(loais);
                qlmypham.SubmitChanges();
                MessageBox.Show("Xóa thành công nhé!");
            }
            else 
            {
                MessageBox.Show("Sản phẩm còn hàng nên không được xóa đâu nhé");
            }
        }

        public void themSanPham(int masp, string tensp, int manhomsp, int gianhap, int giasuat, string mota)
        {
            SanPham sp = qlmypham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
            if (sp == null)
            {
                SanPham sanpham = new SanPham();
                sanpham.TenSP = tensp;
                sanpham.MaNhomSP = manhomsp;
                sanpham.GiaNhapSP = gianhap;
                sanpham.GiaBanSP = giasuat;
                sanpham.MoTaSP = mota;

                qlmypham.SanPhams.InsertOnSubmit(sanpham);
                qlmypham.SubmitChanges();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo vui!");
            }

            else 
            {
                SanPham spp = qlmypham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
                spp.GiaBanSP = giasuat;                
                qlmypham.SubmitChanges();
                MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo vui!");

            }
            qlmypham.SubmitChanges();
            

        }

        public void xoaSanPham(int masp)
        {
            SanPham sp = qlmypham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
            if(sp != null)
            {
                qlmypham.SanPhams.DeleteOnSubmit(sp);
                qlmypham.SubmitChanges();
            }
        }

        public bool ktraSanPham()
        {
            var sp = from k in qlmypham.SanPhams select k;
            if (sp != null)
                return false;
            return true;
        }

    }
}
