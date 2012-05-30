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
    public partial class FrmKhoHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmKhoHang()
        {
            InitializeComponent();
        }

        KhoHangBLL bllKhoHang = new KhoHangBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private void FrmKhoHang_Load(object sender, EventArgs e)
        {
            LoadKhoHang();

        }

        private void LoadKhoHang()
        {
            try
            {
                DataTable dtKhoHang = new DataTable();
                dtKhoHang = bllKhoHang.GetAllKhoHang();
                dtKhoHang = cf.AutoNumberedTable(dtKhoHang);
                dgvKhoHang.AutoGenerateColumns = false;
                dgvKhoHang.DataSource = dtKhoHang;
                intRowCount = dgvKhoHang.Rows.Count;
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
                FrmNhapKhoHang frmNhapKhoHang = new FrmNhapKhoHang();
                frmNhapKhoHang.btnOK.Tag = "add";
                string strMaKho = cf.CreateId("MKO", "KHO");
                frmNhapKhoHang.txtMaKho.Text = strMaKho;
                frmNhapKhoHang.ShowDialog();
                LoadKhoHang();
            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
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
                frmNhapKhoHang.cmbNhanVien.Tag = strNguoiLienHe;
                string strFax = dgvKhoHang.Rows[index].Cells["colFax"].Value.ToString();
                frmNhapKhoHang.txtFax.Text = strFax;
                string strDiaChi = dgvKhoHang.Rows[index].Cells["colDiaChi"].Value.ToString();
                frmNhapKhoHang.txtDiaChi.Text = strDiaChi;
                string strGhiChu = dgvKhoHang.Rows[index].Cells["colGhiChu"].Value.ToString();
                frmNhapKhoHang.txtGhiChu.Text = strGhiChu;
                frmNhapKhoHang.ShowDialog();
                LoadKhoHang();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKhoHang.SelectedRows[0].Index;
                string strMaKho = dgvKhoHang.Rows[index].Cells["colMaKho"].Value.ToString();
                if (MessageBox.Show("Bạn Chắc Chắn Xóa Dòng Này ?", "Xóa Kho Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    dgvKhoHang.Rows.RemoveAt(index);
                    bllKhoHang.DelKhoHang(strMaKho);
                    MessageBox.Show("Xóa Thành Công!", "Xóa Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKhoHang();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = 0;
                dgvKhoHang.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (intIndex > 0)
                {
                    intIndex--;
                    dgvKhoHang.Rows[intIndex].Selected = true;
                }
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
                    dgvKhoHang.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = intRowCount - 1;
                dgvKhoHang.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void dgvKhoHang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                intIndex = dgvKhoHang.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1).ToString() + "/" + intRowCount.ToString();
            }
            catch { }
        }
    }
}