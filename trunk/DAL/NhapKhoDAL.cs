using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class NhapKhoDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertNhapKho(NhapKhoDTO dtoNhapKho)
        {
            string strQuery = "Insert Into NHAPKHO Values(";
            strQuery += "N'" + dtoNhapKho.MaNhapKho + "',";
            strQuery += "N'" + dtoNhapKho.MaNCC + "',";
            strQuery += "N'" + dtoNhapKho.MaNV + "',";
            strQuery += "N'" + dtoNhapKho.NgayNhap + "',";
            strQuery += "N'" + dtoNhapKho.NguoiNhan + "',";
            strQuery += "N'" + dtoNhapKho.LyDoNhap + "',";
            strQuery += "N'" + dtoNhapKho.SoHoaDon + "',";
            strQuery += "N'" + dtoNhapKho.NgayLapHD + "',";
            strQuery += "N'" + dtoNhapKho.MaThue + "',";
            strQuery += dtoNhapKho.ThanhTien + ",";
            strQuery += "N'" + dtoNhapKho.GhiChu + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateNhapKho(NhapKhoDTO dtoNhapKho)
        {
            string strQuery = "update NHAPKHO Set ";
            strQuery += "MANHACUNGCAP = N'" + dtoNhapKho.MaNCC + "',";
            strQuery += "MANHANVIEN = N'" + dtoNhapKho.MaNV + "',";
            strQuery += "NGAYNHAP = N'" + dtoNhapKho.NgayNhap + "',";
            strQuery += "NGUOINHAN = N'" + dtoNhapKho.NguoiNhan + "',";
            strQuery += "LYDONHAP = N'" + dtoNhapKho.LyDoNhap + "',";
            strQuery += "SOHOADON = N'" +dtoNhapKho.SoHoaDon + ",";
            strQuery += "NGAYLAPHOADON = N'" + dtoNhapKho.NgayLapHD + "',";
            strQuery += "GHICHU = N'" + dtoNhapKho.GhiChu + "' ";
            strQuery += "Where MANHAPKHO = N'" + dtoNhapKho.MaNhapKho + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelNhapKho(string strMaNK)
        {
            string strQuery = "Update NHAPKHO Set TINHTRANG = 0 Where MANHAPKHO = N'" + strMaNK + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public DataTable TimKiemDuNo(DateTime dtNgayBD, DateTime dtNgayKT, string strNhaCungCap)
        {
            DataTable dt = new DataTable();
            string strQuery = "Select NK.MANHACUNGCAP, SUM(NK.THANHTIEN) AS 'THANHTIEN'  From NHAPKHO NK ";
            strQuery += "WHERE convert(nvarchar(10), NK.NGAYNHAP, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' and 1 = 1 ";
            if (strNhaCungCap != "0")
                strQuery += "and NK.MANHACUNGCAP = N'" + strNhaCungCap + "' ";
            strQuery += "GROUP BY NK.MANHACUNGCAP";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }

        public DataTable TimKiemTongNhap(DateTime dtNgayBD, DateTime dtNgayKT, string strMaMatHang)
        {
            DataTable dt = new DataTable();
            string strQuery = "Select ct.MAMATHANG, SUM(ct.SOLUONGNHAP) AS 'SOLUONGNHAP' From NHAPKHO nk, CT_NHAPKHO ct ";
            strQuery += "WHERE convert(nvarchar(10), NK.NGAYNHAP, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' and ";
            strQuery += "nk.MANHAPKHO = ct.MANHAPKHO and ct.MAMATHANG = N'" + strMaMatHang + "' ";
            strQuery += "GROUP BY ct.MAMATHANG";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }

        public DataTable TimKiemCTDuNo(DateTime dtNgayBD, DateTime dtNgayKT, string strNhaCungCap)
        {
            DataTable dt = new DataTable();
            string strQuery = "Select * From NHAPKHO NK ";
            strQuery += "WHERE convert(nvarchar(10), NK.NGAYNHAP, 103) BETWEEN '" + dtNgayBD + "' AND '" + dtNgayKT + "' ";
            strQuery += "and NK.MANHACUNGCAP = N'" + strNhaCungCap + "' ";
            dt = dp.ExecuteQuery(strQuery);
            return dt;
        }

    }
}
