using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class DonViTinhDAL
    {
        DataProvider dp = new DataProvider();
        public DataTable GetDonViTinh()
        {
            string strQuery = "Select * From DONVITINH Where TINHTRANG = 1";
            return dp.ExecuteQuery(strQuery);
        }

        public bool InsertDonViTinh(DonViTinhDTO dtoDonViTinh)
        {
            string strQuery = "Insert Into DONVITINH values(";
            strQuery += "N'" + dtoDonViTinh.MaDVT + "',";
            strQuery += "N'" + dtoDonViTinh.DonViTinh + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateDonViTinh(DonViTinhDTO dtoDonViTinh)
        {
            string strQuery = "Update DONVITINH Set ";
            strQuery += "DONVITINH = N'" + dtoDonViTinh.DonViTinh + "' ";
            strQuery += "Where MADONVITINH = N'" + dtoDonViTinh.MaDVT + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelDonViTinh(string strMaDVt)
        {
            string strQuery = "Update DONVITINH Set TINHTRANG = 0 Where MADONVITINH = N'" + strMaDVt + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
