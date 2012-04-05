using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyKho
{
    public partial class FrmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNhomHang_Click(object sender, EventArgs e)
        {
            
        }
    }
}