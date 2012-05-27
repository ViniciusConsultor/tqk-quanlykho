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
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = bllKhachHang.GetAllKhachHang();
            dtKhachHang = cf.AutoNumberedTable(dtKhachHang);
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = dtKhachHang;
            intRowCount = dgvKhachHang.Rows.Count;

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
            LoadKhachHang();
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
            LoadKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvKhachHang.SelectedRows[0].Index;
            string strMaKH = dgvKhachHang.Rows[index].Cells["colMaKhachHang"].Value.ToString();
            if (MessageBox.Show("Bạn Chắc Muốn Xóa Khách Hàng Này!", "Xóa Khách Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                dgvKhachHang.Rows.RemoveAt(index);
                bllKhachHang.DelKhachHang(strMaKH);
                MessageBox.Show("Xóa Thành Công!","Xóa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (intIndex > 0)
            {
                intIndex--;
                dgvKhachHang.Rows[intIndex].Selected = true;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intIndex = 0;
            dgvKhachHang.Rows[intIndex].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intIndex < intRowCount - 1)
            {
                intIndex++;
                dgvKhachHang.Rows[intIndex].Selected = true;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            intIndex = intRowCount - 1;
            dgvKhachHang.Rows[intIndex].Selected = true;
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