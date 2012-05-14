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
            string strQuery = "Select * From KHACHHANG Where TINHTRANG = 1";
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
            strQuery += "N'" + dtoKhachHang.Email + "',";
            strQuery += "N'" + dtoKhachHang.GhiChu + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateKH(KhachHangDTO dtoKhachHang)
        {
            string strQuery = "Update KHACHHANG Set ";
            strQuery += "TENKHACHHANG = N'" + dtoKhachHang.TenKH + "',";
            strQuery += "SOTAIKHOAN = N'" + dtoKhachHang.SoTaiKhoan + "',";
            strQuery += "NGANHANG = N'" + dtoKhachHang.NganHang + "',";
            strQuery += "MASOTHUE = N'" + dtoKhachHang.MaSoThue + "',";
            strQuery += "DIACHI = N'" + dtoKhachHang.DiaChi + "',";
            strQuery += "DIENTHOAI = N'" + dtoKhachHang.SDT + "',";
            strQuery += "EMAIL = N'" + dtoKhachHang.Email + "',";
            strQuery += "GHICHU = N'" + dtoKhachHang.GhiChu + "' ";
            strQuery += "Where MAKHACHHANG = N'" + dtoKhachHang.MaKH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelKhachHang(string strMaKH)
        {
            string strQuery = "Update KHACHHANG Set TINHTRANG = 0 Where MAKHACHHANG = N'" + strMaKH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        //public void UpdateKhachHang()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
