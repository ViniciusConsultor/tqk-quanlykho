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
    public partial class FrmNhaCungCap : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        NhaCungCapDAL dalNhaCungCap = new NhaCungCapDAL();
        CFunction cf = new CFunction();
        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dtNhaCungCap = new DataTable();
            dtNhaCungCap = dalNhaCungCap.GetAllNhaCungCap();
            dtNhaCungCap = cf.AutoNumberedTable(dtNhaCungCap);
            dgvNhaCungCap.AutoGenerateColumns = false;
            dgvNhaCungCap.DataSource = dtNhaCungCap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        
    }
}