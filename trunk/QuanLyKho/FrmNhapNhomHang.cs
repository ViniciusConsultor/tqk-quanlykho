﻿using System;
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
    public partial class FrmNhapNhomHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapNhomHang()
        {
            InitializeComponent();
        }
        NhomHangDAL dalNhomHang = new NhomHangDAL();
        private void btnOK_Click(object sender, EventArgs e)
        {
            NhomHangDTO dtoNhomHang = new NhomHangDTO();
            string strAction = btnOK.Tag.ToString();
            if (strAction == "add")
            {
                dtoNhomHang.MaNH = txtMaNhom.Text;
                dtoNhomHang.TenNhomHang = txtTenNhom.Text;
                dtoNhomHang.GhiChu = txtGhiChu.Text;
                dalNhomHang.InsertNhomHang(dtoNhomHang);
                MessageBox.Show("Thêm Thành Công!", "Thêm Nhóm Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                dtoNhomHang.MaNH = txtMaNhom.Text;
                dtoNhomHang.TenNhomHang = txtTenNhom.Text;
                dtoNhomHang.GhiChu = txtGhiChu.Text;
                dalNhomHang.UpdateNhomHang(dtoNhomHang);
                MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Nhóm Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}