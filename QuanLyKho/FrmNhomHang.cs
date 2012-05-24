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
    public partial class FrmNhomHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhomHang()
        {
            InitializeComponent();
        }

        NhomHangDAL dalNhomHang = new NhomHangDAL();
        CFunction cf = new CFunction();
        private void FrmNhomHang_Load(object sender, EventArgs e)
        {
            LoadNhomHang();
        }

        private void LoadNhomHang()
        {
            DataTable dtNhomHang = new DataTable();
            dtNhomHang = dalNhomHang.GetNhomHang();
            dtNhomHang = cf.AutoNumberedTable(dtNhomHang);
            dgvNhomHang.AutoGenerateColumns = false;
            dgvNhomHang.DataSource = dtNhomHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapNhomHang frmNhapNhomHang = new FrmNhapNhomHang();
            frmNhapNhomHang.btnOK.Tag = "add";
            string strMaNhom = cf.CreateId("NHA", "NHOMHANG");
            frmNhapNhomHang.txtMaNhom.Text = strMaNhom;
            frmNhapNhomHang.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapNhomHang frmNhapNhomHang = new FrmNhapNhomHang();
            frmNhapNhomHang.btnOK.Tag = "up";
            int index = dgvNhomHang.SelectedRows[0].Index;
            string strMaNhom = dgvNhomHang.Rows[index].Cells["colMaNhomHang"].Value.ToString();
            frmNhapNhomHang.txtMaNhom.Text = strMaNhom;
            string strTenNhom = dgvNhomHang.Rows[index].Cells["colTenNhomHang"].Value.ToString();
            frmNhapNhomHang.txtTenNhom.Text = strTenNhom;
            string strGhiChu = dgvNhomHang.Rows[index].Cells["colGhiChu"].Value.ToString();
            frmNhapNhomHang.txtGhiChu.Text = strGhiChu;
            frmNhapNhomHang.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvNhomHang.SelectedRows[0].Index;
            string strMaNhomHang = dgvNhomHang.Rows[index].Cells["colMaNhomHang"].Value.ToString();
            if (MessageBox.Show("Bạn Chắc Chắn Xóa Dòng Này ?", "Xóa Nhóm Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                dgvNhomHang.Rows.RemoveAt(index);
                dalNhomHang.DelNhomHang(strMaNhomHang);
                MessageBox.Show("Xóa Thành Công!", "Xóa Nhóm Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNhomHang();
        }
    }
}