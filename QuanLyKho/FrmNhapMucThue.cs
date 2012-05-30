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
    public partial class FrmNhapMucThue : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapMucThue()
        {
            InitializeComponent();
        }
        MucThueBLL bllMucThue = new MucThueBLL();
        CFunction cf = new CFunction();

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                MucThueDTO dtoMucThue = new MucThueDTO();
                string strAction = btnOK.Tag.ToString();
                if (strAction == "add")
                {
                    dtoMucThue.MaTH = txtMaThue.Text;
                    dtoMucThue.SoThue = int.Parse(txtSoThue.Text);
                    dtoMucThue.GhiChu = txtGhiChu.Text;
                    string strResult = bllMucThue.InsertThue(dtoMucThue);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Thêm Thành Công!", "Thêm Mức Thuế", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Mức Thuế", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dtoMucThue.MaTH = txtMaThue.Text;
                    dtoMucThue.SoThue = int.Parse(txtSoThue.Text);
                    dtoMucThue.GhiChu = txtGhiChu.Text;
                    string strResult = bllMucThue.UpdateThue(dtoMucThue);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Mức Thuế", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Cập Nhật Mức Thuế", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}