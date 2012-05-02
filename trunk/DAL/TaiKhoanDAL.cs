using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class TaiKhoanDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertTaiKhoan(TaiKhoanDTO dtoTaiKhoan)
        {
            string strQuery = "Insert Into TAIKHOAN Values(";
            strQuery += "N'" + dtoTaiKhoan.MaTaiKhoan + "',";
            strQuery += "N'" + dtoTaiKhoan.SoTaiKhoan + "',";
            strQuery += "N'" + dtoTaiKhoan.NganHang + "',";
            strQuery += dtoTaiKhoan.LuongTien + ",";
            strQuery += "N'" + dtoTaiKhoan.LoaiTien + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateTaiKhoan(TaiKhoanDTO dtoTaiKhoan)
        {
            string strQuery = "Update TAIKHOAN Set ";
            strQuery += "SOTAIKHOAN = N'" + dtoTaiKhoan.SoTaiKhoan + "',";
            strQuery += "NGANHANG = N'" + dtoTaiKhoan.NganHang + "',";
            strQuery += "LUONGTIEN = " + dtoTaiKhoan.LuongTien + ",";
            strQuery += "LOAITIEN = N'" + dtoTaiKhoan.LoaiTien + "' ";
            strQuery += "Where MATAIKHOAN = N'" + dtoTaiKhoan.MaTaiKhoan + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
