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
    public partial class FrmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        NhanVienDTO dtoNhanVien = new NhanVienDTO();
        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginBLL logBLL = new LoginBLL();
            string strError = "";
            if (txtMaNV.Text.Trim().Equals("") == true)
            {
                strError += "Mã nhân viên không được rỗng.";
            }
            if (txtPassword.Text.Trim().Equals("") == true)
            {
                strError += " Password không được rỗng.";
            }
            if (strError != "")
            {
                MessageBox.Show(strError, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string strResult = logBLL.Login(txtMaNV.Text, txtPassword.Text);
                if (strResult == "404")
                {
                    MessageBox.Show("Mã nhân viên hoặc password không tồn tại.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Variable.strMaNhanVien = txtMaNV.Text;
                    Variable.strTenNhanVien = strResult;
                    FrmMain frmMain = new FrmMain();
                    frmMain.ShowDialog();
                    
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}