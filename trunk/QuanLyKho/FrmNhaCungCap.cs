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
    public partial class FrmNhaCungCap : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        NhaCungCapDAL dalNhaCungCap = new NhaCungCapDAL();
        CFunction cf = new CFunction();
        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }

        private void LoadNhaCungCap()
        {
            DataTable dtNhaCungCap = new DataTable();
            dtNhaCungCap = dalNhaCungCap.GetAllNhaCungCap();
            dtNhaCungCap = cf.AutoNumberedTable(dtNhaCungCap);
            dgvNhaCungCap.AutoGenerateColumns = false;
            dgvNhaCungCap.DataSource = dtNhaCungCap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
            frmNhapNCC.btnThem.Tag = "add";
            string strMaNCC = cf.CreateId("CCA", "NHACUNGCAP");
            frmNhapNCC.txtMaNCC.Text = strMaNCC;
            frmNhapNCC.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
            frmNhapNCC.btnThem.Tag = "up";
            int index = dgvNhaCungCap.SelectedRows[0].Index;
            string strMaNCC = dgvNhaCungCap.Rows[index].Cells["colMaNhaCungCap"].Value.ToString();
            frmNhapNCC.txtMaNCC.Text = strMaNCC;
            string strTenNCC = dgvNhaCungCap.Rows[index].Cells["colTenNhaCungCap"].Value.ToString();
            frmNhapNCC.txtTenNCC.Text = strTenNCC;
            string strMaSoThue = dgvNhaCungCap.Rows[index].Cells["colMaSoThue"].Value.ToString();
            frmNhapNCC.txtMaSoThue.Text = strMaSoThue;
            string strSotaiKhoan = dgvNhaCungCap.Rows[index].Cells["colSoTaiKhoan"].Value.ToString();
            frmNhapNCC.txtSoTaiKhoan.Text = strSotaiKhoan;
            string strNganHang = dgvNhaCungCap.Rows[index].Cells["colNganHang"].Value.ToString();
            frmNhapNCC.txtNganHang.Text = strNganHang;
            string strDienThoai = dgvNhaCungCap.Rows[index].Cells["colDienThoai"].Value.ToString();
            frmNhapNCC.txtDienThoai.Text = strDienThoai;
            string strDiaChi = dgvNhaCungCap.Rows[index].Cells["colDiaChi"].Value.ToString();
            frmNhapNCC.txtDiaChi.Text = strDiaChi;
            string strEmail = dgvNhaCungCap.Rows[index].Cells["colEmail"].Value.ToString();
            frmNhapNCC.txtEmail.Text = strEmail;
            string strGhiChu = dgvNhaCungCap.Rows[index].Cells["colGhiChu"].Value.ToString();
            frmNhapNCC.txtGhiChu.Text = strGhiChu;
            frmNhapNCC.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvNhaCungCap.SelectedRows[0].Index;
            string strMaNCC = dgvNhaCungCap.Rows[index].Cells["colMaNhaCungCap"].Value.ToString();
            //MessageBox.Show("Bạn Chắc Chắn Xóa Dòng Này!", "Xóa Nhà Cung Cấp", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            dalNhaCungCap.DelNhaCungCap(strMaNCC);
            MessageBox.Show("Xóa Thành Công!", "Xóa Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }

        
    }
}