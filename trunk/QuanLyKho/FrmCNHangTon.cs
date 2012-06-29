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
    public partial class FrmCNHangTon : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCNHangTon()
        {
            InitializeComponent();
        }

        CFunction cf = new CFunction();
        MatHangBLL bllMatHang = new MatHangBLL();

        private void FrmCapNhatHangTon_Load(object sender, EventArgs e)
        {
            DataTable dtMatHang = new DataTable();
            dtMatHang = bllMatHang.GetAllMatHang();
            dtMatHang = cf.AutoNumberedTable(dtMatHang);
            dgvResults.AutoGenerateColumns = false;
            dgvResults.DataSource = dtMatHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvResults.RowCount > 0)
                dgvResults.Rows.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvResults.RowCount; i++)
            {
                string strMaMatHang = dgvResults.Rows[i].Cells[1].Value.ToString();
                int intTonDau = int.Parse(dgvResults.Rows[i].Cells[3].Value.ToString());
                int intSLTon = int.Parse(dgvResults.Rows[i].Cells[4].Value.ToString());
                bool blKetQua = bllMatHang.UpdateHangTon(strMaMatHang, intTonDau, intSLTon);
                if (blKetQua == false)
                    MessageBox.Show("Mã hàng " + strMaMatHang + " không cập nhật được", "Thông báo");
            }
            MessageBox.Show("Đã Xong","Thông báo");
        }
    }
}