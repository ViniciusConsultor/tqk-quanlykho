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
    public partial class FrmNhapDonViTinh : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapDonViTinh()
        {
            InitializeComponent();
        }

        DonViTinhBLL bllDVT = new DonViTinhBLL();
        CFunction cf = new CFunction();
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DonViTinhDTO dtoDVT = new DonViTinhDTO();
                string strAction = btnOK.Tag.ToString();
                if (strAction == "add")
                {
                    dtoDVT.MaDVT = txtMaDVT.Text;
                    dtoDVT.DonViTinh = txtDonViTinh.Text;
                    string strResult = bllDVT.InsertDonViTinh(dtoDVT);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Thêm Thành Công!", "Thêm Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dtoDVT.MaDVT = txtMaDVT.Text;
                    dtoDVT.DonViTinh = txtDonViTinh.Text;
                    string strResult = bllDVT.UpdateDonViTinh(dtoDVT);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Cập Nhật Đơn Vị Tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
               
        }

    }
}