using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;

namespace QuanLyKho
{
    public partial class FrmTCXuatHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmTCXuatHang()
        {
            InitializeComponent();
        }
        CFunction cf = new CFunction();
        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        MatHangBLL bllMatHang = new MatHangBLL();
        DonViTinhBLL bllDonVITinh = new DonViTinhBLL();
        NhapKhoBLL bllNhapKho = new NhapKhoBLL();
        MucThueBLL bllMucThue = new MucThueBLL();
        private void FrmTCXuatHang_Load(object sender, EventArgs e)
        {
            dtTuNgay.Text = DateTime.Now.ToShortDateString();
            dtDenNgay.Text = DateTime.Now.ToShortDateString();

            cmbMatHang.DataSource = bllMatHang.GetAllMatHang();
            cmbMatHang.DisplayMember = "TENMATHANG";
            cmbMatHang.ValueMember = "MAMATHANG";

            cmbNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
            cmbNhaCungCap.DisplayMember = "TENNHACUNGCAP";
            cmbNhaCungCap.ValueMember = "MANHACUNGCAP";
        }
    }
}