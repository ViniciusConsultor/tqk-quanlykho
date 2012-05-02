using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class TonKhoDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertTonKho(TonKhoDTO dtoTonKho)
        {
            string strQuery = "Insert Into TONKHO Values(";
            strQuery += "N'" + dtoTonKho.MaTonKho + "',";
            strQuery += "N'" + dtoTonKho.NgayThang + "',";
            strQuery += "N'" + dtoTonKho.MaMatHang + "',";
            strQuery += dtoTonKho.SoLuongDau;
            strQuery += dtoTonKho.SoLuongNhap;
            strQuery += dtoTonKho.SoLuongXuat;
            strQuery += dtoTonKho.SoLuongTon;
            return dp.ExecuteNonQuery(strQuery);

        }

        public bool UpdateTonKho(TonKhoDTO dtoTonKho)
        {
            string strQuery = "Update TONKHO Set ";
            strQuery += "NGAYTHANG = N'" + dtoTonKho.NgayThang + "',";
            strQuery += "MAMATHANG = N'" + dtoTonKho.MaMatHang + "',";
            strQuery += "SOLUONGDAU = " + dtoTonKho.SoLuongDau;
            strQuery += "SOLUONGNHAP = " + dtoTonKho.SoLuongNhap;
            strQuery += "SOLUONGXUAT = " + dtoTonKho.SoLuongXuat;
            strQuery += "SOLUONGTON = " + dtoTonKho.SoLuongTon ;
            strQuery += "Where MATONKHO = N'" + dtoTonKho.MaTonKho + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
