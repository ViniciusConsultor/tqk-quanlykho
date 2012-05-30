using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;
using DTO;
using DevComponents.DotNetBar.Controls;
namespace QuanLyKho
{
    public partial class FrmNhapBoPhan : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhapBoPhan()
        {
            InitializeComponent();
        }
        private void LoadBoPhan(DataGridViewX dgv)
        {
            try
            {
                DataTable dtBoPhan = new DataTable();
                dtBoPhan = bllBoPhan.GetBoPhan();
                dtBoPhan = cf.AutoNumberedTable(dtBoPhan);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dtBoPhan;
            }
            catch { }
        }
        BoPhanDTO dtoBoPhan = new BoPhanDTO();
        BoPhanBLL bllBoPhan = new BoPhanBLL();
        CFunction cf = new CFunction();
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string strAction = btnOK.Tag.ToString();
                if (strAction == "add")
                {
                    dtoBoPhan.MaBP = txtMaBP.Text;
                    dtoBoPhan.TenBoPhan = txtTenBP.Text;
                    string strResult = bllBoPhan.InsertBoPhan(dtoBoPhan);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Thêm Thành Công!", "Thêm Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show(strResult, "Thêm Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    dtoBoPhan.MaBP = txtMaBP.Text;
                    dtoBoPhan.TenBoPhan = txtTenBP.Text;
                    string strResult = bllBoPhan.UpdateBoPhan(dtoBoPhan);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Thành Công!", "Cập Nhật Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Cập Nhật Bộ Phận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}