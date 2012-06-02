using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using DevComponents.DotNetBar.Controls;
using BLL;

namespace QuanLyKho
{
    public partial class FrmBoPhan : DevComponents.DotNetBar.Office2007Form
    {
        public FrmBoPhan()
        {
            InitializeComponent();
        }
        BoPhanBLL bllBoPhan = new BoPhanBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private void FrmBoPhan_Load(object sender, EventArgs e)
        {
            LoadBoPhan(dgvBoPhan);
        }

        public void LoadBoPhan(DataGridViewX dgv)
        {
            try
            {
                DataTable dtBoPhan = new DataTable();
                dtBoPhan = bllBoPhan.GetBoPhan();
                dtBoPhan = cf.AutoNumberedTable(dtBoPhan);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dtBoPhan;
                intRowCount = dgvBoPhan.Rows.Count;
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
                FrmNhapBoPhan frmNhapBoPhan = new FrmNhapBoPhan();
                frmNhapBoPhan.btnOK.Tag = "add";
                string strMaBP = cf.CreateId("MABP", "BOPHAN");
                frmNhapBoPhan.txtMaBP.Text = strMaBP;
                frmNhapBoPhan.ShowDialog();
                LoadBoPhan(dgvBoPhan);
            }
            catch { }
       
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapBoPhan frmNhapBoPhan = new FrmNhapBoPhan();
                frmNhapBoPhan.btnOK.Tag = "up";
                int index = dgvBoPhan.SelectedRows[0].Index;
                string strMaBP = dgvBoPhan.Rows[index].Cells["colMaBoPhan"].Value.ToString();
                frmNhapBoPhan.txtMaBP.Text = strMaBP;
                string strTenBP = dgvBoPhan.Rows[index].Cells["colTenBoPhan"].Value.ToString();
                frmNhapBoPhan.txtTenBP.Text = strTenBP;
                frmNhapBoPhan.ShowDialog();
                LoadBoPhan(dgvBoPhan);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvBoPhan.SelectedRows[0].Index;
                string strMaBP = dgvBoPhan.Rows[index].Cells["colMaBoPhan"].Value.ToString();
                if (MessageBox.Show("Bạn Có Chắc Chắn Xóa Dòng Này ?", "Xóa Bộ Phận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    dgvBoPhan.Rows.RemoveAt(index);
                    bllBoPhan.DelBoPhan(strMaBP);
                    MessageBox.Show("Xóa Thành Công!", "Xóa Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoPhan(dgvBoPhan);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = 0;
                dgvBoPhan.Rows[intIndex].Selected = true;
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
                    dgvBoPhan.Rows[intIndex].Selected = true;
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
                    dgvBoPhan.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = intRowCount - 1;
                dgvBoPhan.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void dgvBoPhan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                intIndex = dgvBoPhan.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1).ToString() + "/" + intRowCount.ToString();
            }
            catch { }
        }
    }
}