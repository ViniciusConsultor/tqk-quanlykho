using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAL
{
    public class LoginDAL
    {
        public string Login(string strMaNhanVien, string strPassword)
        {
            DataProvider dp = new DataProvider();
            string strQuery = "Select * From NHANVIEN Where TINHTRANG = 1 and MANHANVIEN = N'" + strMaNhanVien + "'";
            strQuery += " and MATKHAU = N'" + strPassword + "'";
            DataTable dt = dp.ExecuteQuery(strQuery);
            string strTenNhanVien = "";

            if (dt.Rows.Count == 0)
            {
                return "404";
            }
            else
            {
                strTenNhanVien = dt.Rows[0]["TENNHANVIEN"].ToString();
            }
            return strTenNhanVien;
        }
    }
}
