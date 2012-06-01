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
    }
}
