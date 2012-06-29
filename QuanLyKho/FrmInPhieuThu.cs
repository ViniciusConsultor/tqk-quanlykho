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
    public partial class FrmInPhieuThu : DevComponents.DotNetBar.Office2007Form
    {
        public FrmInPhieuThu()
        {
            InitializeComponent();
        }

        private void FrmInPhieuThu_Load(object sender, EventArgs e)
        {
            crpPhieuThu pc = new crpPhieuThu();
            PhieuThuDTO dtoPhieuThu = new PhieuThuDTO();
            TT_CongTyBLL bllCty = new TT_CongTyBLL();
            dtoPhieuThu = Variable.dtoPhieuThu;
            pc.SetParameterValue("SoPhieu", dtoPhieuThu.SoPhieu);
            pc.SetParameterValue("NguoiNhanTien", dtoPhieuThu.KhachHang);
            pc.SetParameterValue("DiaChiNguoiNhan", dtoPhieuThu.DiaChi);
            pc.SetParameterValue("LyDoChi", dtoPhieuThu.LyDoThu);
            pc.SetParameterValue("TienBangChu", dtoPhieuThu.VietBangChu);
            pc.SetParameterValue("KemTheo", dtoPhieuThu.KemTheo);
            pc.SetParameterValue("SoTien", dtoPhieuThu.SoTien);
             TT_CongTyDTO dtoCty = new TT_CongTyDTO();
            dtoCty = bllCty.GetThongTinDoanhNghiep();
            pc.SetParameterValue("TenCongTy", dtoCty.TenCT);
            pc.SetParameterValue("DiaChi", dtoCty.DiaChi);
            cvrPhieuThu.ReportSource = pc;

        }
    }
}