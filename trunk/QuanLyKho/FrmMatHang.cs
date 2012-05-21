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
    public partial class FrmMatHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmMatHang()
        {
            InitializeComponent();
        }

        MatHangDAL dalMatHang = new MatHangDAL();
        CFunction cf = new CFunction();
        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            LoadMatHang();
        }

        private void LoadMatHang()
        {
            DataTable dtMatHang = new DataTable();
            dtMatHang = dalMatHang.GetAllMatHang();
            dtMatHang = cf.AutoNumberedTable(dtMatHang);
            dgvMatHang.AutoGenerateColumns = false;
            dgvMatHang.DataSource = dtMatHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapMatHang frmNhapMatHang = new FrmNhapMatHang();
            frmNhapMatHang.btnThem.Tag = "add";
            string strMaMH = cf.CreateId("HHA", "MATHANG");
            frmNhapMatHang.txtMaMH.Text = strMaMH;
            frmNhapMatHang.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapMatHang frmNhapMatHang = new FrmNhapMatHang();
            frmNhapMatHang.btnThem.Tag = "up";
            int index = dgvMatHang.SelectedRows[0].Index;
            string strMaMH = dgvMatHang.Rows[index].Cells["colMaMatHang"].Value.ToString();
            frmNhapMatHang.txtMaMH.Text = strMaMH;
            string strTenMH = dgvMatHang.Rows[index].Cells["colTenMatHang"].Value.ToString();
            frmNhapMatHang.txtTenMH.Text = strTenMH;
            string strNhomHang = dgvMatHang.Rows[index].Cells["colNhomHang"].Value.ToString();
            frmNhapMatHang.cmbNhomHang.DisplayMember = strNhomHang;
            string strKhoHang = dgvMatHang.Rows[index].Cells["colKho"].Value.ToString();
            frmNhapMatHang.cmbKhoHang.Text = strKhoHang;
            string strDVT = dgvMatHang.Rows[index].Cells["colDonViTinh"].Value.ToString();
            frmNhapMatHang.cmbDonViTinh.Text = strDVT;
            string strTonDau = dgvMatHang.Rows[index].Cells["colTonDau"].Value.ToString();
            frmNhapMatHang.txtTonDau.Text = strTonDau;
            string strMoTa = dgvMatHang.Rows[index].Cells["colMoTa"].Value.ToString();
            frmNhapMatHang.txtMoTa.Text =  strMoTa;
            frmNhapMatHang.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvMatHang.SelectedRows[0].Index;
            string strMaMH = dgvMatHang.Rows[index].Cells["colMaMatHang"].Value.ToString();
            MessageBox.Show("Bạn Có Chắc Muốn Xóa Mặt Hàng Này!", "Xóa Mặt Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            dalMatHang.DelMatHang(strMaMH);
            MessageBox.Show("Xóa Mặt Hàng Thành Công!", "Xóa Mặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMatHang();
        }
    }
}