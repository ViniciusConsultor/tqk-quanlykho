using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class TienMatDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertTienMat(TienMatDTO dtoTienMat)
        {
            string strQuery = "Insert Into TIENMAT Values(";
            strQuery += "N'" + dtoTienMat.MaTienMat + "',";
            strQuery += dtoTienMat.SoTien ;
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateTienMat(TienMatDTO dtoTienMat)
        {
            string strQuery = "Update TIENMAT Set ";
            strQuery += "SOTIEN = " + dtoTienMat.SoTien;
            strQuery += "Where MATIENMAT = N'" + dtoTienMat.MaTienMat + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
