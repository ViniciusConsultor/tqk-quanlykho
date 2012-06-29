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
            LoadKhachHang();
            string strMaPT = cf.CreateId("THU", "PHIEUTHU");
            txtSoPhieu.Text = strMaPT;
            string strNgayThang = "Ngày " + DateTime.Today.Day.ToString();
            strNgayThang += " tháng " + DateTime.Today.Month.ToString();
            strNgayThang += " năm " + DateTime.Today.Year.ToString();
        }

        private void LoadKhachHang()
        {
            cmbKhachHang.DataSource = bllKhachHang.GetAllKhachHang();
            cmbKhachHang.ValueMember = "MAKHACHHANG";
            cmbKhachHang.DisplayMember = "TENKHACHHANG";
            cmbKhachHang.SelectedIndex = Variable.intSelectedIndexPhieuThu;
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
            dtoPhieuThu.MaPhieuThu = txtSoPhieu.Text;
            dtoPhieuThu.MaNV = Variable.strMaNhanVien;
            dtoPhieuThu.KhachHang = cmbKhachHang.SelectedValue.ToString();
            dtoPhieuThu.NgayLap = dtpNgayThu.Value.ToShortDateString();
            dtoPhieuThu.DiaChi = txtDiaChi.Text;
            dtoPhieuThu.LyDoThu = txtLyDoThu.Text;
            dtoPhieuThu.SoTien = float.Parse(txtSoTien.Text);
            dtoPhieuThu.SoPhieu = txtSoPhieu.Text;
            dtoPhieuThu.VietBangChu = txtVietBangChu.Text;
            dtoPhieuThu.KemTheo = txtKemTheo.Text;
            string strResult = bllPhieuThu.InsertPhieuThu(dtoPhieuThu);
            if (strResult == "ok")
            {
                MessageBox.Show("Lưu Thành Công!", "Lưu Phiếu Thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIn.Enabled = true;
            }
            else
            {
                MessageBox.Show(strResult,"Lưu Phiếu Thu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmInPhieuThu frm = new FrmInPhieuThu();
            try
            {
                LuuPhieuThu();
            }
            catch
            {
                frm.ShowDialog();
            }
            frm.ShowDialog();
        }

        private void LuuPhieuThu()
        {
            PhieuThuDTO dtoPhieuThu = new PhieuThuDTO();
            dtoPhieuThu.DiaChi = txtDiaChi.Text;
            dtoPhieuThu.KemTheo = txtKemTheo.Text;
            dtoPhieuThu.KhachHang = cmbKhachHang.Text;
            dtoPhieuThu.LyDoThu = txtLyDoThu.Text;
            dtoPhieuThu.SoPhieu = txtSoPhieu.Text;
            dtoPhieuThu.SoTien = double.Parse(txtSoTien.Text);
            dtoPhieuThu.VietBangChu = txtVietBangChu.Text;
            Variable.dtoPhieuThu = dtoPhieuThu;
        }
    }
}