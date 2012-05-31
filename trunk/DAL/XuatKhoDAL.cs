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
            strQuery += dtoXuatKho.SoHoaDon;
            strQuery += "N'" + dtoXuatKho.NgayLapHD + "',";
            strQuery += "N'" + dtoXuatKho.GhiChu + "',1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateXuatKho(XuatKhoDTO dtoXuatKho)
        {
            string strQuery = "Update XUATKHO Set ";
            strQuery += "MAKHACHHANG = N'" + dtoXuatKho.MaKhachHang + "',";
            strQuery += "MANHANVIEN = N'" + dtoXuatKho.MaNV + "',";
            strQuery += "NGAYXUAT = N'" + dtoXuatKho.NgayXuat + "',";
            strQuery += "SOHOADON = " + dtoXuatKho.SoHoaDon;
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
    }
}
