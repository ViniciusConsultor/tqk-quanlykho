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

        NhanVienDAL dalNhanVien = new NhanVienDAL();
        CFunction cf = new CFunction();

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = dalNhanVien.GetNhanVien();
            dtNhanVien = cf.AutoNumberedTable(dtNhanVien);
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dtNhanVien;
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelItem7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapNhanVien frmNhapNhanVien = new FrmNhapNhanVien();
            frmNhapNhanVien.btnThemNhanVien.Tag = "Insert";
            string strMaNV = cf.CreateId("MANV", "NHANVIEN");
            frmNhapNhanVien.txtMaNV.Text = strMaNV;
            frmNhapNhanVien.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapNhanVien frmNhapNhanVien = new FrmNhapNhanVien();
            frmNhapNhanVien.btnThemNhanVien.Tag = "Update";
            int index = dgvNhanVien.SelectedRows[0].Index;
            string strMaNV = dgvNhanVien.Rows[index].Cells["colMaNhanVien"].Value.ToString();
            frmNhapNhanVien.txtMaNV.Text = strMaNV;
            string strTenNV = dgvNhanVien.Rows[index].Cells["colTenNhanVien"].Value.ToString();
            frmNhapNhanVien.txtTenNhanVien.Text = strTenNV;
            string strBoPhan = dgvNhanVien.Rows[index].Cells["colBoPhan"].Value.ToString();
            frmNhapNhanVien.cmbBoPhan.DisplayMember = strBoPhan;
            string strChucVu = dgvNhanVien.Rows[index].Cells["colChucVu"].Value.ToString();
            frmNhapNhanVien.cmbChucVu.DisplayMember = strChucVu;
            DateTime dateNgaySinh = DateTime.Parse(dgvNhanVien.Rows[index].Cells["colNgaySinh"].Value.ToString());
            frmNhapNhanVien.dtNgaySinh.Value = dateNgaySinh; 
            string strDienThoai = dgvNhanVien.Rows[index].Cells["colSoDienThoai"].Value.ToString();
            frmNhapNhanVien.txtDienThoai.Text = strDienThoai;
            string strCMND = dgvNhanVien.Rows[index].Cells["colCMND"].Value.ToString();
            frmNhapNhanVien.txtCMND.Text = strCMND;
            string strDiaChi = dgvNhanVien.Rows[index].Cells["colDiaChi"].Value.ToString();
            frmNhapNhanVien.txtDiaChi.Text = strDiaChi;
            frmNhapNhanVien.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvNhanVien.SelectedRows[0].Index;
            string strMaNV = dgvNhanVien.Rows[index].Cells["colMaNhanVien"].Value.ToString();
            MessageBox.Show("Bạn Chắc Xóa Nhân Viên Này", "Xóa Nhân Viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            dalNhanVien.DelNhanVien(strMaNV);
        }
    }
}