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
    public partial class FrmNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}