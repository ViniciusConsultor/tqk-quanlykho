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
    public partial class FrmNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        NhanVienBLL bllNhanVien = new NhanVienBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = bllNhanVien.GetNhanVien();
            dtNhanVien = cf.AutoNumberedTable(dtNhanVien);
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dtNhanVien;
            intRowCount = dgvNhanVien.Rows.Count;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapNhanVien frmNhapNhanVien = new FrmNhapNhanVien();
            frmNhapNhanVien.btnThemNhanVien.Tag = "add";
            string strMaNV = cf.CreateId("MANV", "NHANVIEN");
            frmNhapNhanVien.txtMaNV.Text = strMaNV;
            frmNhapNhanVien.ShowDialog();
            LoadNhanVien();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapNhanVien frmNhapNhanVien = new FrmNhapNhanVien();
            frmNhapNhanVien.btnThemNhanVien.Tag = "up";
            int index = dgvNhanVien.SelectedRows[0].Index;
            string strMaNV = dgvNhanVien.Rows[index].Cells["colMaNhanVien"].Value.ToString();
            frmNhapNhanVien.txtMaNV.Text = strMaNV;
            string strTenNV = dgvNhanVien.Rows[index].Cells["colTenNhanVien"].Value.ToString();
            frmNhapNhanVien.txtTenNhanVien.Text = strTenNV;
            string strBoPhan = dgvNhanVien.Rows[index].Cells["colBoPhan"].Value.ToString();
            frmNhapNhanVien.cmbBoPhan.Tag = strBoPhan;
            string strChucVu = dgvNhanVien.Rows[index].Cells["colChucVu"].Value.ToString();
            frmNhapNhanVien.cmbChucVu.Tag = strChucVu;
            DateTime dateNgaySinh = DateTime.Parse(dgvNhanVien.Rows[index].Cells["colNgaySinh"].Value.ToString());
            frmNhapNhanVien.dtNgaySinh.Value = dateNgaySinh; 
            string strDienThoai = dgvNhanVien.Rows[index].Cells["colSoDienThoai"].Value.ToString();
            frmNhapNhanVien.txtDienThoai.Text = strDienThoai;
            string strCMND = dgvNhanVien.Rows[index].Cells["colCMND"].Value.ToString();
            frmNhapNhanVien.txtCMND.Text = strCMND;
            string strDiaChi = dgvNhanVien.Rows[index].Cells["colDiaChi"].Value.ToString();
            frmNhapNhanVien.txtDiaChi.Text = strDiaChi;
            frmNhapNhanVien.ShowDialog();
            LoadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvNhanVien.SelectedRows[0].Index;
            string strMaNV = dgvNhanVien.Rows[index].Cells["colMaNhanVien"].Value.ToString();
            if (MessageBox.Show("Bạn Chắc Xóa Nhân Viên Này", "Xóa Nhân Viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                dgvNhanVien.Rows.RemoveAt(index);
                bllNhanVien.DelNhanVien(strMaNV);
                MessageBox.Show("Xóa Thành Công!", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnPreView_Click(object sender, EventArgs e)
        {
            if (intIndex > 0)
            {
                intIndex--;
                dgvNhanVien.Rows[intIndex].Selected = true;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intIndex = 0;
            dgvNhanVien.Rows[intIndex].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intIndex < intRowCount - 1)
            {
                intIndex++;
                dgvNhanVien.Rows[intIndex].Selected = true;
            }
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                intIndex = dgvNhanVien.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1).ToString() + "/" + intRowCount.ToString();
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            intIndex = intRowCount - 1;
            dgvNhanVien.Rows[intIndex].Selected = true;
        }

    }
}