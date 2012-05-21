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
    public partial class FrmNhapKhoHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapKhoHang()
        {
            InitializeComponent();
        }

        KhoHangDTO dtoKhoHang = new KhoHangDTO();
        KhoHangDAL dalKhoHang = new KhoHangDAL();
        NhanVienDAL dalNhanVien = new NhanVienDAL();
        CFunction cf = new CFunction();

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strAction = btnOK.Tag.ToString();
            if (strAction == "add")
            {
                dtoKhoHang.MaKho = txtMaKho.Text;
                dtoKhoHang.TenKho = txtTenKho.Text;
                dtoKhoHang.SDTB = txtDienThoaiBan.Text;
                dtoKhoHang.DTDD = txtDienThoaiDD.Text;
                dtoKhoHang.NguoiLH = cmbNhanVien.SelectedValue.ToString();
                dtoKhoHang.Fax = txtFax.Text;
                dtoKhoHang.DiaChi = txtDiaChi.Text;
                dtoKhoHang.GhiChu = txtGhiChu.Text;
                dalKhoHang.InsertKhoHang(dtoKhoHang);
                MessageBox.Show("Thêm Thành Công!", "Thêm Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dtoKhoHang.MaKho = txtMaKho.Text;
                dtoKhoHang.TenKho = txtTenKho.Text;
                dtoKhoHang.SDTB = txtDienThoaiBan.Text;
                dtoKhoHang.DTDD = txtDienThoaiDD.Text;
                dtoKhoHang.NguoiLH = cmbNhanVien.Text;
                dtoKhoHang.Fax = txtFax.Text;
                dtoKhoHang.DiaChi = txtDiaChi.Text;
                dtoKhoHang.GhiChu = txtGhiChu.Text;
                dalKhoHang.UpdateKhoHang(dtoKhoHang);
                MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FrmNhapKhoHang_Load(object sender, EventArgs e)
        {
            cmbNhanVien.DataSource = dalNhanVien.GetNhanVien();
            cmbNhanVien.DisplayMember = "TENNHANVIEN";
            cmbNhanVien.ValueMember = "MANHANVIEN";
        }
    }
}