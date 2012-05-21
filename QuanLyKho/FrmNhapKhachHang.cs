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
    public partial class FrmNhapKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        DataProvider dp = new DataProvider();
        KhachHangDAL dalKhachHang = new KhachHangDAL();
        KhachHangDTO dtoKhachHang = new KhachHangDTO();
        CFunction cf = new CFunction();
        public FrmNhapKhachHang()
        {
            InitializeComponent();
        }
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            string strAction = btnThemKhachHang.Tag.ToString();
            if (strAction == "add")
            {
                dtoKhachHang.MaKH = cf.CreateId("KHA", "KHACHHANG");
                dtoKhachHang.TenKH = txtTenKhachHang.Text;
                dtoKhachHang.SoTaiKhoan = txtSoTaiKhoan.Text;
                dtoKhachHang.NganHang = txtNganHang.Text;
                dtoKhachHang.MaSoThue = txtMaSoThue.Text;
                dtoKhachHang.DiaChi = txtDiaChi.Text;
                dtoKhachHang.SDT = txtDienThoai.Text;
                dtoKhachHang.Email = txtEmail.Text;
                dtoKhachHang.GhiChu = txtGhiChu.Text;
                dalKhachHang.InsertKhachHang(dtoKhachHang);
                //Load Khách Hàng Sau Khi Nhập                
                MessageBox.Show("Thêm Khách Hàng Thành Công!","Thêm Khách Hàng",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string strMaKH = txtMaKH.Text;
                dtoKhachHang.MaKH = strMaKH;
                dtoKhachHang.TenKH = txtTenKhachHang.Text;
                dtoKhachHang.SoTaiKhoan = txtSoTaiKhoan.Text;
                dtoKhachHang.NganHang = txtNganHang.Text;
                dtoKhachHang.MaSoThue = txtMaSoThue.Text;
                dtoKhachHang.DiaChi = txtDiaChi.Text;
                dtoKhachHang.SDT = txtDienThoai.Text;
                dtoKhachHang.Email = txtEmail.Text;
                dtoKhachHang.GhiChu = txtGhiChu.Text;
                dalKhachHang.UpdateKH(dtoKhachHang);
                MessageBox.Show("Cập nhật Khách Hàng Thành Công!","Cập Nhật Khách Hàng",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
    }
}