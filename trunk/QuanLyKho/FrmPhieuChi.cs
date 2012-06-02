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
    public partial class FrmPhieuChi : DevComponents.DotNetBar.Office2007Form
    {
        public FrmPhieuChi()
        {
            InitializeComponent();
        }
        PhieuChiBLL bllPhieuChi = new PhieuChiBLL();
        NhaCungCapBLL bllNhaCungCap = new NhaCungCapBLL();
        CFunction cf = new CFunction();
        private void FrmPhieuThu_Load(object sender, EventArgs e)
        {
            try
            {
                cmbNhaCC.DataSource = bllNhaCungCap.GetAllNhaCungCap();
                cmbNhaCC.ValueMember = "MANHACUNGCAP";
                cmbNhaCC.DisplayMember = "TENNHACUNGCAP";
                string strNgayThang = "Ngày " + DateTime.Today.Day.ToString();
                strNgayThang += " tháng " + DateTime.Today.Month.ToString();
                strNgayThang += " năm " + DateTime.Today.Year.ToString();
                lbNgay.Text = lbNgayThang.Text = strNgayThang;
            }
            catch { }   
        }

        private void btnLuuKho_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuChiDTO dtoPhieuChi = new PhieuChiDTO();
                string strMaPhieuChi = cf.CreateId("PCHI", "PHIEUCHI");
                dtoPhieuChi.MaPhieuChi = strMaPhieuChi;
                dtoPhieuChi.MaNV = Variable.strMaNhanVien;
                dtoPhieuChi.KhachHang = cmbNhaCC.SelectedValue.ToString();
                dtoPhieuChi.DiaChi = txtDiaChi.Text;
                dtoPhieuChi.NgayLap = lbNgay.Text;
                dtoPhieuChi.SoTien = float.Parse(txtSoTien.Text);
                dtoPhieuChi.VietBangChu = txtVietBangChu.Text;
                dtoPhieuChi.LyDoChi = txtLyDoChi.Text;
                dtoPhieuChi.KemTheo = txtKemTheo.Text;
                dtoPhieuChi.SoPhieu = txtSoPhieu.Text;
                dtoPhieuChi.No = int.Parse(txtNo.Text);
                dtoPhieuChi.Co = int.Parse(txtCo.Text);
                string strResult = bllPhieuChi.InsertPhieuChi(dtoPhieuChi);
                LuuPhieuChi();
                if (strResult == "ok")
                {
                    MessageBox.Show("Lưu Phiếu Chi Thành Công!", "Lưu Phiếu Chi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(strResult, "Lưu Phiếu Chi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            catch { }
        }

        private void cmbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strIDNhaCungCap = cmbNhaCC.SelectedValue.ToString();
                int intIndexSelect = cmbNhaCC.SelectedIndex;
                NhaCungCapDTO dtoNhaCungCap = bllNhaCungCap.GetNhaCungCapByID(strIDNhaCungCap);
                txtDiaChi.Text = dtoNhaCungCap.DiaChi;
                cmbNhaCC.SelectedIndex = intIndexSelect;
            }
            catch { }
        }

        private void btnThemNhaCC_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapNCC frmNhapNCC = new FrmNhapNCC();
                frmNhapNCC.btnThem.Tag = "add";
                string strMaNCC = cf.CreateId("CCA", "NHACUNGCAP");
                frmNhapNCC.txtMaNCC.Text = strMaNCC;
                frmNhapNCC.ShowDialog();
            }
            catch { }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmInPhieuChi frm = new FrmInPhieuChi();
            try
            {
                LuuPhieuChi();
            }
            catch {
                frm.ShowDialog();
            }
            frm.ShowDialog();
        }

        private void LuuPhieuChi()
        {
            PhieuChiDTO dtoPhieuChi = new PhieuChiDTO();
            if (txtCo.Text != "")
                dtoPhieuChi.Co = int.Parse(txtCo.Text);
            else
                dtoPhieuChi.Co = 0;
            if (txtNo.Text != "")
                dtoPhieuChi.No = int.Parse(txtNo.Text);
            else
                dtoPhieuChi.No = 0;
            dtoPhieuChi.No = int.Parse(txtNo.Text);
            dtoPhieuChi.DiaChi = txtDiaChi.Text;
            dtoPhieuChi.KemTheo = txtKemTheo.Text;
            dtoPhieuChi.KhachHang = cmbNhaCC.Text;
            dtoPhieuChi.LyDoChi = txtLyDoChi.Text;
            dtoPhieuChi.SoPhieu = txtSoPhieu.Text;
            dtoPhieuChi.SoTien = double.Parse(txtSoTien.Text);
            dtoPhieuChi.VietBangChu = txtVietBangChu.Text;
            Variable.dtoPhieuChi = dtoPhieuChi;
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) == false && Char.IsControl(c) == false)
            {
                e.Handled = true;
            }
        }

        private void txtCo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) == false && Char.IsControl(c) == false)
            {
                e.Handled = true;
            }
        }
    }
}