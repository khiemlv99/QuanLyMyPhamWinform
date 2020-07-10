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
namespace GUI
{
    public partial class frmThemTaiKhoan : Form
    {
        CapNhatTaiKhoan_BLL_DAL taikhoan = new CapNhatTaiKhoan_BLL_DAL();
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
          
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            loadCbo();
        }

        public void loadCbo()
        {
            cboChucVu.DataSource = taikhoan.LoadcboChucVu();
            cboChucVu.ValueMember = "MaNhomNV";
            cboChucVu.DisplayMember = "TenNhomNV";
        }

        private void btnUploadPicture_Click_1(object sender, EventArgs e)
        {
            taikhoan.uploadHinhAnh(pictureBox1);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (taikhoan.kiemTrakhoachinh(txtTaiKhoan.Text.Trim()))
            {
                taikhoan.ThemTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text, txtDiaChi.Text, int.Parse(cboChucVu.SelectedValue.ToString()), pictureBox1);
            }
            else
                MessageBox.Show("Tài khoản đã tồn tại");
        }
    }
}
