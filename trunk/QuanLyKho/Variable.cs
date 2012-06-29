using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using DTO;

namespace QuanLyKho
{
    public class Variable
    {
        public static string strMaNhanVien = "MANV007";
        public static string strTenNhanVien = "";
        public static string strMatKhau = "";
        public static int intSelectedIndexPhieuChi = 0;
        public static int intSelectedIndexPhieuThu = 0;
        public static SuperTabItem stiSelected = new SuperTabItem();
        public static PhieuChiDTO dtoPhieuChi = new PhieuChiDTO();
        public static PhieuThuDTO dtoPhieuThu = new PhieuThuDTO();
    }
}
