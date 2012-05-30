using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class MucThueDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetMucThue()
        {
            string strQuery = " Select * From THUE Where TINHTRANG = 1";
            return dp.ExecuteQuery(strQuery);
        }

        public bool InsertThue(MucThueDTO dtoMucThue)
        {
            string strQuery = "Insert Into THUE Values(";
            strQuery += "N'" + dtoMucThue.MaTH + "',";
            strQuery += dtoMucThue.SoThue + ",";
            strQuery += "N'" + dtoMucThue.GhiChu + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateThue(MucThueDTO dtoMucThue)
        {
            string strQuery = "Update THUE Set ";
            
            strQuery += "SOTHUE = " + dtoMucThue.SoThue + ",";
            strQuery += "GHICHU = N'" + dtoMucThue.GhiChu + "' ";
            strQuery += "Where MATHUE = N'" + dtoMucThue.MaTH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelMucThue(string strMaTH)
        {
            string strQuery = "Update THUE Set TINHTRANG = 0 Where MATHUE = N'" + strMaTH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
