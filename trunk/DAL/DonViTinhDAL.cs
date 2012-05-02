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
            string strQuery = "Select * From DONVITINH ";
            return dp.ExecuteQuery(strQuery);
        }

        public bool InsertDonViTinh(DonViTinhDTO dtoDonViTinh)
        {
            string strQuery = "Insert Into DONVITINH values(";
            strQuery += "N'" + dtoDonViTinh.MaDVT + "',";
            strQuery += "N'" + dtoDonViTinh.DonViTinh + "')";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateDonViTinh(DonViTinhDTO dtoDonViTinh)
        {
            string strQuery = "Update DONVITINH Set ";
            strQuery += "DONVITINH = N'" + dtoDonViTinh.DonViTinh + "' ";
            strQuery += "Where MADONVITINH = N'" + dtoDonViTinh.MaDVT + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
