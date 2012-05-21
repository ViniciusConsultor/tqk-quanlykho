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
    public partial class FrmNhapNCC : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapNCC()
        {
            InitializeComponent();
        }
        NhaCungCapDTO dtoNhaCC = new NhaCungCapDTO();
        NhaCungCapDAL dalNhaCC = new NhaCungCapDAL();
        CFunction cf = new CFunction();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string strAction = btnThem.Tag.ToString();
            if (strAction == "add")
            {
                dtoNhaCC.MaNCC = txtMaNCC.Text;
                dtoNhaCC.TenNCC = txtTenNCC.Text;
                dtoNhaCC.DiaChi = txtDiaChi.Text;
                dtoNhaCC.MaSoThue = txtMaSoThue.Text;
                dtoNhaCC.SoTaiKhoan = txtSoTaiKhoan.Text;
                dtoNhaCC.NganHang = txtNganHang.Text;
                dtoNhaCC.SoDienThoai = txtDienThoai.Text;
                dtoNhaCC.Email = txtEmail.Text;
                dtoNhaCC.GhiChu = txtGhiChu.Text;
                dalNhaCC.InsertNhaCungCap(dtoNhaCC);
                MessageBox.Show("Thêm Nhà Cung Cấp Thành Công!", "Thêm Nhà Cung Cấp", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dtoNhaCC.MaNCC = txtMaNCC.Text;
                dtoNhaCC.TenNCC = txtTenNCC.Text;
                dtoNhaCC.DiaChi = txtDiaChi.Text;
                dtoNhaCC.MaSoThue = txtMaSoThue.Text;
                dtoNhaCC.SoTaiKhoan = txtSoTaiKhoan.Text;
                dtoNhaCC.NganHang = txtNganHang.Text;
                dtoNhaCC.SoDienThoai = txtDienThoai.Text;
                dtoNhaCC.Email = txtEmail.Text;
                dtoNhaCC.GhiChu = txtGhiChu.Text;
                dalNhaCC.UpdateNhaCungCap(dtoNhaCC);
                MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            
            }
        }
    }
}