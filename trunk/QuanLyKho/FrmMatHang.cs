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
    public partial class FrmMatHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmMatHang()
        {
            InitializeComponent();
        }

        MatHangBLL bllMatHang = new MatHangBLL();
        CFunction cf = new CFunction();
        int intIndex = 0;
        int intRowCount = 0;
        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            LoadMatHang();
        }

        private void LoadMatHang()
        {
            try
            {
                DataTable dtMatHang = new DataTable();
                dtMatHang = bllMatHang.GetAllMatHang();
                dtMatHang = cf.AutoNumberedTable(dtMatHang);
                dgvMatHang.AutoGenerateColumns = false;
                dgvMatHang.DataSource = dtMatHang;
                intRowCount = dgvMatHang.Rows.Count;
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
                FrmNhapMatHang frmNhapMatHang = new FrmNhapMatHang();
                frmNhapMatHang.btnThem.Tag = "add";
                string strMaMH = cf.CreateId("HHA", "MATHANG");
                frmNhapMatHang.txtMaMH.Text = strMaMH;
                frmNhapMatHang.ShowDialog();
                LoadMatHang();
            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapMatHang frmNhapMatHang = new FrmNhapMatHang();
                frmNhapMatHang.btnThem.Tag = "up";
                int index = dgvMatHang.SelectedRows[0].Index;
                string strMaMH = dgvMatHang.Rows[index].Cells["colMaMatHang"].Value.ToString();
                frmNhapMatHang.txtMaMH.Text = strMaMH;
                string strTenMH = dgvMatHang.Rows[index].Cells["colTenMatHang"].Value.ToString();
                frmNhapMatHang.txtTenMH.Text = strTenMH;
                string strNhomHang = dgvMatHang.Rows[index].Cells["colNhomHang"].Value.ToString();
                frmNhapMatHang.cmbNhomHang.DisplayMember = strNhomHang;
                string strKhoHang = dgvMatHang.Rows[index].Cells["colKho"].Value.ToString();
                frmNhapMatHang.cmbKhoHang.Text = strKhoHang;
                string strDVT = dgvMatHang.Rows[index].Cells["colDonViTinh"].Value.ToString();
                frmNhapMatHang.cmbDonViTinh.Text = strDVT;
                float TonDau = 0;
                if (dgvMatHang.Rows[index].Cells["colTonDau"].Value.ToString() == "")
                {
                    TonDau = 0;
                    frmNhapMatHang.txtTonDau.Text = TonDau.ToString();
                }
                else
                {
                    frmNhapMatHang.txtTonDau.Text = TonDau.ToString();
                }
                string strMoTa = dgvMatHang.Rows[index].Cells["colMoTa"].Value.ToString();
                frmNhapMatHang.txtMoTa.Text = strMoTa;
                frmNhapMatHang.ShowDialog();
                LoadMatHang();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvMatHang.SelectedRows[0].Index;
                string strMaMH = dgvMatHang.Rows[index].Cells["colMaMatHang"].Value.ToString();
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Mặt Hàng Này!", "Xóa Mặt Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    dgvMatHang.Rows.RemoveAt(index);
                    bllMatHang.DelMatHang(strMaMH);
                    MessageBox.Show("Xóa Mặt Hàng Thành Công!", "Xóa Mặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMatHang();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (intIndex > 0)
                {
                    intIndex--;
                    dgvMatHang.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = 0;
                dgvMatHang.Rows[intIndex].Selected = true;
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
                    dgvMatHang.Rows[intIndex].Selected = true;
                }
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                intIndex = intRowCount - 1;
                dgvMatHang.Rows[intIndex].Selected = true;
            }
            catch { }
        }

        private void dgvMatHang_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                intIndex = dgvMatHang.SelectedRows[0].Index;
                txtIndex.Text = (intIndex + 1).ToString() + "/" + intRowCount.ToString();
            }
            catch { }
        }
    }
}