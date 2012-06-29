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
    public partial class FrmCNCongNoKH : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCNCongNoKH()
        {
            InitializeComponent();
        }

        KhachHangBLL bllKhachHang = new KhachHangBLL();
        CFunction cf = new CFunction();

        private void FrmCNCongNoKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = bllKhachHang.GetAllKhachHang();
            dtKhachHang = cf.AutoNumberedTable(dtKhachHang);
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = dtKhachHang;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvKhachHang.RowCount; i++)
            {
                string strMaKhachHang = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                string strDuNo = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
                if (strDuNo == "")
                    strDuNo = "0";
                double dbDuNo = double.Parse(strDuNo);
                bool blResult = bllKhachHang.UpdateCongNo(strMaKhachHang, dbDuNo);
                if (blResult == false)
                    MessageBox.Show("Khách hàng có mã " + strMaKhachHang + " không cập nhật được", "Cập nhật");
            }
            MessageBox.Show("Đã cập nhật xong","Cập nhật");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Function.CloseForm();
        }
    }
}