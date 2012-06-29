using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class XuatKhoDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertXuatKho(XuatKhoDTO dtoXuatKho)
        {
            string strQuery = "Insert Into XUATKHO Values(";
            strQuery += "N'" + dtoXuatKho.MaXuatKho + "',";
            strQuery += "N'" + dtoXuatKho.MaKhachHang + "',";
            strQuery += "N'" + dtoXuatKho.MaNV + "',";
            strQuery += "N'" + dtoXuatKho.NgayXuat + "',";
            strQuery += "N'" + dtoXuatKho.GiaoHang + "',";
            strQuery += "N'" + dtoXuatKho.LyDoXuat + "',";
            strQuery += "N'" + dtoXuatKho.SoHoaDon + "',";
            strQuery += "N'" + dtoXuatKho.NgayLapHD + "',";
            strQuery += "N'" + dtoXuatKho.MaThue + "',";
            strQuery += dtoXuatKho.ThanhTien + ",";
            strQuery += "N'" + dtoXuatKho.GhiChu + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateXuatKho(XuatKhoDTO dtoXuatKho)
        {
            string strQuery = "Update XUATKHO Set ";
            strQuery += "MAKHACHHANG = N'" + dtoXuatKho.MaKhachHang + "',";
            strQuery += "MANHANVIEN = N'" + dtoXuatKho.MaNV + "',";
            strQuery += "NGAYXUAT = N'" + dtoXuatKho.NgayXuat + "',";
            strQuery += "GIAOHANG = N'" + dtoXuatKho.GiaoHang + "',";
            strQuery += "LYDOXUAT = N'" + dtoXuatKho.LyDoXuat + "',";
            strQuery += "SOHOADON = N'" + dtoXuatKho.SoHoaDon + "',";
            strQuery += "NGAYLAPHOADON = N'" + dtoXuatKho.NgayLapHD + "',";
            strQuery += "GHICHU = N'" + dtoXuatKho.GhiChu + "' ";
            strQuery += "Where MAXUATKHO = N'" + dtoXuatKho.MaXuatKho + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelXuatKho( string strMaXK)
        {
            string strQuery = "Update XUATKHO Set TINHTRANG = 0 Where MAXUATKHO = N'" + strMaXK + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public DataTable TimKiemCongNo(DateTime dtNgayBD, DateTime dtNgayKT, string strKhachHang)
        {
            DataTable dt = new DataTable();
            string strQuery = "Select XK.MAKHACHHANG, SUM(XK.THANHTIEN) AS 'THANHTIEN' From XUATKHO XK ";
            strQuery += "WHERE convert(nvarchar(10), XK.NGAYXUAT, 103) BETWEEN '" + dtNgayBD + "' AND '"+ dtNgayKT +"' and 1 = 1 ";
            if (strKhachHang != "0")
                strQuery += "and XK.MaKhachHang = N'" + strKhachHang + "' ";
            strQuery += "GROUP BY XK.MAKHACHHANG";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }

        public DataTable TimKiemTongXuat(DateTime dtNgayBD, DateTime dtNgayKT, string strMaMatHang)
        {
            DataTable dt = new DataTable();
            string strQuery = "Select ct.MAMATHANG, SUM(ct.SOLUONGXUAT) AS 'SOLUONGXUAT' From XUATKHO xk, CT_XUATKHO ct ";
            strQuery += "WHERE convert(nvarchar(10), xk.NGAYXUAT, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' and ";
            strQuery += "xk.MAXUATKHO = ct.MAXUATKHO and ct.MAMATHANG = N'" + strMaMatHang + "' ";
            strQuery += "GROUP BY ct.MAMATHANG";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }

        public DataTable TimKiemCTCongNo(DateTime dtNgayBD, DateTime dtNgayKT, string strKhachHang)
        {
            DataTable dt = new DataTable();
            string strQuery = "Select * From XUATKHO XK ";
            strQuery += "WHERE convert(nvarchar(10), XK.NGAYXUAT, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' ";
            strQuery += "and XK.MaKhachHang = N'" + strKhachHang + "' ";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }
    }
}
