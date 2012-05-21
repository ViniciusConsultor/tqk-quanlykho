using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using DAL;
namespace QuanLyKho
{
    public partial class FrmNhapNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        DataProvider dp = new DataProvider();
        BoPhanDAL dalBoPhan = new BoPhanDAL();
        NhanVienDTO dtoNhanVien = new NhanVienDTO();
        NhanVienDAL dalNhanVien = new NhanVienDAL();
        CFunction cf = new CFunction();
        public FrmNhapNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhapNhanVien_Load(object sender, EventArgs e)
        {
            cmbBoPhan.DataSource = dalBoPhan.GetBoPhan();
            cmbBoPhan.ValueMember = "MABOPHAN";
            cmbBoPhan.DisplayMember = "TENBOPHAN";
            cmbChucVu.DataSource = dalNhanVien.GetNhanVien();
            cmbChucVu.DisplayMember = "CHUCVU";
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            string strAction = btnThemNhanVien.Tag.ToString();
            if (strAction == "Insert")
            {
                string strMaNV = cf.CreateId("MANV", "NHANVIEN");
                dtoNhanVien.MaNV = strMaNV;
                dtoNhanVien.TenNV = txtTenNhanVien.Text;
                dtoNhanVien.MaBP = cmbBoPhan.SelectedValue.ToString();
                dtoNhanVien.ChucVu = cmbChucVu.Text;
                dtoNhanVien.MatKhau = "12345";
                dtoNhanVien.NgaySinh = dtNgaySinh.Value;
                dtoNhanVien.SoDT = txtDienThoai.Text;
                dtoNhanVien.CMND = txtCMND.Text;
                dtoNhanVien.DiaChi = txtDiaChi.Text;
                dalNhanVien.InsertNhanVien(dtoNhanVien);
                MessageBox.Show("Thêm Nhân Viên Thành Công!", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                
            }
        }
    }
}