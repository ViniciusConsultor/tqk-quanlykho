using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class TT_CongTyDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertTT_CongTy(TT_CongTyDTO dtoTT_CT)
        {
            string strQuery = "Insert Into TT_CONGTY Values(";
            strQuery += "N'" + dtoTT_CT.MaCT + "',";
            strQuery += "N'" + dtoTT_CT.TenCT + "',";
            strQuery += "N'" + dtoTT_CT.DiaChi + "',";
            strQuery += "N'" + dtoTT_CT.SoDT + "',";
            strQuery += "N'" + dtoTT_CT.Mobile + "',";
            strQuery += "N'" + dtoTT_CT.Email + "',";
            strQuery += "N'" + dtoTT_CT.Fax + "',";
            strQuery += "N'" + dtoTT_CT.LoGo + "',";
            strQuery += "N'" + dtoTT_CT.MaThue + "',";
            strQuery += "N'" + dtoTT_CT.WebSite + "',";
            strQuery += "N'" + dtoTT_CT.SoTaiKhoan + "',";
            strQuery += "N'" + dtoTT_CT.NganHang + "')";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateTT_CongTy(TT_CongTyDTO dtoTT_CT)
        {
            string strQuery = "Update TT_CONGTY Set ";
            strQuery += "TENCT = N'" + dtoTT_CT.TenCT + "',";
            strQuery += "DIACHI = N'" + dtoTT_CT.DiaChi + "',";
            strQuery += "SDT = N'" + dtoTT_CT.SoDT + "',";
            strQuery += "MOBILE = N'" + dtoTT_CT.Mobile + "',";
            strQuery += "EMAIL = N'" + dtoTT_CT.Email + "',";
            strQuery += "FAX = N'" + dtoTT_CT.Fax + "',";
            strQuery += "LOGO = N'" + dtoTT_CT.LoGo + "',";
            strQuery += "MASOTHUE = N'" + dtoTT_CT.MaThue + "',";
            strQuery += "WEBSITE = N'" + dtoTT_CT.WebSite + "' ";
            strQuery += "SOTAIKHOAN = N'" + dtoTT_CT.SoTaiKhoan + "',";
            strQuery += "NGANHANG = N'" + dtoTT_CT.NganHang + "',";
            strQuery += "Where MACT = N'" + dtoTT_CT.MaCT + "'";
            return dp.ExecuteNonQuery(strQuery);

        }
    }
}
