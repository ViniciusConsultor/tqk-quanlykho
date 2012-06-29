using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
namespace DAL
{
    public class PhieuThuDAL
    {
        DataProvider dp = new DataProvider();
        public bool InsertPhieuThu(PhieuThuDTO dtoPhieuThu)
        {
            string strQuery = "Insert Into PHIEUTHU Values(";
            strQuery += "N'" + dtoPhieuThu.MaPhieuThu + "',";
            strQuery += "N'" + dtoPhieuThu.MaNV + "',";
            strQuery += "N'" + dtoPhieuThu.KhachHang + "',";
            strQuery += "N'" + dtoPhieuThu.NgayLap + "',";
            strQuery += "N'" + dtoPhieuThu.DiaChi + "',";
            strQuery += "N'" + dtoPhieuThu.SoPhieu + "',";
            strQuery += dtoPhieuThu.No + ",";
            strQuery += dtoPhieuThu.Co + ",";
            strQuery += "N'" + dtoPhieuThu.LyDoThu + "',";
            strQuery += dtoPhieuThu.SoTien + ",";
            strQuery += "N'" + dtoPhieuThu.VietBangChu + "',";
            strQuery += "N'" + dtoPhieuThu.KemTheo + "')";
            return dp.ExecuteNonQuery(strQuery);
        }

        public DataTable TimKiem(string strIDKhachHang, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT PT.KHACHHANG, SUM(PT.SOTIEN) AS 'THANHTIEN' From PHIEUTHU PT ";
            strQuery += "WHERE convert(nvarchar(10), PT.NGAYLAP, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' ";
            strQuery += "and PT.KHACHHANG = N'" + strIDKhachHang + "' ";
            strQuery += "GROUP BY PT.KHACHHANG";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }

        public DataTable TimKiemChiTiet(string strIDKhachHang, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * From PHIEUTHU PT ";
            strQuery += "WHERE convert(nvarchar(10), PT.NGAYLAP, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' ";
            strQuery += "and PT.KHACHHANG = N'" + strIDKhachHang + "' ";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }
    }
}
