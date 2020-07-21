using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class CapNhatTaiKhoan_BLL_DAL
    {
        QLMyPhamDataContext qlmp = new QLMyPhamDataContext();
        public void ShowTaiKhoan(DataGridView datagrid)
        {
            var TK = from t in qlmp.TaiKhoans join tk in qlmp.NhomNVs on t.MaNhomNV equals tk.MaNhomNV where (t.MaNhomNV == tk.MaNhomNV) select new { t.MaNhomNV, t.HoTenNV, t.MatKhau, t.DiaChi,tk.TenNhomNV };
            datagrid.DataSource = TK;
        }

        public IQueryable<NhomNV> LoadcboChucVu()
        {
            var cv = from c in qlmp.NhomNVs select c;
            return cv;
        }

        public void uploadHinhAnh(PictureBox picture)
        {
            // open file dialog
            string imagelocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imagelocation = open.FileName;

                    picture.ImageLocation = imagelocation;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi hình ảnh");
            }
        }

        public void ThemTaiKhoan(string TaiKhoan,string MatKhau,string Hoten,string DiaChi,int MaNhom,PictureBox picture)
        {
            MemoryStream stream = new MemoryStream();
            picture.Image.Save(stream,ImageFormat.Jpeg);
            TaiKhoan tk = new TaiKhoan();
            tk.TaiKhoan1 = TaiKhoan;
            tk.MatKhau=MatKhau;
            tk.HoTenNV=Hoten;
            tk.DiaChi=DiaChi;
            tk.MaNhomNV=MaNhom;
          //  tk.HinhAnh = stream.ToArray();

            qlmp.TaiKhoans.InsertOnSubmit(tk);
            qlmp.SubmitChanges();
        }

        public bool kiemTrakhoachinh(string TaiKhoan)
        {
           TaiKhoan SV = qlmp.TaiKhoans.Where(t => t.TaiKhoan1 == TaiKhoan).FirstOrDefault();
            if (SV == null)
                return true;
            return false;
        }

        public void loadDuLieuTaiKhoanHienTai(string taikhoan)
        {
           TaiKhoan SV = qlmp.TaiKhoans.Where(t => t.TaiKhoan1 == taikhoan).Select(t1=>t1).FirstOrDefault();
            TaiKhoanHienTai.TaiKhoan1 = SV.TaiKhoan1;
            TaiKhoanHienTai.DiaChi1 = SV.DiaChi;
            //TaiKhoanHienTai.HinhAnh1 = SV.HinhAnh;
            TaiKhoanHienTai.HoTen1 = SV.HoTenNV;

        }

        public void loadDuLieu(Label lblHoTen,Label lblDiaChi,PictureBox picture)
        {
            MemoryStream memory = new MemoryStream(TaiKhoanHienTai.HinhAnh1.ToArray());
            Image image = Image.FromStream(memory);
            if(image==null)
            {
                MessageBox.Show("Không có hình");
                return;
            }
            picture.Image = image;
            lblHoTen.Text = TaiKhoanHienTai.HoTen1;
            lblDiaChi.Text = TaiKhoanHienTai.DiaChi1;

        }
    }
}
