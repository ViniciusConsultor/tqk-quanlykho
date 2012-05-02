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
    public partial class FrmMatHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmMatHang()
        {
            InitializeComponent();
        }

        MatHangDAL dalMatHang = new MatHangDAL();
        CFunction cf = new CFunction();
        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            DataTable dtMatHang = new DataTable();
            dtMatHang = dalMatHang.GetAllMatHang();
            dtMatHang = cf.AutoNumberedTable(dtMatHang);
            dgvMatHang.AutoGenerateColumns = false;
            dgvMatHang.DataSource = dtMatHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}