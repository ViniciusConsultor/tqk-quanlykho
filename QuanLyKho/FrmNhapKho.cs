using System;
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
    }
}