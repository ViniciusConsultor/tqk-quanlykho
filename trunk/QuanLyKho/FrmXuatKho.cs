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
    public partial class FrmXuatKho : DevComponents.DotNetBar.Office2007Form
    {
        public FrmXuatKho()
        {
            InitializeComponent();
        }

        CFunction cf = new CFunction();
        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        MatHangBLL bllMatHang = new MatHangBLL();
        DonViTinhBLL bllDonVITinh = new DonViTinhBLL();
        NhapKhoBLL bllNhapKho = new NhapKhoBLL();
        MucThueBLL bllMucThue = new MucThueBLL();

        private void InitForm()
        {

            try
            {
                string strMaNhapKho = cf.CreateId("MAHDN", "NHAPKHO");
                txtMaPhieuXuat.Text = strMaNhapKho;
                string strMaNhanVien = Variable.strMaNhanVien;
                if (strMaNhanVien == "")
                    strMaNhanVien = "Chưa đăng nhập";
                txtMaNhanVien.Text = strMaNhanVien;

                dtNgayLap.Text = DateTime.Now.ToShortDateString();
                dtNgayNhap.Text = DateTime.Now.ToShortDateString();

                cmbMaNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
                cmbMaNhaCungCap.DisplayMember = "MANHACUNGCAP";
                cmbMaNhaCungCap.ValueMember = "MANHACUNGCAP";

                cmbTenNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
                cmbTenNhaCungCap.DisplayMember = "TENNHACUNGCAP";
                cmbTenNhaCungCap.ValueMember = "MANHACUNGCAP";

                colMaMatHang.DataSource = bllMatHang.GetAllMatHang();
                colMaMatHang.DisplayMember = "MAMATHANG";
                colMaMatHang.ValueMember = "MAMATHANG";

                colTenMatHang.DataSource = bllMatHang.GetAllMatHang();
                colTenMatHang.DisplayMember = "TENMATHANG";
                colTenMatHang.ValueMember = "MAMATHANG";

                colDonViTinh.DataSource = bllDonVITinh.GetDonViTinh();
                colDonViTinh.DisplayMember = "DONVITINH";
                colDonViTinh.ValueMember = "MADONVITINH";

                colMucThue.DataSource = bllMucThue.GetMucThue();
                colMucThue.DisplayMember = "SOTHUE";
                colMucThue.ValueMember = "MATHUE";

            }
            catch { }

        }

        private void FrmXuatKho_Load(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
        