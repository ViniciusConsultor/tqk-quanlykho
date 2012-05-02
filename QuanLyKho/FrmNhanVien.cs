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
    public partial class FrmNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        NhanVienDAL dalNhanVien = new NhanVienDAL();
        CFunction cf = new CFunction();

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = dalNhanVien.GetNhanVien();
            dtNhanVien = cf.AutoNumberedTable(dtNhanVien);
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dtNhanVien;
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelItem7_Click(object sender, EventArgs e)
        {

        }
    }
}