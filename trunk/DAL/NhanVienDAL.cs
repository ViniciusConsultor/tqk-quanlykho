﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetNhanVien()
        {
            string strQuery = "Select * From NHANVIEN nv, BOPHAN bp Where nv.TINHTRANG = 1 and nv.MABOPHAN = bp.MABOPHAN ";
            return dp.ExecuteQuery(strQuery);
        }

        public bool InsertNhanVien(NhanVienDTO dtoNhanVien)
        {
            string strQuery = "Insert Into NHANVIEN Values(";
            strQuery += "N'" + dtoNhanVien.MaNV + "',";
            strQuery += "N'" + dtoNhanVien.MaBP + "',";
            strQuery += "N'" + dtoNhanVien.TenNV + "',";
            strQuery += "N'" + dtoNhanVien.MatKhau + "',";
            strQuery += "N'" + dtoNhanVien.ChucVu + "',";
            strQuery += "N'" + dtoNhanVien.DiaChi + "',";
            strQuery += "N'" + dtoNhanVien.NgaySinh + "',";
            strQuery += "N'" + dtoNhanVien.CMND + "',";
            strQuery += "N'" + dtoNhanVien.SoDT + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
                 
        }

        public bool UpdateNhanVien(NhanVienDTO dtoNhanVien)
        {
            string strQuery = "Update NHANVIEN Set ";
            strQuery += "MABOPHAN = N'" + dtoNhanVien.MaBP + "',";
            strQuery += "TENNHANVIEN = N'" + dtoNhanVien.TenNV + "',";
            strQuery += "CHUCVU = N'" + dtoNhanVien.ChucVu + "',";
            strQuery += "DIACHI = N'" + dtoNhanVien.DiaChi + "',";
            strQuery += "NGAYSINH = N'" + dtoNhanVien.NgaySinh + "',";
            strQuery += "CMND = N'" + dtoNhanVien.CMND + "',";
            strQuery += "SODIENTHOAI = N'" + dtoNhanVien.SoDT + "' ";
            strQuery += "Where MANHANVIEN = N'" + dtoNhanVien.MaNV + "'";
            return dp.ExecuteNonQuery(strQuery);

        }

        public bool DelNhanVien(string strMaNV)
        {
            string strQuery = "Update NHANVIEN Set TINHTRANG = 0 where MANHANVIEN = N'" + strMaNV + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public DataTable GetNhanVienByID(string strMaNhanVien, string strMatKhau)
        {
            string strQuery = "Select * From NHANVIEN Where TINHTRANG = 1 and MANHANVIEN = N'" + strMaNhanVien + "'";
            strQuery += " and MATKHAU = N'" + strMatKhau + "'";
            return dp.ExecuteQuery(strQuery);
        }

        public bool UpdateMatKhau(string strMaNhanVien, string strMatKhauMoi)
        {
            string strQuery = "Update NHANVIEN Set MATKHAU = N'" + strMatKhauMoi + "'";
            strQuery += " Where MANHANVIEN = N'" + strMaNhanVien + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

    }
}
