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
    public partial class FrmKhoHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmKhoHang()
        {
            InitializeComponent();
        }

        KhoHangDAL dalKhoHang = new KhoHangDAL();
        CFunction cf = new CFunction();
        private void FrmKhoHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhoHang = new DataTable();
            dtKhoHang = dalKhoHang.GetAllKhoHang();
            dtKhoHang = cf.AutoNumberedTable(dtKhoHang);
            dgvKhoHang.AutoGenerateColumns = false;
            dgvKhoHang.DataSource = dtKhoHang;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}