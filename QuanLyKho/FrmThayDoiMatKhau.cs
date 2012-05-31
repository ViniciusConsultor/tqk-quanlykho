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
    public partial class FrmThayDoiMatKhau : DevComponents.DotNetBar.Office2007Form
    {
        public FrmThayDoiMatKhau()
        {
            InitializeComponent();
        }
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        LoginBLL bllLogin = new LoginBLL();
        private void FrmThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = Variable.strMaNhanVien;
            txtTenNhanVien.Text = Variable.strTenNhanVien;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strError = "";
            if (txtMatKhauCu.Text.Trim().Equals("") == true)
            {
                strError += " Bạn phải nhập mật khẩu cũ.";
            }
            else
            {
                if (txtMatKhauCu.Text != Variable.strMatKhau)
                    strError += " Mật khẩu cũ không đúng.";
            }
            if (txtMatKhauMoi.Text.Trim().Equals("") == true)
            {
                strError += " Mật khẩu không được rỗng.";
            }
            if (txtNhapLaiMK.Text.Trim().Equals("") == true)
            {
                strError += " Bạn phải nhập lại mật khẩu mới.";
            }
            else
            {
                if (txtMatKhauMoi.Text != txtNhapLaiMK.Text)
                    strError += " Mật khẩu nhập lại không đúng";
            }
            if (strError == "")
            {
                bool boolResult = bllNhanVien.UpdateMatkhau(txtMaNhanVien.Text, txtMatKhauMoi.Text);
                MessageBox.Show("Thay Đổi Mật Khẩu Thành Công!","Thay Đổi Mật Khẩu", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(strError, "Thay Đổi Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}