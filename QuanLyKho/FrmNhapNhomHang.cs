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
    public partial class FrmNhapNhomHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapNhomHang()
        {
            InitializeComponent();
        }
        NhomHangBLL bllNhomHang = new NhomHangBLL();
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                NhomHangDTO dtoNhomHang = new NhomHangDTO();
                string strAction = btnOK.Tag.ToString();
                if (strAction == "add")
                {
                    dtoNhomHang.MaNH = txtMaNhom.Text;
                    dtoNhomHang.TenNhomHang = txtTenNhom.Text;
                    dtoNhomHang.GhiChu = txtGhiChu.Text;
                    string strResult = bllNhomHang.InsertNhomHang(dtoNhomHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Thêm Thành Công!", "Thêm Nhóm Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Nhóm Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    dtoNhomHang.MaNH = txtMaNhom.Text;
                    dtoNhomHang.TenNhomHang = txtTenNhom.Text;
                    dtoNhomHang.GhiChu = txtGhiChu.Text;
                    string strResult = bllNhomHang.UpdateNhomHang(dtoNhomHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Nhóm Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Cập Nhật Nhóm Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}