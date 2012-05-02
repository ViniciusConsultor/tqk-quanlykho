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
    public partial class FrmKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        KhachHangDAL dalKhachHang = new KhachHangDAL();
        CFunction cf = new CFunction();

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = dalKhachHang.GetAllKhachHang();
            dtKhachHang = cf.AutoNumberedTable(dtKhachHang);
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = dtKhachHang;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}