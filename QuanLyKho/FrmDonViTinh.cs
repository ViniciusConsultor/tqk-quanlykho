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
    public partial class FrmDonViTinh : DevComponents.DotNetBar.Office2007Form
    {
        public FrmDonViTinh()
        {
            InitializeComponent();
        }

        DonViTinhDAL dalDonViTinh = new DonViTinhDAL();
        CFunction cf = new CFunction();
        private void FrmDonViTinh_Load(object sender, EventArgs e)
        {
            LoadDonViTinh();
        }

        private void LoadDonViTinh()
        {
            DataTable dtDVT = new DataTable();
            dtDVT = dalDonViTinh.GetDonViTinh();
            dtDVT = cf.AutoNumberedTable(dtDVT);
            dgvDonViTinh.AutoGenerateColumns = false;
            dgvDonViTinh.DataSource = dtDVT;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapDonViTinh frmNhapDVT = new FrmNhapDonViTinh();
            frmNhapDVT.btnOK.Tag = "add";
            string strDVT = cf.CreateId("DVT", "DONVITINH");
            frmNhapDVT.txtMaDVT.Text = strDVT;
            frmNhapDVT.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapDonViTinh frmNhapDVT = new FrmNhapDonViTinh();
            frmNhapDVT.btnOK.Tag = "up";
            int index = dgvDonViTinh.SelectedRows[0].Index;
            string strMaDVT = dgvDonViTinh.Rows[index].Cells["colMaDonViTinh"].Value.ToString();
            frmNhapDVT.txtMaDVT.Text = strMaDVT;
            string strDVT = dgvDonViTinh.Rows[index].Cells["colDonViTinh"].Value.ToString();
            frmNhapDVT.txtDonViTinh.Text = strDVT;
            frmNhapDVT.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDonViTinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvDonViTinh.SelectedRows[0].Index;
            string strMaDVT = dgvDonViTinh.Rows[index].Cells["colMaDonViTinh"].Value.ToString();
            dalDonViTinh.DelDonViTinh(strMaDVT);
            MessageBox.Show("Xóa Thành Công!", "Xóa Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}