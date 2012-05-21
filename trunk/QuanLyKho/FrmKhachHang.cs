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
    public partial class FrmKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        KhachHangDAL dalKhachHang = new KhachHangDAL();
        CFunction cf = new CFunction();

        private  void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();

        }

        private void LoadKhachHang()
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = dalKhachHang.GetAllKhachHang();
            dtKhachHang = cf.AutoNumberedTable(dtKhachHang);
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = dtKhachHang;
        }
        public void LayID()
        {
            int index = dgvKhachHang.SelectedRows[0].Index;
            string strMaKH = dgvKhachHang.Rows[index].Cells["colMaKhachHang"].Value.ToString();
        }
    
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapKhachHang frmNhapKhachHang = new FrmNhapKhachHang();
            frmNhapKhachHang.btnThemKhachHang.Tag = "add";
            string strMaKH = cf.CreateId("KHA", "KHACHHANG");
            frmNhapKhachHang.txtMaKH.Text = strMaKH.ToString();
            frmNhapKhachHang.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapKhachHang frmNhapKhachHang = new FrmNhapKhachHang();
            frmNhapKhachHang.btnThemKhachHang.Tag = "up";
            int index = dgvKhachHang.SelectedRows[0].Index;
            string strMaKH = dgvKhachHang.Rows[index].Cells["colMaKhachHang"].Value.ToString();
            frmNhapKhachHang.txtMaKH.Text = strMaKH;
            string strTen = dgvKhachHang.Rows[index].Cells["colTenKhachHang"].Value.ToString();
            frmNhapKhachHang.txtTenKhachHang.Text = strTen;
            string strSoTaiKhoan = dgvKhachHang.Rows[index].Cells["colSoTaiKhoan"].Value.ToString();
            frmNhapKhachHang.txtSoTaiKhoan.Text = strSoTaiKhoan;
            string strNganHang = dgvKhachHang.Rows[index].Cells["colNganHang"].Value.ToString();
            frmNhapKhachHang.txtNganHang.Text = strNganHang;
            string strMaSoThue = dgvKhachHang.Rows[index].Cells["colMaSoThue"].Value.ToString();
            frmNhapKhachHang.txtMaSoThue.Text = strMaSoThue;
            string strDienThoai = dgvKhachHang.Rows[index].Cells["colSoDienThoai"].Value.ToString();
            frmNhapKhachHang.txtDienThoai.Text = strDienThoai;
            string strEmail = dgvKhachHang.Rows[index].Cells["colEmail"].Value.ToString();
            frmNhapKhachHang.txtEmail.Text = strEmail;
            string strDiaChi = dgvKhachHang.Rows[index].Cells["colDiaChi"].Value.ToString();
            frmNhapKhachHang.txtDiaChi.Text = strDiaChi;
            string strGhiChu = dgvKhachHang.Rows[index].Cells["colGhiChu"].Value.ToString();
            frmNhapKhachHang.txtGhiChu.Text = strGhiChu;
            frmNhapKhachHang.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvKhachHang.SelectedRows[0].Index;
            string strMaKH = dgvKhachHang.Rows[index].Cells["colMaKhachHang"].Value.ToString();
            dalKhachHang.DelKhachHang(strMaKH);
            MessageBox.Show("Bạn Chắc Muốn Xóa Khách Hàng Này!", "Xóa Khách Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
    }
}