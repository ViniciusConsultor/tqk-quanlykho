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
    public partial class FrmNhomHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhomHang()
        {
            InitializeComponent();
        }

        NhomHangDAL dalNhomHang = new NhomHangDAL();
        CFunction cf = new CFunction();
        private void FrmNhomHang_Load(object sender, EventArgs e)
        {
            DataTable dtNhomHang = new DataTable();
            dtNhomHang = dalNhomHang.GetNhomHang();
            dtNhomHang = cf.AutoNumberedTable(dtNhomHang);
            dgvNhomHang.AutoGenerateColumns = false;
            dgvNhomHang.DataSource = dtNhomHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}