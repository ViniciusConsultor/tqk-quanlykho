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
    public partial class FrmMucThue : DevComponents.DotNetBar.Office2007Form
    {
        public FrmMucThue()
        {
            InitializeComponent();
        }

        MucThueBLL bllMucThue = new MucThueBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private void FrmMucThue_Load(object sender, EventArgs e)
        {
            LoadMucThue();

        }

        private void LoadMucThue()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllMucThue.GetMucThue();
                dt = cf.AutoNumberedTable(dt);
                dgvSoThue.AutoGenerateColumns = false;
                dgvSoThue.DataSource = dt;
                intRowCount = dgvSoThue.Rows.Count;
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapMucThue frmNhapMucThue = new FrmNhapMucThue();
                frmNhapMucThue.btnOK.Tag = "add";
                string strMaThue = cf.CreateId("TH", "THUE");
                frmNhapMucThue.txtMaThue.Text = strMaThue;
                frmNhapMucThue.ShowDialog();
                LoadMucThue();
            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapMucThue frmNhapMucThue = new FrmNhapMucThue();
                frmNhapMucThue.btnOK.Tag = "up";
                int index = dgvSoThue.SelectedRows[0].Index;
                string strMaThue = dgvSoThue.Rows[index].Cells["colMaThue"].Value.ToString();
                frmNhapMucThue.txtMaThue.Text = strMaThue;
                string strSoThue = dgvSoThue.Rows[index].Cells["colSoThue"].Value.ToString();
                frmNhapMucThue.txtSoThue.Text = strSoThue;
                string strGhiChu = dgvSoThue.Rows[index].Cells["colGhiChu"].Value.ToString();
                frmNhapMucThue.txtGhiChu.Text = strGhiChu;
                frmNhapMucThue.ShowDialog();
                LoadMucThue();
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMucThue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvSoThue.SelectedRows[0].Index;
                string strMaTH = dgvSoThue.Rows[index].Cells["colMaThue"].Value.ToString();
                if (MessageBox.Show("Bạn Chắc Chắn Xóa Dòng Này ?", "Xóa Mức Thuế", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    dgvSoThue.Rows.RemoveAt(index);
                    bllMucThue.DelMucThue(strMaTH);
                    MessageBox.Show("Xóa Thành Công!", "Xóa Mức Thuế", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    dgvSoThue.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = 0;
                dgvSoThue.Rows[intIndex].Selected = true;
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
                    dgvSoThue.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = intRowCount - 1;
                dgvSoThue.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void dgvSoThue_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                intIndex = dgvSoThue.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1) + "/" + intRowCount.ToString();
            }
            catch { }
        }
    }
}