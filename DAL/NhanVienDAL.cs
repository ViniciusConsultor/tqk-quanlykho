using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertNhanVien(NhanVienDTO dtoNhanVien)
        {
            string strQuery = "Insert Into NHANVIEN Values(";
            strQuery += "N" + dtoNhanVien.MaNV + "',";
            strQuery += "N" + dtoNhanVien.MaBP + "',";
            strQuery += "N" + dtoNhanVien.UserName + "',";
            strQuery += "N" + dtoNhanVien.PassWord + "',";
            strQuery += "N" + dtoNhanVien.ChucVu + "',";
            strQuery += "N" + dtoNhanVien.TenNV + "',";
            strQuery += "N" + dtoNhanVien.DiaChi + "',";
            strQuery += "N" + dtoNhanVien.NgaySinh + "',";
            strQuery += "N" + dtoNhanVien.CMND + "',";
            strQuery += "N" + dtoNhanVien.SoDT + "',True)";
            return dp.ExecuteNonQuery(strQuery);
                 
        }

        public bool UpdateNhanVien(NhanVienDTO dtoNhanVien)
        {
            string strQuery = "Update NHANVIEN Set ";
            strQuery += "MABP = N'" + dtoNhanVien.MaBP + "',";
            strQuery += "USERNAME = N'" + dtoNhanVien.UserName + "',";
            strQuery += "PASSWORD = N'" + dtoNhanVien.PassWord + "',";
            strQuery += "CHUCVU = N'" + dtoNhanVien.ChucVu + "',";
            strQuery += "TENNV = N'" + dtoNhanVien.TenNV + "',";
            strQuery += "DIACHI = N'" + dtoNhanVien.DiaChi + "',";
            strQuery += "NGAYSINH = N'" + dtoNhanVien.NgaySinh + "',";
            strQuery += "SCMND = N'" + dtoNhanVien.CMND + "',";
            strQuery += "SDT = N'" + dtoNhanVien.SoDT + "', ";
            strQuery += "Where MANV = N'" + dtoNhanVien.MaNV + "'";
            return dp.ExecuteNonQuery(strQuery);

        }

        public bool DelNhanVien(string strMaNV)
        {
            string strQuery = "Update NHANVIEN Set TINHTRANG = False where MANV = N'" + strMaNV + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

    }
}
