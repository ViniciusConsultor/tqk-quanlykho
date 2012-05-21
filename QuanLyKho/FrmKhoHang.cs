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
    public partial class FrmKhoHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmKhoHang()
        {
            InitializeComponent();
        }

        KhoHangDAL dalKhoHang = new KhoHangDAL();
        NhanVienDAL dalNhanVien = new NhanVienDAL();
        CFunction cf = new CFunction();
        private void FrmKhoHang_Load(object sender, EventArgs e)
        {
            LoadKhoHang();

        }

        private void LoadKhoHang()
        {
            DataTable dtKhoHang = new DataTable();
            dtKhoHang = dalKhoHang.GetAllKhoHang();
            dtKhoHang = cf.AutoNumberedTable(dtKhoHang);
            dgvKhoHang.AutoGenerateColumns = false;
            dgvKhoHang.DataSource = dtKhoHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapKhoHang frmNhapKhoHang = new FrmNhapKhoHang();
            frmNhapKhoHang.btnOK.Tag = "add";
            string strMaKho = cf.CreateId("MKO", "KHO");
            frmNhapKhoHang.txtMaKho.Text = strMaKho;
            frmNhapKhoHang.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapKhoHang frmNhapKhoHang = new FrmNhapKhoHang();
            frmNhapKhoHang.btnOK.Tag = "up";
            int index = dgvKhoHang.SelectedRows[0].Index;
            string strMaKho = dgvKhoHang.Rows[index].Cells["colMaKho"].Value.ToString();
            frmNhapKhoHang.txtMaKho.Text = strMaKho;
            string strTenKho = dgvKhoHang.Rows[index].Cells["colTenKho"].Value.ToString();
            frmNhapKhoHang.txtTenKho.Text = strTenKho;
            string strDienThoaiBan = dgvKhoHang.Rows[index].Cells["colDienThoai"].Value.ToString();
            frmNhapKhoHang.txtDienThoaiBan.Text = strDienThoaiBan;
            string strDienThoaiDD = dgvKhoHang.Rows[index].Cells["colDiDong"].Value.ToString();
            frmNhapKhoHang.txtDienThoaiDD.Text = strDienThoaiDD;
            string strNguoiLienHe = dgvKhoHang.Rows[index].Cells["colNguoiLienHe"].Value.ToString();
            frmNhapKhoHang.cmbNhanVien.Text = strNguoiLienHe;
            string strFax = dgvKhoHang.Rows[index].Cells["colFax"].Value.ToString();
            frmNhapKhoHang.txtFax.Text = strFax;
            string strDiaChi = dgvKhoHang.Rows[index].Cells["colDiaChi"].Value.ToString();
            frmNhapKhoHang.txtDiaChi.Text = strDiaChi;
            string strGhiChu = dgvKhoHang.Rows[index].Cells["colGhiChu"].Value.ToString();
            frmNhapKhoHang.txtGhiChu.Text = strGhiChu;
            frmNhapKhoHang.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvKhoHang.SelectedRows[0].Index;
            string strMaKho = dgvKhoHang.Rows[index].Cells["colMaKho"].Value.ToString();
            if (MessageBox.Show("Bạn Chắc Chắn Xóa Dòng Này ?", "Xóa Kho Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                dgvKhoHang.Rows.RemoveAt(index);
                dalKhoHang.DelKhoHang(strMaKho);
                MessageBox.Show("Xóa Thành Công!", "Xóa Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKhoHang();
        }
    }
}