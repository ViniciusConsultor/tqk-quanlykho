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
    public partial class FrmNhapKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        KhachHangBLL bllKhachHang = new KhachHangBLL();
        CFunction cf = new CFunction();
        public FrmNhapKhachHang()
        {
            InitializeComponent();
        }
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string strAction = btnThemKhachHang.Tag.ToString();
                if (strAction == "add")
                {
                    KhachHangDTO dtoKhachHang = new KhachHangDTO();
                    dtoKhachHang.MaKH = cf.CreateId("KHA", "KHACHHANG");
                    dtoKhachHang.TenKH = txtTenKhachHang.Text;
                    dtoKhachHang.SoTaiKhoan = txtSoTaiKhoan.Text;
                    dtoKhachHang.NganHang = txtNganHang.Text;
                    dtoKhachHang.MaSoThue = txtMaSoThue.Text;
                    dtoKhachHang.DiaChi = txtDiaChi.Text;
                    dtoKhachHang.SDT = txtDienThoai.Text;
                    dtoKhachHang.Email = txtEmail.Text;
                    dtoKhachHang.GhiChu = txtGhiChu.Text;
                    string strResult = bllKhachHang.InsertKhachHang(dtoKhachHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Thêm Khách Hàng Thành Công!", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    KhachHangDTO dtoKhachHang = new KhachHangDTO();
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
                    string strResult = bllKhachHang.UpdateKH(dtoKhachHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập nhật Khách Hàng Thành Công!", "Cập Nhật Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Cập Nhật Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            
        }

    }
}