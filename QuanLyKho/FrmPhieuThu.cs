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
    public partial class FrmPhieuThu : DevComponents.DotNetBar.Office2007Form
    {
        public FrmPhieuThu()
        {
            InitializeComponent();
        }

        KhachHangBLL bllKhachHang = new KhachHangBLL();
        PhieuThuBLL bllPhieuThu = new PhieuThuBLL();
        CFunction cf = new CFunction();
        private void FrmPhieuThu_Load(object sender, EventArgs e)
        {
            cmbKhachHang.DataSource = bllKhachHang.GetAllKhachHang();
            cmbKhachHang.ValueMember = "MAKHACHHANG";
            cmbKhachHang.DisplayMember = "TENKHACHHANG";
            string strNgayThang = "Ngày " + DateTime.Today.Day.ToString();
            strNgayThang += " tháng " + DateTime.Today.Month.ToString();
            strNgayThang += " năm " + DateTime.Today.Year.ToString();
            lbNgay.Text = lbNgayThang.Text = strNgayThang;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapKhachHang frmNhapKhachHang = new FrmNhapKhachHang();
                frmNhapKhachHang.btnThemKhachHang.Tag = "add";
                string strMaKH = cf.CreateId("KHA", "KHACHHANG");
                frmNhapKhachHang.txtMaKH.Text = strMaKH.ToString();
                frmNhapKhachHang.ShowDialog();
            }
            catch { }
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDKhachHang = cmbKhachHang.SelectedValue.ToString();
                int index = cmbKhachHang.SelectedIndex;
                KhachHangDTO dtoKhachHang = bllKhachHang.GetKhachHangByID(strIDKhachHang);
                txtDiaChi.Text = dtoKhachHang.DiaChi;
                cmbKhachHang.SelectedIndex = index;
            }
            catch { }
        }

        private void btnLuuKho_Click(object sender, EventArgs e)
        {
            PhieuThuDTO dtoPhieuThu = new PhieuThuDTO();
            string strMaPT = cf.CreateId("PTHU", "PHIEUTHU");
            dtoPhieuThu.MaPhieuThu = strMaPT;
            dtoPhieuThu.MaNV = Variable.strMaNhanVien;
            dtoPhieuThu.KhachHang = cmbKhachHang.SelectedValue.ToString();
            dtoPhieuThu.NgayLap = lbNgay.Text;
            dtoPhieuThu.DiaChi = txtDiaChi.Text;
            dtoPhieuThu.LyDoThu = txtLyDoThu.Text;
            dtoPhieuThu.SoTien = float.Parse(txtSoTien.Text);
            dtoPhieuThu.SoPhieu = txtSoPhieu.Text;
            dtoPhieuThu.No = int.Parse(txtNo.Text);
            dtoPhieuThu.Co = int.Parse(txtCo.Text);
            dtoPhieuThu.VietBangChu = txtVietBangChu.Text;
            dtoPhieuThu.KemTheo = txtKemTheo.Text;
            string strResult = bllPhieuThu.InsertPhieuThu(dtoPhieuThu);
            if (strResult == "ok")
            {
                MessageBox.Show("Lưu Thành Công!", "Lưu Phiếu Thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(strResult,"Lưu Phiếu Thu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}