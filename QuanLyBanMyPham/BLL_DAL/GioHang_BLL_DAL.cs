using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL_DAL
{
    
    public class GioHang_BLL_DAL
    {
        QLMyPhamDataContext QLMP = new QLMyPhamDataContext();
        public GioHang_BLL_DAL()
        {

        }

        public IQueryable getAllSanPham()
        {
            return from sp in QLMP.SanPhams select new { sp.MaSP, sp.TenSP, sp.GiaBanSP, sp.MoTaSP };
        }

        public SanPham getSanPhamTheoMa(int maSP)
        {
            SanPham s = new SanPham();
            var sanpham = from sp in QLMP.SanPhams where( sp.MaSP==maSP) select new { sp.MaSP, sp.TenSP, sp.GiaBanSP, sp.MoTaSP };
            foreach (var ss in sanpham)
            {
                s.MaSP = ss.MaSP;
                s.TenSP = ss.TenSP;
                s.MoTaSP = ss.MoTaSP;
                s.GiaBanSP = ss.GiaBanSP;
            }
            return s;
        }

        public void TaoHoaDon(String TaiKhoanNhanVien,DateTime NgayBan,int MaKH,Decimal TongTien)
        {
            HoaDon hd = new HoaDon();
            hd.TaiKhoan = TaiKhoanNhanVien;
            hd.NgayBan = NgayBan;
            hd.MaKH = MaKH;
            hd.TongTien = TongTien;

            QLMP.HoaDons.InsertOnSubmit(hd);
            QLMP.SubmitChanges();
        }

        public void TaoChiTietHoaDon()
        {

        }
    }
}
