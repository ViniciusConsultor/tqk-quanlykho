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

        public TienMatDTO GetTienMat()
        {
            TienMatDTO dtoTienMat = new TienMatDTO();
            string strQuery = "Select * From TIENMAT";
            DataTable dtTienMat = dp.ExecuteQuery(strQuery);
            if (dtTienMat != null)
            {
                dtoTienMat.SoTien = float.Parse(dtTienMat.Rows[0]["SOTIEN"].ToString());
            }
            return dtoTienMat;
        }
        public bool InsertTienMat(TienMatDTO dtoTienMat)
        {
            string strQuery = "Insert Into TIENMAT Values(";
            strQuery += dtoTienMat.SoTien ;
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateTienMat(TienMatDTO dtoTienMat)
        {
            string strQuery = "Update TIENMAT Set ";
            strQuery += "SOTIEN = " + dtoTienMat.SoTien ;
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
