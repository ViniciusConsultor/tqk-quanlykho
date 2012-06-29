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
    public partial class FrmCNCongNoNCC : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCNCongNoNCC()
        {
            InitializeComponent();
        }

        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        CFunction cf = new CFunction();

        private void FrmCNCongNoNCC_Load(object sender, EventArgs e)
        {
            DataTable dtNhaCungCap = new DataTable();
            dtNhaCungCap = bllNhaCungCap.GetAllNhaCungCap();
            dtNhaCungCap = cf.AutoNumberedTable(dtNhaCungCap);
            dgvNhaCungCap.AutoGenerateColumns = false;
            dgvNhaCungCap.DataSource = dtNhaCungCap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNhaCungCap.RowCount; i++)
            {
                string strMaNhaCungCap = dgvNhaCungCap.Rows[i].Cells[1].Value.ToString();
                string strDuNo = dgvNhaCungCap.Rows[i].Cells[4].Value.ToString();
                if (strDuNo == "")
                    strDuNo = "0";
                double dbDuNo = double.Parse(strDuNo);
                bool blResult = bllNhaCungCap.UpdateCongNo(strMaNhaCungCap, dbDuNo);
                if (blResult == false)
                    MessageBox.Show("Nhà cung cấp có mã " + strMaNhaCungCap + " không cập nhật được", "Thông báo");
            }
            MessageBox.Show("Đã xong", "Thông báo");
        }
    }
}