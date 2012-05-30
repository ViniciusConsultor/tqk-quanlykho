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
    public partial class FrmNhaCungCap : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }

        private void LoadNhaCungCap()
        {
            try
            {
                DataTable dtNhaCungCap = new DataTable();
                dtNhaCungCap = bllNhaCungCap.GetAllNhaCungCap();
                dtNhaCungCap = cf.AutoNumberedTable(dtNhaCungCap);
                dgvNhaCungCap.AutoGenerateColumns = false;
                dgvNhaCungCap.DataSource = dtNhaCungCap;
                intRowCount = dgvNhaCungCap.Rows.Count;
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
                FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
                frmNhapNCC.btnThem.Tag = "add";
                string strMaNCC = cf.CreateId("CCA", "NHACUNGCAP");
                frmNhapNCC.txtMaNCC.Text = strMaNCC;
                frmNhapNCC.ShowDialog();
                LoadNhaCungCap();
            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
                frmNhapNCC.btnThem.Tag = "up";
                string strMaNCC = dgvNhaCungCap.Rows[intIndex].Cells["colMaNhaCungCap"].Value.ToString();
                frmNhapNCC.txtMaNCC.Text = strMaNCC;
                string strTenNCC = dgvNhaCungCap.Rows[intIndex].Cells["colTenNhaCungCap"].Value.ToString();
                frmNhapNCC.txtTenNCC.Text = strTenNCC;
                string strMaSoThue = dgvNhaCungCap.Rows[intIndex].Cells["colMaSoThue"].Value.ToString();
                frmNhapNCC.txtMaSoThue.Text = strMaSoThue;
                string strSotaiKhoan = dgvNhaCungCap.Rows[intIndex].Cells["colSoTaiKhoan"].Value.ToString();
                frmNhapNCC.txtSoTaiKhoan.Text = strSotaiKhoan;
                string strNganHang = dgvNhaCungCap.Rows[intIndex].Cells["colNganHang"].Value.ToString();
                frmNhapNCC.txtNganHang.Text = strNganHang;
                string strDienThoai = dgvNhaCungCap.Rows[intIndex].Cells["colDienThoai"].Value.ToString();
                frmNhapNCC.txtDienThoai.Text = strDienThoai;
                string strDiaChi = dgvNhaCungCap.Rows[intIndex].Cells["colDiaChi"].Value.ToString();
                frmNhapNCC.txtDiaChi.Text = strDiaChi;
                string strEmail = dgvNhaCungCap.Rows[intIndex].Cells["colEmail"].Value.ToString();
                frmNhapNCC.txtEmail.Text = strEmail;
                string strGhiChu = dgvNhaCungCap.Rows[intIndex].Cells["colGhiChu"].Value.ToString();
                frmNhapNCC.txtGhiChu.Text = strGhiChu;
                frmNhapNCC.ShowDialog();
                LoadNhaCungCap();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvNhaCungCap.SelectedRows[0].Index;
                string strMaNCC = dgvNhaCungCap.Rows[index].Cells["colMaNhaCungCap"].Value.ToString();
                if (MessageBox.Show("Bạn Chắc Chắn Xóa Dòng Này!", "Xóa Nhà Cung Cấp", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    bllNhaCungCap.DelNhaCungCap(strMaNCC);
                    MessageBox.Show("Xóa Thành Công!", "Xóa Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (intIndex > 0)
                {
                    intIndex--;
                    dgvNhaCungCap.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void dgvNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                intIndex = dgvNhaCungCap.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1).ToString() + "/" + intRowCount.ToString();
            }
            catch{}
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (intIndex < intRowCount - 1)
                {
                    intIndex++;
                    dgvNhaCungCap.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = 0;
                dgvNhaCungCap.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = intRowCount - 1;
                dgvNhaCungCap.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        
    }
}