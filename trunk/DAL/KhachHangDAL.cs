using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class KhachHangDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAllKhachHang()
        {
            string strQuery = "Select * From KHACHHANG";
            return dp.ExecuteQuery(strQuery);
        }

        public bool InsertKhachHang(KhachHangDTO dtoKhachHang)
        {
            string strQuery = "Insert Into KHACHHANG Values(";
            strQuery += "N'" + dtoKhachHang.MaKH + "',";
            strQuery += "N'" + dtoKhachHang.TenKH + "',";
            strQuery += "N'" + dtoKhachHang.SoTaiKhoan + "',";
            strQuery += "N'" + dtoKhachHang.NganHang + "',";
            strQuery += "N'" + dtoKhachHang.MaSoThue + "',";
            strQuery += "N'" + dtoKhachHang.DiaChi + "',";
            strQuery += "N'" + dtoKhachHang.SDT + "',";
            strQuery += "N'" + dtoKhachHang.Fax + "',True)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateKhachHang(KhachHangDTO dtoKhachHang)
        {
            string strQuery = "Update KHACHHANG Set ";
            strQuery += "TENKHACHHANG = N'" + dtoKhachHang.TenKH + "',";
            strQuery += "SOTAIKHOAN = N'" + dtoKhachHang.SoTaiKhoan + "',";
            strQuery += "NGANHANG = N'" + dtoKhachHang.NganHang + "',";
            strQuery += "MASOTHUE = N'" + dtoKhachHang.MaSoThue + "',";
            strQuery += "DIACHI = N'" + dtoKhachHang.DiaChi + "',";
            strQuery += "DIENTHOAI = N'" + dtoKhachHang.SDT + "',";
            strQuery += "FAX = N'" + dtoKhachHang.Fax + "' ";
            strQuery += "Where MAKHACHHANG = N'" + dtoKhachHang.MaKH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelKhachHang(string strMaKH)
        {
            string strQuery = "Update KHACHHANG Set TINHTRANG = False Where MAKHACHHANG = N'" + strMaKH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
