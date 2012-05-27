using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;


namespace QuanLyKho
{
    public partial class FrmNhapKho : DevComponents.DotNetBar.Office2007Form
    {

        CFunction cf = new CFunction();

        public FrmNhapKho()
        {
            InitializeComponent();
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            dtNgayLap.Text = DateTime.Now.ToShortDateString();
            dtNgayNhap.Text = DateTime.Now.ToShortDateString();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
            frmNhapNCC.btnThem.Tag = "add";
            string strMaNCC = cf.CreateId("CCA", "NHACUNGCAP");
            frmNhapNCC.txtMaNCC.Text = strMaNCC;
            frmNhapNCC.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //rptNhanKho 
        }
    }
}