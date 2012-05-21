using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DAL;
using DTO;
using DevComponents.DotNetBar.Controls;
namespace QuanLyKho
{
    public partial class FrmNhapBoPhan : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapBoPhan()
        {
            InitializeComponent();
        }
        private void LoadBoPhan(DataGridViewX dgv)
        {
            DataTable dtBoPhan = new DataTable();
            dtBoPhan = dalBoPhan.GetBoPhan();
            dtBoPhan = cf.AutoNumberedTable(dtBoPhan);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dtBoPhan;
        }
        BoPhanDTO dtoBoPhan = new BoPhanDTO();
        BoPhanDAL dalBoPhan = new BoPhanDAL();
        CFunction cf = new CFunction();
        private void btnOK_Click(object sender, EventArgs e)
        {
            string strAction = btnOK.Tag.ToString();
            if (strAction == "add")
            {
                dtoBoPhan.MaBP = txtMaBP.Text;
                dtoBoPhan.TenBoPhan = txtTenBP.Text;
                dalBoPhan.InsertBoPhan(dtoBoPhan);
                MessageBox.Show("Thêm Thành Công!", "Thêm Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            else
            {
                dtoBoPhan.MaBP = txtMaBP.Text;
                dtoBoPhan.TenBoPhan = txtTenBP.Text;
                dalBoPhan.UpdateBoPhan(dtoBoPhan);
                MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}