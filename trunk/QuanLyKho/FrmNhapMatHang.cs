using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using BLL;

namespace QuanLyKho
{
    public partial class FrmNhapMatHang : DevComponents.DotNetBar.Office2007Form
    {
        
        MatHangBLL bllMatHang = new  MatHangBLL();
        NhomHangBLL bllNhomHang = new NhomHangBLL();
        KhoHangBLL bllkhoHang = new KhoHangBLL();
        DonViTinhBLL bllDonViTinh = new DonViTinhBLL();
        CFunction cf = new CFunction();
        public FrmNhapMatHang()
        {
            InitializeComponent();
        }

        private void FrmNhapMatHang_Load(object sender, EventArgs e)
        {
            try
            {
                cmbNhomHang.DataSource = bllNhomHang.GetNhomHang();
                cmbNhomHang.ValueMember = "MANHOMHANG";
                cmbNhomHang.DisplayMember = "TENNHOMHANG";

                cmbKhoHang.DataSource = bllkhoHang.GetAllKhoHang();
                cmbKhoHang.ValueMember = "MAKHO";
                cmbKhoHang.DisplayMember = "TENKHO";

                cmbDonViTinh.DataSource = bllDonViTinh.GetDonViTinh();
                cmbDonViTinh.ValueMember = "MADONVITINH";
                cmbDonViTinh.DisplayMember = "DONVITINH";
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MatHangDTO dtoMatHang = new MatHangDTO();
                string strAction = btnThem.Tag.ToString();
                if (strAction == "add")
                {
                    dtoMatHang.MaMH = txtMaMH.Text;
                    dtoMatHang.MaNH = cmbNhomHang.SelectedValue.ToString();
                    dtoMatHang.MaKho = cmbKhoHang.SelectedValue.ToString();
                    dtoMatHang.TenMH = txtTenMH.Text;
                    dtoMatHang.MaDonViTinh = cmbDonViTinh.SelectedValue.ToString();
                    dtoMatHang.TonDau = txtTonDau.Value;
                    dtoMatHang.MoTa = txtMoTa.Text;
                    string strResult = bllMatHang.InsertMatHang(dtoMatHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Thêm Mặt Hàng Thành Công!", "Thêm Mặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Thêm Mặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                    string strResult = bllMatHang.UpdateMatHang(dtoMatHang);
                    if (strResult == "ok")
                    {
                        MessageBox.Show("Cập Nhật Mặt Hàng Thành Công!", "Cập Nhật Mặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strResult, "Cập Nhật Mặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch { }
        }

    }
}