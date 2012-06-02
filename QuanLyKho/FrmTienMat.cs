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
    public partial class FrmTienMat : DevComponents.DotNetBar.Office2007Form
    {
        public FrmTienMat()
        {
            InitializeComponent();
        }
        TienMatBLL bllTienMat = new TienMatBLL();
        private void txtTienMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) == false && Char.IsControl(c) == false)
            {
                e.Handled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TienMatDTO dtoTienMat = new TienMatDTO();
            dtoTienMat.SoTien = txtTienMat.Value;
            bllTienMat.UpdateTienMat(dtoTienMat);
            MessageBox.Show("Cập Nhật Thành Công!","Cập Nhật Tiền Mắt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmTienMat_Load(object sender, EventArgs e)
        {
            TienMatDTO dtoTienMat = new TienMatDTO();
            dtoTienMat = bllTienMat.GetTienMat();
            txtTienMat.Text = dtoTienMat.SoTien.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}