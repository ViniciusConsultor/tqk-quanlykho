using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using DAL;

namespace QuanLyKho
{
    public partial class FrmNhapMatHang : DevComponents.DotNetBar.Office2007Form
    {
        DataProvider dp = new DataProvider();
        MatHangDTO dtoMatHang = new MatHangDTO();
        MatHangDAL dalMatHang = new  MatHangDAL();
        NhomHangDAL dalNhomHang = new NhomHangDAL();
        KhoHangDAL dalkhoHang = new KhoHangDAL();
        DonViTinhDAL dalDonViTinh = new DonViTinhDAL();
        CFunction cf = new CFunction();
        public FrmNhapMatHang()
        {
            InitializeComponent();
        }

        private void FrmNhapMatHang_Load(object sender, EventArgs e)
        {
            cmbNhomHang.DataSource = dalNhomHang.GetNhomHang();
            cmbNhomHang.ValueMember = "MANHOMHANG";
            cmbNhomHang.DisplayMember = "TENNHOMHANG";

            cmbKhoHang.DataSource = dalkhoHang.GetAllKhoHang();
            cmbKhoHang.ValueMember = "MAKHO";
            cmbKhoHang.DisplayMember = "TENKHO";

            cmbDonViTinh.DataSource = dalDonViTinh.GetDonViTinh();
            cmbDonViTinh.ValueMember = "MADONVITINH";
            cmbDonViTinh.DisplayMember = "DONVITINH";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string strAction = btnThem.Tag.ToString();
            if (strAction == "add")
            {
                dtoMatHang.MaMH = txtMaMH.Text;
                dtoMatHang.MaNH = cmbNhomHang.SelectedValue.ToString();
                dtoMatHang.MaKho = cmbKhoHang.SelectedValue.ToString();
                dtoMatHang.TenMH = txtTenMH.Text;
                dtoMatHang.MaDonViTinh = cmbDonViTinh.SelectedValue.ToString();
                dtoMatHang.TonDau = float.Parse(txtTonDau.Text);
                dtoMatHang.MoTa = txtMoTa.Text;
                dalMatHang.InsertMatHang(dtoMatHang);
                MessageBox.Show("Thêm Mặt Hàng Thành Công!","Thêm Mặt Hàng", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                dtoMatHang.MaMH = txtMaMH.Text;
                dtoMatHang.MaNH = cmbNhomHang.SelectedValue.ToString();
                dtoMatHang.MaKho = cmbKhoHang.SelectedValue.ToString();
                dtoMatHang.TenMH = txtTenMH.Text;
                dtoMatHang.MaDonViTinh = cmbDonViTinh.SelectedValue.ToString();
                dtoMatHang.TonDau = float.Parse(txtTonDau.Text);
                dtoMatHang.MoTa = txtMoTa.Text;
                dalMatHang.UpdateMatHang(dtoMatHang);
                MessageBox.Show("Cập Nhật Mặt Hàng Thành Công!", "Cập Nhật Mặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }
    }
}