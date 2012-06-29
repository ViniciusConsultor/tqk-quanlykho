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
    public partial class FrmInNhapKho : DevComponents.DotNetBar.Office2007Form
    {
        public FrmInNhapKho()
        {
            InitializeComponent();
        }

        private void FrmInNhapHang_Load(object sender, EventArgs e)
        {
            string strMaNhapkho = this.Tag.ToString();
            crpNhapKho crp = new crpNhapKho();
            crp.SetParameterValue("MaNhapKho",strMaNhapkho);
            crvInNhapKho.ReportSource = crp;
        }
    }
}