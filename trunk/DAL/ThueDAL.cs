using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class ThueDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertThue(ThueDTO dtoThue)
        {
            string strQuery = "Insert Into THUE Values(";
            strQuery += "N'" + dtoThue.MaTH + "',";
            strQuery += dtoThue.SoThue ;
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateThue(ThueDTO dtoThue)
        {
            string strQuery = "Update THUE Set ";
            strQuery += "SOTHUE = " + dtoThue.SoThue ;
            strQuery += "Where MATHUE = N'" + dtoThue.MaTH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
