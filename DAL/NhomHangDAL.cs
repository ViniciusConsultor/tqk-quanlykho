using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class NhomHangDAL
    {
        DataProvider dp = new DataProvider();
        public DataTable GetNhomHang()
        {
            string strQuery = "Select * From NHOMHANG ";
            return dp.ExecuteQuery(strQuery);
        }
        public bool InsertNhomHang(NhomHangDTO dtoNhomHang)
        {
            string strQuery = "Insert Into NHOMHANG Values(";
            strQuery += "N'" + dtoNhomHang.MaNH + "',";
            strQuery += "N'" + dtoNhomHang.TenNhomHang + "',";
            strQuery += "N'" + dtoNhomHang.GhiChu + "')";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateNhomHang(NhomHangDTO dtoNhomHang)
        {
            string strQuery = "Update NHOMHANG Set ";
            strQuery += "TENNHOMHANG = N'" + dtoNhomHang.TenNhomHang + "',";
            strQuery += "GHICHU = N'" + dtoNhomHang.GhiChu + "' ";
            strQuery += "Where MANHOMHANG = N'" + dtoNhomHang.MaNH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
