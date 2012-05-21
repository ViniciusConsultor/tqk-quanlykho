using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class KhoHangDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAllKhoHang()
        {
            string strQuery = "Select * From KHO Where TINHTRANG = 1";
            return dp.ExecuteQuery(strQuery);

        }

        public bool InsertKhoHang(KhoHangDTO dtoKhoHang)
        {
            string strQuery = "Insert Into KHO Values(";
            strQuery += "N'" + dtoKhoHang.MaKho + "',";
            strQuery += "N'" + dtoKhoHang.TenKho + "',";
            strQuery += "N'" + dtoKhoHang.DiaChi + "',";
            strQuery += "N'" + dtoKhoHang.SDTB + "',";
            strQuery += "N'" + dtoKhoHang.DTDD + "',";
            strQuery += "N'" + dtoKhoHang.NguoiLH + "',";
            strQuery += "N'" + dtoKhoHang.Fax + "',";
            strQuery += "N'" + dtoKhoHang.GhiChu + "',True)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateKhoHang(KhoHangDTO dtoKhoHang)
        {
            string strQuery = "Update KHO Set ";
            strQuery += "TENKHO = N'" + dtoKhoHang.TenKho + "',";
            strQuery += "DIACHI = N'" + dtoKhoHang.DiaChi + "',";
            strQuery += "DIENTHOAIBAN = N'" + dtoKhoHang.SDTB + "',";
            strQuery += "DIDONG = N'" + dtoKhoHang.DTDD + "',";
            strQuery += "NGUOILIENHE = N'" + dtoKhoHang.NguoiLH + "',";
            strQuery += "FAX = N'" + dtoKhoHang.Fax + "',";
            strQuery += "GHICHU = N'" + dtoKhoHang.GhiChu + "' ";
            strQuery += "Where MAKHO = N'" + dtoKhoHang.MaKho + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelKhoHang(string strMaKho)
        {
            string strQuery = "Update KHO Set TINHTRANG = False Where MAKHO = N'" + strMaKho + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
