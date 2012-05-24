using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL dalNhanVien = new NhanVienDAL();

        public DataTable GetNhanVien()
        {
            return dalNhanVien.GetNhanVien();
        }

        public string InsertNhanVien(NhanVienDTO dtoNhanVien)
        { 
            string strError = "";
            if(dtoNhanVien.TenNV.Trim().Equals("") == true)
            {
                strError += " Tên nhân viên không được rỗng.";
            }
            if (dtoNhanVien.NgaySinh.Trim().Equals("") == true)
            {
                strError += " Ngày sinh không được rỗng.";
            }
            if (dtoNhanVien.CMND.Trim().Equals("") == true)
            {
                strError += " CMND không được rỗng.";
            }
            if (dtoNhanVien.DiaChi.Trim().Equals("") == true)
            {
                strError += " Địa chỉ không được rỗng.";
            }
            if (dtoNhanVien.SoDT.Trim().Equals("") == true)
            {
                strError += " Số điện thoại không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalNhanVien.InsertNhanVien(dtoNhanVien);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public string UpdateNhanVien(NhanVienDTO dtoNhanVien)
        {
            string strError = "";
            if (dtoNhanVien.TenNV.Trim().Equals(' ') == true)
            {
                strError += "Tên nhân viên không được rỗng.";
            }
            return strError;
        }

        public bool DelNhanVien(string strMaNV)
        {
            return dalNhanVien.DelNhanVien(strMaNV);
        }
    }
}
