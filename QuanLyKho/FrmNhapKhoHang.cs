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
    public partial class FrmNhapKhoHang : DevComponents.DotNetBar.Office2007Form
    {
        KhoHangBLL bllKhoHang = new KhoHangBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        CFunction cf = new CFunction();
        public FrmNhapKhoHang()
        {
            InitializeComponent();
        }
        
        private void FrmNhapKhoHang_Load(object sender, EventArgs e)
        {
            try
            {
                cmbNhanVien.DataSource = bllNhanVien.GetNhanVien();
                cmbNhanVien.DisplayMember = "TENNHANVIEN";
                cmbNhanVien.ValueMember = "MANHANVIEN";
                cmbNhanVien.Tag = cmbNhanVien.Tag.ToString();
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                KhoHangDTO dtoKhoHang = new KhoHangDTO();
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
                    string strResult = bllKhoHang.InsertKhoHang(dtoKhoHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Thêm Thành Công!", "Thêm Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dtoKhoHang.MaKho = txtMaKho.Text;
                    dtoKhoHang.TenKho = txtTenKho.Text;
                    dtoKhoHang.SDTB = txtDienThoaiBan.Text;
                    dtoKhoHang.DTDD = txtDienThoaiDD.Text;
                    dtoKhoHang.NguoiLH = cmbNhanVien.SelectedValue.ToString();
                    dtoKhoHang.Fax = txtFax.Text;
                    dtoKhoHang.DiaChi = txtDiaChi.Text;
                    dtoKhoHang.GhiChu = txtGhiChu.Text;
                    string strResult = bllKhoHang.UpdateKhoHang(dtoKhoHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Cập Nhật Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}