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
            strQuery += "WEBSITE = N'" + dtoTT_CT.WebSite + "',";
            strQuery += "SOTAIKHOAN = N'" + dtoTT_CT.SoTaiKhoan + "',";
            strQuery += "NGANHANG = N'" + dtoTT_CT.NganHang + "' ";
            strQuery += "Where MACT = MACT ";
            return dp.ExecuteNonQuery(strQuery);

        }

        public TT_CongTyDTO GetThongTinDoanhNghiep()
        {
            TT_CongTyDTO dtoCongTy = new TT_CongTyDTO();
            string strSQL = "Select * From TT_CONGTY";
            DataTable dtCongTy = dp.ExecuteQuery(strSQL);
            if (dtCongTy.Rows.Count > 0)
            { 
                dtoCongTy.DiaChi = dtCongTy.Rows[0]["DIACHI"].ToString();
                dtoCongTy.TenCT = dtCongTy.Rows[0]["TENCT"].ToString();
                dtoCongTy.SoTaiKhoan = dtCongTy.Rows[0]["SOTAIKHOAN"].ToString();
                dtoCongTy.NganHang = dtCongTy.Rows[0]["NGANHANG"].ToString();
                dtoCongTy.MaThue = dtCongTy.Rows[0]["MASOTHUE"].ToString();
                dtoCongTy.SoDT = dtCongTy.Rows[0]["SDT"].ToString();
                dtoCongTy.Mobile = dtCongTy.Rows[0]["MOBILE"].ToString();
                dtoCongTy.Email = dtCongTy.Rows[0]["EMAIL"].ToString();
                dtoCongTy.Fax = dtCongTy.Rows[0]["FAX"].ToString();
                dtoCongTy.WebSite = dtCongTy.Rows[0]["WEBSITE"].ToString();
                dtoCongTy.LoGo = dtCongTy.Rows[0]["LOGO"].ToString();
            }
            return dtoCongTy;
        }
    }
}
