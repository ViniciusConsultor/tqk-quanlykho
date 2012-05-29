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
using System.Diagnostics;
using System.IO;
namespace QuanLyKho
{
    public partial class FrmTTDoanhNghiep : DevComponents.DotNetBar.Office2007Form
    {
        public FrmTTDoanhNghiep()
        {
            InitializeComponent();
        }

        TT_CongTyBLL bllTT_CT = new TT_CongTyBLL();
        CFunction cf = new CFunction();
        string strLogo = "";
        private void btnOK_Click(object sender, EventArgs e)
        {
            TT_CongTyDTO dtoTT_CT = new TT_CongTyDTO();
            string strMaCT = cf.CreateId("MACT", "TT_CONGTY");
            dtoTT_CT.MaCT = strMaCT;
            dtoTT_CT.TenCT = txtTenCongTy.Text;
            dtoTT_CT.MaThue = txtMaSoThue.Text;
            dtoTT_CT.SoTaiKhoan = txtSoTaiKhoan.Text;
            dtoTT_CT.NganHang = txtNganHang.Text;
            dtoTT_CT.SoDT = txtDienThoai.Text;
            dtoTT_CT.Mobile = txtDiDong.Text;
            dtoTT_CT.Email = txtEmail.Text;
            dtoTT_CT.Fax = txtFax.Text;
            dtoTT_CT.WebSite = txtWebsite.Text;
            dtoTT_CT.DiaChi = txtDiaChi.Text;
            dtoTT_CT.LoGo = strLogo;
            string strResult = bllTT_CT.UpdateTT_CongTy(dtoTT_CT);
            if (strResult == "ok")
            {
                MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Thông Tin Công Ty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(strResult, "Cập Nhật Thông Tin Công Ty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All File *.*|*.*|Image File *.png|*.png|Image File Jpeg *.jpg|*.jpg|Image File BitMap *.bmp|*.bmp";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFileName = open.FileName;
                string strPath = System.IO.Directory.GetCurrentDirectory().ToString();                
                strLogo = open.SafeFileName;
                File.Move(strFileName, strPath + "/" + strLogo);
                lbLogo.Image = Image.FromFile(strLogo);
            }
        }
    }
}