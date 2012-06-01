using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using BLL;
namespace QuanLyKho
{
    public partial class FrmTaiKhoanNganHang : DevComponents.DotNetBar.Office2007Form
    {
        public FrmTaiKhoanNganHang()
        {
            InitializeComponent();
        }
        TaiKhoanBLL bllTaiKhoan = new TaiKhoanBLL();
        CFunction cf = new CFunction();
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapTaiKhoanNH frmNhapTKNH = new FrmNhapTaiKhoanNH();
            frmNhapTKNH.btnOK.Tag = "add";
            string strMaTK = cf.CreateId("TK", "TAIKHOAN");
            frmNhapTKNH.txtMaTaiKhoan.Text = strMaTK;
            frmNhapTKNH.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhapTaiKhoanNH frmNhapTKNH = new FrmNhapTaiKhoanNH();
            frmNhapTKNH.btnOK.Tag = "up";
            frmNhapTKNH.ShowDialog();
        }
    }
}