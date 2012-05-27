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
    public partial class FrmDonViTinh : DevComponents.DotNetBar.Office2007Form
    {
        public FrmDonViTinh()
        {
            InitializeComponent();
        }

        DonViTinhBLL bllDonViTinh = new DonViTinhBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private void FrmDonViTinh_Load(object sender, EventArgs e)
        {
            LoadDonViTinh();
        }

        private void LoadDonViTinh()
        {
            DataTable dtDVT = new DataTable();
            dtDVT = bllDonViTinh.GetDonViTinh();
            dtDVT = cf.AutoNumberedTable(dtDVT);
            dgvDonViTinh.AutoGenerateColumns = false;
            dgvDonViTinh.DataSource = dtDVT;
            intRowCount = dgvDonViTinh.Rows.Count;
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
            LoadDonViTinh();
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
            LoadDonViTinh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDonViTinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvDonViTinh.SelectedRows[0].Index;
            string strMaDVT = dgvDonViTinh.Rows[index].Cells["colMaDonViTinh"].Value.ToString();
            if(MessageBox.Show("Bạn Chắc Chắn Xóa Dòng Này ?"," Xóa Đơn Vị Tính ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==  System.Windows.Forms.DialogResult.OK)
            {
                dgvDonViTinh.Rows.RemoveAt(index);
                bllDonViTinh.DelDonViTinh(strMaDVT);
                MessageBox.Show("Xóa Thành Công!", "Xóa Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDonViTinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                intIndex = dgvDonViTinh.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1) + "/" + intRowCount.ToString();
            }
            catch { }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (intIndex > 0)
            {
                intIndex--;
                dgvDonViTinh.Rows[intIndex].Selected = true;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intIndex = 0;
            dgvDonViTinh.Rows[intIndex].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intIndex < intRowCount - 1) 
            {
                intIndex++;
                dgvDonViTinh.Rows[intIndex].Selected = true;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            intIndex = intRowCount - 1;
            dgvDonViTinh.Rows[intIndex].Selected = true;
        }

    }
}