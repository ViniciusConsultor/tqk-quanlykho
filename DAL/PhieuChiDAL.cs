using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
namespace DAL
{
    public class PhieuChiDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertPhieuChi(PhieuChiDTO dtoPhieuChi)
        {
            string strQuery = "Insert Into PHIEUCHI Values(";
            strQuery += "N'" + dtoPhieuChi.MaPhieuChi + "',";
            strQuery += "N'" + dtoPhieuChi.MaNV + "',";
            strQuery += "N'" + dtoPhieuChi.KhachHang + "',";
            strQuery += "N'" + dtoPhieuChi.NgayLap + "',";
            strQuery += "N'" + dtoPhieuChi.DiaChi + "',";
            strQuery += "N'" + dtoPhieuChi.SoPhieu + "',";
            strQuery +=  dtoPhieuChi.No + ",";
            strQuery +=  dtoPhieuChi.Co + ",";
            strQuery += "N'" + dtoPhieuChi.LyDoChi + "',";
            strQuery +=  dtoPhieuChi.SoTien + ",";
            strQuery += "N'" + dtoPhieuChi.VietBangChu + "',";
            strQuery += "N'" + dtoPhieuChi.KemTheo + "')";
            return dp.ExecuteNonQuery(strQuery);
        }

        public DataTable TimKiem(string strIDNhaCungCap, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT PC.KHACHHANG, SUM(PC.SOTIEN) AS 'THANHTIEN' From PHIEUCHI PC ";
            strQuery += "WHERE convert(nvarchar(10), PC.NGAYLAP, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' ";
            strQuery += "and PC.KHACHHANG = N'" + strIDNhaCungCap + "' ";
            strQuery += "GROUP BY PC.KHACHHANG";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }

        public DataTable TimKiemChiTiet(string strIDNhaCungCap, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * From PHIEUCHI PC ";
            strQuery += "WHERE convert(nvarchar(10), PC.NGAYLAP, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' ";
            strQuery += "and PC.KHACHHANG = N'" + strIDNhaCungCap + "' ";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }
    }
}
