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
using DevComponents.DotNetBar.Controls;

namespace QuanLyKho
{
    public partial class FrmBoPhan : DevComponents.DotNetBar.Office2007Form
    {
        public FrmBoPhan()
        {
            InitializeComponent();
        }
        BoPhanDAL dalBoPhan = new BoPhanDAL();
        CFunction cf = new CFunction();

        private void FrmBoPhan_Load(object sender, EventArgs e)
        {
            LoadBoPhan(dgvBoPhan);
        }

        public  void LoadBoPhan(DataGridViewX dgv)
        {
            DataTable dtBoPhan = new DataTable();
            dtBoPhan = dalBoPhan.GetBoPhan();
            dtBoPhan = cf.AutoNumberedTable(dtBoPhan);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dtBoPhan;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapBoPhan frmNhapBoPhan = new FrmNhapBoPhan();
            frmNhapBoPhan.btnOK.Tag = "add";
            string strMaBP = cf.CreateId("MABP","BOPHAN");
            frmNhapBoPhan.txtMaBP.Text = strMaBP;
            frmNhapBoPhan.ShowDialog();
       
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapBoPhan frmNhapBoPhan = new FrmNhapBoPhan();
            frmNhapBoPhan.btnOK.Tag = "up";
            int index = dgvBoPhan.SelectedRows[0].Index;
            string strMaBP = dgvBoPhan.Rows[index].Cells["colMaBoPhan"].Value.ToString();
            frmNhapBoPhan.txtMaBP.Text = strMaBP;
            string strTenBP = dgvBoPhan.Rows[index].Cells["colTenBoPhan"].Value.ToString();
            frmNhapBoPhan.txtTenBP.Text = strTenBP;
            frmNhapBoPhan.ShowDialog();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvBoPhan.SelectedRows[0].Index;
            string strMaBP = dgvBoPhan.Rows[index].Cells["colMaBoPhan"].Value.ToString();
            if (MessageBox.Show("Bạn Có Chắc Chắn Xóa Dòng Này ?", "Xóa Bộ Phận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                dgvBoPhan.Rows.RemoveAt(index);
                dalBoPhan.DelBoPhan(strMaBP);
                MessageBox.Show("Xóa Thành Công!", "Xóa Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoPhan(dgvBoPhan);
        }
    }
}