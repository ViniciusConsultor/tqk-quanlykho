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
        CFunction cf = new CFunction();
        private void FrmPhieuThu_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuKho_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuChiDTO dtoPhieuChi = new PhieuChiDTO();
                string strMaPhieuChi = cf.CreateId("PCHI", "PHIEUCHI");
                dtoPhieuChi.MaPhieuChi = strMaPhieuChi;
                dtoPhieuChi.MaNV = Variable.strMaNhanVien;
                dtoPhieuChi.KhachHang = cmbKhachHang.SelectedValue.ToString();
                dtoPhieuChi.DiaChi = txtDiaChi.Text;
                //Chưa them ngay lập phiếu chi.
                dtoPhieuChi.SoTien = float.Parse(txtSoTien.Text);
                dtoPhieuChi.VietBangChu = txtVietBangChu.Text;
                dtoPhieuChi.LyDoChi = txtLyDoChi.Text;
                dtoPhieuChi.KemTheo = txtKemTheo.Text;
                dtoPhieuChi.SoPhieu = txtSoPhieu.Text;
                dtoPhieuChi.No = int.Parse(txtNo.Text);
                dtoPhieuChi.Co = int.Parse(txtCo.Text);
                string strResult = bllPhieuChi.InsertPhieuChi(dtoPhieuChi);
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
    }
}