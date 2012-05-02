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
            DataTable dtBoPhan = new DataTable();
            dtBoPhan = dalBoPhan.GetBoPhan();
            dtBoPhan = cf.AutoNumberedTable(dtBoPhan);
            dgvBoPhan.AutoGenerateColumns = false;
            dgvBoPhan.DataSource = dtBoPhan;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}