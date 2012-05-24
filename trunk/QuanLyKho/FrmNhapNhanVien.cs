using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using BLL;
namespace QuanLyKho
{
    public partial class FrmNhapNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        BoPhanBLL dalBoPhan = new BoPhanBLL();
        NhanVienDTO dtoNhanVien = new NhanVienDTO();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        CFunction cf = new CFunction();
        public FrmNhapNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhapNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                cmbBoPhan.DataSource = dalBoPhan.GetBoPhan();
                cmbBoPhan.ValueMember = "MABOPHAN";
                cmbBoPhan.DisplayMember = "TENBOPHAN";
                cmbChucVu.DataSource = bllNhanVien.GetNhanVien();
                cmbChucVu.DisplayMember = "CHUCVU";
                cmbBoPhan.Text = cmbBoPhan.Tag.ToString();
                cmbChucVu.Text = cmbChucVu.Tag.ToString();
            }
            catch { }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            string strAction = btnThemNhanVien.Tag.ToString();
            if (strAction == "add")
            {
                string strMaNV = cf.CreateId("MANV", "NHANVIEN");
                dtoNhanVien.MaNV = strMaNV;
                dtoNhanVien.TenNV = txtTenNhanVien.Text;
                dtoNhanVien.MaBP = cmbBoPhan.SelectedValue.ToString();
                dtoNhanVien.ChucVu = cmbChucVu.Text;
                dtoNhanVien.MatKhau = "12345";
                dtoNhanVien.NgaySinh = dtNgaySinh.Value.ToShortDateString();
                dtoNhanVien.SoDT = txtDienThoai.Text;
                dtoNhanVien.CMND = txtCMND.Text;
                dtoNhanVien.DiaChi = txtDiaChi.Text;
                string strResult = bllNhanVien.InsertNhanVien(dtoNhanVien);
                if (strResult == "ok")
                {
                    MessageBox.Show("Thêm Nhân Viên Thành Công!", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(strResult, "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            { 
                
            }
        }
    }
}