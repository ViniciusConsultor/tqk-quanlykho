using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyKho.Report;
using DTO;
using BLL;

namespace QuanLyKho
{
    public partial class FrmInPhieuChi : DevComponents.DotNetBar.Office2007Form
    {
        public FrmInPhieuChi()
        {
            InitializeComponent();
        }

        private void FrmInPhieuChi_Load(object sender, EventArgs e)
        {
            PhieuChi pc = new PhieuChi();
            PhieuChiDTO dtoPhieuChi = new PhieuChiDTO();
            TT_CongTyBLL bllCty = new TT_CongTyBLL();
            dtoPhieuChi = Variable.dtoPhieuChi;
            pc.SetParameterValue("SoPhieu", dtoPhieuChi.SoPhieu);
            pc.SetParameterValue("No", dtoPhieuChi.No);
            pc.SetParameterValue("Co", dtoPhieuChi.Co);
            pc.SetParameterValue("NguoiNhanTien", dtoPhieuChi.KhachHang);
            pc.SetParameterValue("DiaChiNguoiNhan", dtoPhieuChi.DiaChi);
            pc.SetParameterValue("LyDoChi", dtoPhieuChi.LyDoChi);
            pc.SetParameterValue("TienBangChu", dtoPhieuChi.VietBangChu);
            pc.SetParameterValue("KemTheo", dtoPhieuChi.KemTheo);
            pc.SetParameterValue("SoTien", dtoPhieuChi.SoTien);
            // Lấy thông tin của công ty
            TT_CongTyDTO dtoCty = new TT_CongTyDTO();
            dtoCty = bllCty.GetThongTinDoanhNghiep();
            pc.SetParameterValue("TenCongTy", dtoCty.TenCT);
            pc.SetParameterValue("DiaChi", dtoCty.DiaChi);
            cvrPhieuChi.ReportSource = pc;
        }
    }
}