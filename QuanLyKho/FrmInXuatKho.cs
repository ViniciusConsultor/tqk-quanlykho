using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyKho.Report;

namespace QuanLyKho
{
    public partial class FrmInXuatKho : DevComponents.DotNetBar.Office2007Form
    {
        public FrmInXuatKho()
        {
            InitializeComponent();
        }

        private void FrmInXuatKho_Load(object sender, EventArgs e)
        {
            string strMaXuatkho = this.Tag.ToString();
            crpXuatKho crp = new crpXuatKho();
            crp.SetParameterValue("MaXuatKho", strMaXuatkho);
            crvInXuatKho.ReportSource = crp;
        }
    }
}