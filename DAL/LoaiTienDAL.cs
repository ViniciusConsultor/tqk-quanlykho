using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class LoaiTienDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertLoaiTien(LoaiTienDTO dtoLoaiTien)
        {
            string strQuery = "Insert Into LOAITIEN Values(";
            strQuery += "N'" + dtoLoaiTien.MaLoaiTien + "',";
            strQuery += "N'" + dtoLoaiTien.TenLoaiTien + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
        public bool UpdateLoaiTien(LoaiTienDTO dtoLoaiTien)
        {
            string strQuery = "Update LOAITIEN Set ";
            strQuery += "TENLOAITIEN = N'" + dtoLoaiTien.TenLoaiTien + "' ";
            strQuery += "Where MALOAITIEN = N'" + dtoLoaiTien.MaLoaiTien + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

    }
}
