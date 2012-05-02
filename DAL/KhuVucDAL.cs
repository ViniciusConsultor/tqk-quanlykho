using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class KhuVucDAL
    {
        DataProvider dp = new DataProvider();
        public bool InsertKhuVuc(KhuVucDTO dtoKhuVuc)
        {
            string strQuery = "Insert Into KHUVUC Values(";
            strQuery += "N'" + dtoKhuVuc.MaKV + "',";
            strQuery += "N'" + dtoKhuVuc.TenKV + "',";
            strQuery += "N'" + dtoKhuVuc.GhiChu + "',True)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateKhuVuc(KhuVucDTO dtoKhuVuc)
        {
            string strQuery = "Update KHUVUC Set ";
            strQuery += "TENKV = N'" + dtoKhuVuc.TenKV + "',";
            strQuery += "GHICHU = N'" + dtoKhuVuc.GhiChu + "' ";
            strQuery += "Where MAKV = N'" + dtoKhuVuc.MaKV + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelKhuVuc(string strMaKV)
        {
            string strQuery = "Update KHUVUC Set TINHTRANG = False Where MAKV = N'" + strMaKV + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
