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
    public partial class FrmNhapDonViTinh : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapDonViTinh()
        {
            InitializeComponent();
        }

        DonViTinhDTO dtoDVT = new DonViTinhDTO();
        DonViTinhDAL dalDVT = new DonViTinhDAL();
        CFunction cf = new CFunction();
        private void btnOK_Click(object sender, EventArgs e)
        {
            string strAction = btnOK.Tag.ToString();
            if (strAction == "add")
            {
                dtoDVT.MaDVT = txtMaDVT.Text;
                dtoDVT.DonViTinh = txtDonViTinh.Text;
                dalDVT.InsertDonViTinh(dtoDVT);
                MessageBox.Show("Thêm Thành Công!", "Thêm Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtoDVT.MaDVT = txtMaDVT.Text;
                dtoDVT.DonViTinh = txtDonViTinh.Text;
                dalDVT.UpdateDonViTinh(dtoDVT);
                MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               

        }
    }
}