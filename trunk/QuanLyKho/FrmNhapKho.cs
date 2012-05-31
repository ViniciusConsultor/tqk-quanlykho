﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;
using DTO;


namespace QuanLyKho
{
    public partial class FrmNhapKho : DevComponents.DotNetBar.Office2007Form
    {

        CFunction cf = new CFunction();
        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        MatHangBLL bllMatHang = new MatHangBLL();
        DonViTinhBLL bllDonVITinh = new DonViTinhBLL();
        NhapKhoBLL bllNhapKho = new NhapKhoBLL();
        MucThueBLL bllMucThue = new MucThueBLL();


        public FrmNhapKho()
        {
            InitializeComponent();
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {

            try
            {
                string strMaNhapKho = cf.CreateId("MAHDN", "NHAPKHO");
                txtMaPhieuNhap.Text = strMaNhapKho;
                string strMaNhanVien = Variable.strMaNhanVien;
                if (strMaNhanVien == "")
                    strMaNhanVien = "Chưa đăng nhập";
                txtMaNhanVien.Text = strMaNhanVien;

                dtNgayLap.Text = DateTime.Now.ToShortDateString();
                dtNgayNhap.Text = DateTime.Now.ToShortDateString();

                cmbMaNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
                cmbMaNhaCungCap.DisplayMember = "MANHACUNGCAP";
                cmbMaNhaCungCap.ValueMember = "MANHACUNGCAP";

                cmbTenNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
                cmbTenNhaCungCap.DisplayMember = "TENNHACUNGCAP";
                cmbTenNhaCungCap.ValueMember = "MANHACUNGCAP";

                colMaMatHang.DataSource = bllMatHang.GetAllMatHang();
                colMaMatHang.DisplayMember = "MAMATHANG";
                colMaMatHang.ValueMember = "MAMATHANG";

                colTenMatHang.DataSource = bllMatHang.GetAllMatHang();
                colTenMatHang.DisplayMember = "TENMATHANG";
                colTenMatHang.ValueMember = "MAMATHANG";

                colDonViTinh.DataSource = bllDonVITinh.GetDonViTinh();
                colDonViTinh.DisplayMember = "DONVITINH";
                colDonViTinh.ValueMember = "MADONVITINH";

                colMucThue.DataSource = bllMucThue.GetMucThue();
                colMucThue.DisplayMember = "SOTHUE";
                colMucThue.ValueMember = "MATHUE";

            }
            catch { }
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
            frmNhapNCC.btnThem.Tag = "add";
            string strMaNCC = cf.CreateId("CCA", "NHACUNGCAP");
            frmNhapNCC.txtMaNCC.Text = strMaNCC;
            frmNhapNCC.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //rptNhanKho 
        }

        private void cmbMaNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDNhaCungCap = cmbMaNhaCungCap.SelectedValue.ToString();
                int intIndexSelect = cmbMaNhaCungCap.SelectedIndex;
                NhaCungCapDTO dtoNhaCungCap = bllNhaCungCap.GetNhaCungCapByID(strIDNhaCungCap);
                txtDiaChi.Text = dtoNhaCungCap.DiaChi;
                txtDienThoai.Text = dtoNhaCungCap.SoDienThoai;
                txtMaSoThue.Text = dtoNhaCungCap.MaSoThue;
                cmbTenNhaCungCap.SelectedIndex = intIndexSelect;
            }
            catch {
                cmbMaNhaCungCap.SelectedIndex = 0;
            }
        }

        private void cmbTenNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDNhaCungCap = cmbTenNhaCungCap.SelectedValue.ToString();
                int intIndexSelect = cmbTenNhaCungCap.SelectedIndex;
                NhaCungCapDTO dtoNhaCungCap = bllNhaCungCap.GetNhaCungCapByID(strIDNhaCungCap);
                txtDiaChi.Text = dtoNhaCungCap.DiaChi;
                txtDienThoai.Text = dtoNhaCungCap.SoDienThoai;
                txtMaSoThue.Text = dtoNhaCungCap.MaSoThue;
                cmbMaNhaCungCap.SelectedIndex = intIndexSelect;
            }
            catch { }
        }

        private void dgvMatHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int intIndexColumn = dgvMatHang.CurrentCell.ColumnIndex;
                int intIndexRow = dgvMatHang.CurrentRow.Index;
                if (intIndexColumn == 0 || intIndexColumn == 1)
                {
                    string strMaMatHang = dgvMatHang.CurrentCell.Value.ToString();
                    MatHangDTO dtoMatHang = new MatHangDTO();
                    dtoMatHang = bllMatHang.GetMatHangByID(strMaMatHang);
                    dgvMatHang.Rows[intIndexRow].Cells["colMaMatHang"].Value = dtoMatHang.MaMH;
                    dgvMatHang.Rows[intIndexRow].Cells["colTenMatHang"].Value = dtoMatHang.TenMH;
                    dgvMatHang.Rows[intIndexRow].Cells["colDonViTinh"].Value = dtoMatHang.MaDonViTinh;
                    
                }
            }
            catch { }
        }

        private void btnLuuKho_Click(object sender, EventArgs e)
        {
            NhapKhoDTO dtoNhapKho = new NhapKhoDTO();
            dtoNhapKho.GhiChu = txtGhiChu.Text;
            dtoNhapKho.MaNCC = cmbMaNhaCungCap.Text;
            dtoNhapKho.MaNV = txtMaNhanVien.Text;
            dtoNhapKho.NgayLapHD = dtNgayLap.Value.ToShortDateString();
            dtoNhapKho.NgayNhap = dtNgayNhap.Value.ToShortDateString();
            dtoNhapKho.SoHoaDon = txtSoHoaDon.Text;
            dtoNhapKho.NguoiNhan = txtNguoiNhan.Text;
            dtoNhapKho.LyDoNhap = txtLyDoNhap.Text;
            string strNhapKho = bllNhapKho.InsertNhapKho(dtoNhapKho);
            if (strNhapKho != "ok")
            {
                MessageBox.Show(strNhapKho);
            }
            else
            { 
                
            }
        }
    }
}