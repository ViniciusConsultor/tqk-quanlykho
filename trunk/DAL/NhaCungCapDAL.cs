using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class NhaCungCapDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAllNhaCungCap()
        {
            string strQuery = "Select * From NHACUNGCAP Where TINHTRANG = 1";
            return dp.ExecuteQuery(strQuery);
        }

        public bool InsertNhaCungCap(NhaCungCapDTO dtoNhaCungCap)
        {
            string strQuery = "Insert Into NHACUNGCAP Values(";
            strQuery += "N'" + dtoNhaCungCap.MaNCC + "',";
            strQuery += "N'" + dtoNhaCungCap.TenNCC + "',";
            strQuery += "N'" + dtoNhaCungCap.DiaChi + "',";
            strQuery += "N'" + dtoNhaCungCap.MaSoThue + "',";
            strQuery += "N'" + dtoNhaCungCap.SoTaiKhoan + "',";
            strQuery += "N'" + dtoNhaCungCap.NganHang + "',";
            strQuery += "N'" + dtoNhaCungCap.SoDienThoai + "',";
            strQuery += "N'" + dtoNhaCungCap.Email + "',";
            strQuery += "N'" + dtoNhaCungCap.Fax + "',";
            strQuery += "N'" + dtoNhaCungCap.WebSite + "',True)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateNhaCungCap(NhaCungCapDTO dtoNhaCungCap)
        {
            string strQuery = "Update NHACUNGCAP Set ";
            strQuery += "TENNHACUNGCAP = N'" + dtoNhaCungCap.TenNCC + "',";
            strQuery += "DIACHI = N'" + dtoNhaCungCap.DiaChi + "',";
            strQuery += "MASOTHUE = N'" + dtoNhaCungCap.MaSoThue + "',";
            strQuery += "SOTAIKHOAN = N'" + dtoNhaCungCap.SoTaiKhoan + "',";
            strQuery += "NGANHANG = N'" + dtoNhaCungCap.NganHang + "',";
            strQuery += "SODIENTHOAI = N'" + dtoNhaCungCap.SoDienThoai + "',";
            strQuery += "EMAIL = N'" + dtoNhaCungCap.Email + "',";
            strQuery += "FAX = N'" + dtoNhaCungCap.Fax + "',";
            strQuery += "WEBSITE = N'" + dtoNhaCungCap.WebSite + "' ";
            strQuery += "Where MANHACUNGCAP = N'" + dtoNhaCungCap.MaNCC + "'";
            return dp.ExecuteNonQuery(strQuery);
            
        }

        public bool DelNhaCungCap(string strMaNCC)
        {
            string strQuery = "Update NHACUNGCAP Set TINHTRANG = False where MANHACUNGCAP = N'" + strMaNCC + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
