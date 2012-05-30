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
    public partial class FrmNhapNCC : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapNCC()
        {
            InitializeComponent();
        }
        
        NhaCungCapBLL bllNhaCC = new NhaCungCapBLL();
        CFunction cf = new CFunction();
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCapDTO dtoNhaCC = new NhaCungCapDTO();
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
                    string strRusult = bllNhaCC.InsertNhaCungCap(dtoNhaCC);
                    if (strRusult == "ok")
                    {
                        MessageBox.Show("Thêm Nhà Cung Cấp Thành Công!", "Thêm Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strRusult, "Thêm Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    string strRusult = bllNhaCC.UpdateNhaCungCap(dtoNhaCC);
                    if (strRusult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Nhà Cung Cấp Thành Công!", "Cập Nhật Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strRusult, "Cập Nhật Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch { }
        }
    }
}