using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class BoPhanDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetBoPhan()
        {
            string strQuery = "Select * From BOPHAN Where TINHTRANG = 1";
            return dp.ExecuteQuery(strQuery);
        }

        public bool InsertBoPhan(BoPhanDTO dtoBoPhan)
        {
            string strQuery = "Insert Into BOPHAN Values(";
            strQuery += "N'" + dtoBoPhan.MaBP + "',";
            strQuery += "N'" + dtoBoPhan.TenBoPhan + "',";
            strQuery += "N'" + dtoBoPhan.TinhTrang + "',True)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateBoPhan(BoPhanDTO dtoBoPhan)
        {
            string strQuery = "Update BOPHAN Set ";
            strQuery += "TENBOPHAN = N'" + dtoBoPhan.TenBoPhan + "' ";
            strQuery += "Where MABOPHAN = N'" + dtoBoPhan.MaBP + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelBoPhan(string strMaBP)
        {
            string strQuery = "Update BOPHAN Set TINHTRANG = False Where MABOPHAN = N'" + strMaBP + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
