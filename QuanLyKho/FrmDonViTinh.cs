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
    public partial class FrmDonViTinh : DevComponents.DotNetBar.Office2007Form
    {
        public FrmDonViTinh()
        {
            InitializeComponent();
        }

        DonViTinhDAL dalDonViTinh = new DonViTinhDAL();
        CFunction cf = new CFunction();
        private void FrmDonViTinh_Load(object sender, EventArgs e)
        {
            DataTable dtDVT = new DataTable();
            dtDVT = dalDonViTinh.GetDonViTinh();
            dtDVT = cf.AutoNumberedTable(dtDVT);
            dgvDonViTinh.AutoGenerateColumns = false;
            dgvDonViTinh.DataSource = dtDVT;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}