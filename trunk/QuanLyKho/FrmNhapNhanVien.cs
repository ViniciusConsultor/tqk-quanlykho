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
                dtNgaySinh.Text = DateTime.Today.ToShortDateString();
                cmbBoPhan.Text = cmbBoPhan.Tag.ToString();
                cmbChucVu.Text = cmbChucVu.Tag.ToString();
            }
            catch { }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                string strAction = btnThemNhanVien.Tag.ToString();
                if (strAction == "add")
                {
                    NhanVienDTO dtoNhanVien = new NhanVienDTO();
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
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    NhanVienDTO dtoNhanVien = new NhanVienDTO();
                    dtoNhanVien.MaNV = txtMaNV.Text;
                    dtoNhanVien.TenNV = txtTenNhanVien.Text;
                    dtoNhanVien.MaBP = cmbBoPhan.SelectedValue.ToString();
                    dtoNhanVien.ChucVu = cmbChucVu.Text;
                    dtoNhanVien.NgaySinh = dtNgaySinh.Value.ToShortDateString();
                    dtoNhanVien.SoDT = txtDienThoai.Text;
                    dtoNhanVien.CMND = txtCMND.Text;
                    dtoNhanVien.DiaChi = txtDiaChi.Text;
                    string strResult = bllNhanVien.UpdateNhanVien(dtoNhanVien);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Nhân Viên Thành Công!", "Cập Nhật Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}