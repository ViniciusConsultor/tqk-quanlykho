﻿using System;
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
    public partial class FrmKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        KhachHangBLL bllKhachHang = new KhachHangBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private  void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();

        }

        public void LoadKhachHang()
        {
            try
            {
                DataTable dtKhachHang = new DataTable();
                dtKhachHang = bllKhachHang.GetAllKhachHang();
                dtKhachHang = cf.AutoNumberedTable(dtKhachHang);
                dgvKhachHang.AutoGenerateColumns = false;
                dgvKhachHang.DataSource = dtKhachHang;
                intRowCount = dgvKhachHang.Rows.Count;
            }
            catch { }

        }
        public void LayID()
        {
            try
            {
                int index = dgvKhachHang.SelectedRows[0].Index;
                string strMaKH = dgvKhachHang.Rows[index].Cells["colMaKhachHang"].Value.ToString();
            }
            catch { }
        }
    
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapKhachHang frmNhapKhachHang = new FrmNhapKhachHang();
                frmNhapKhachHang.btnThemKhachHang.Tag = "add";
                string strMaKH = cf.CreateId("KHA", "KHACHHANG");
                frmNhapKhachHang.txtMaKH.Text = strMaKH.ToString();
                frmNhapKhachHang.ShowDialog();
                LoadKhachHang();
            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapKhachHang frmNhapKhachHang = new FrmNhapKhachHang();
                frmNhapKhachHang.btnThemKhachHang.Tag = "up";
                int index = dgvKhachHang.SelectedRows[0].Index;
                string strMaKH = dgvKhachHang.Rows[index].Cells["colMaKhachHang"].Value.ToString();
                frmNhapKhachHang.txtMaKH.Text = strMaKH;
                string strTen = dgvKhachHang.Rows[index].Cells["colTenKhachHang"].Value.ToString();
                frmNhapKhachHang.txtTenKhachHang.Text = strTen;

                string strSoTaiKhoan = dgvKhachHang.Rows[index].Cells["colSoTaiKhoan"].Value.ToString();
                if (strSoTaiKhoan == "")
                {
                    strSoTaiKhoan = " Không có thông tin.";
                    frmNhapKhachHang.txtSoTaiKhoan.Text = strSoTaiKhoan;
                }
                else
                {
                    frmNhapKhachHang.txtSoTaiKhoan.Text = strSoTaiKhoan;
                }
                string strNganHang = dgvKhachHang.Rows[index].Cells["colNganHang"].Value.ToString();
                if (strNganHang == "")
                {
                    strNganHang = " Không có thông tin.";
                    frmNhapKhachHang.txtNganHang.Text = strNganHang;
                }
                else
                {
                    frmNhapKhachHang.txtNganHang.Text = strNganHang;
                }
                string strMaSoThue = dgvKhachHang.Rows[index].Cells["colMaSoThue"].Value.ToString();
                if (strMaSoThue == "")
                {
                    strMaSoThue = " Không có thông tin.";
                    frmNhapKhachHang.txtMaSoThue.Text = strMaSoThue;
                }
                else
                {
                    frmNhapKhachHang.txtMaSoThue.Text = strMaSoThue;
                }
                int intSoDienThoai = 0;
                if (dgvKhachHang.Rows[index].Cells["colSoDienThoai"].Value.ToString() == "")
                {
                    intSoDienThoai = 0000000;
                }
                else 
                {
                    intSoDienThoai = int.Parse(dgvKhachHang.Rows[index].Cells["colSoDienThoai"].Value.ToString());
                    frmNhapKhachHang.txtDienThoai.Value = intSoDienThoai;
                }
                string strEmail = dgvKhachHang.Rows[index].Cells["colEmail"].Value.ToString();
                if (strEmail == "")
                {
                    strEmail = " Không có thông tin.";
                    frmNhapKhachHang.txtEmail.Text = strEmail;
                }
                else
                {
                    frmNhapKhachHang.txtEmail.Text = strEmail;
                }
                string strDiaChi = dgvKhachHang.Rows[index].Cells["colDiaChi"].Value.ToString();
                if (strDiaChi == "")
                {
                    strDiaChi = " Không có thông tin.";
                    frmNhapKhachHang.txtDiaChi.Text = strDiaChi;
                }
                else
                {
                    frmNhapKhachHang.txtDiaChi.Text = strDiaChi;
                }
                string strGhiChu = dgvKhachHang.Rows[index].Cells["colGhiChu"].Value.ToString();
                if (strGhiChu == "")
                {
                    strGhiChu = " Không có thông tin.";
                    frmNhapKhachHang.txtGhiChu.Text = strGhiChu;
                }
                else
                {
                    frmNhapKhachHang.txtGhiChu.Text = strGhiChu;
                }
                frmNhapKhachHang.ShowDialog();
                LoadKhachHang();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKhachHang.SelectedRows[0].Index;
                string strMaKH = dgvKhachHang.Rows[index].Cells["colMaKhachHang"].Value.ToString();
                if (MessageBox.Show("Bạn Chắc Muốn Xóa Khách Hàng Này!", "Xóa Khách Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    dgvKhachHang.Rows.RemoveAt(index);
                    bllKhachHang.DelKhachHang(strMaKH);
                    MessageBox.Show("Xóa Thành Công!", "Xóa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (intIndex > 0)
                {
                    intIndex--;
                    dgvKhachHang.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = 0;
                dgvKhachHang.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (intIndex < intRowCount - 1)
                {
                    intIndex++;
                    dgvKhachHang.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = intRowCount - 1;
                dgvKhachHang.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                intIndex = dgvKhachHang.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1).ToString() + "/" + intRowCount.ToString();
            }
            catch { }
        }
    }
}