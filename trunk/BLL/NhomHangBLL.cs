using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class NhomHangBLL
    {
        NhomHangDAL dalNhomHang = new NhomHangDAL();
        public DataTable GetNhomHang()
        {
            return dalNhomHang.GetNhomHang();
        }
        public string InsertNhomHang(NhomHangDTO dtoNhomHang)
        {
            string strError = "";
            if (dtoNhomHang.TenNhomHang.Trim().Equals("") == true)
            {
                strError = "Tên nhóm hàng không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalNhomHang.InsertNhomHang(dtoNhomHang);
                return "ok";
            }
            else
            {
                return strError;
            }
        }
        public string UpdateNhomHang(NhomHangDTO dtoNhomHang)
        {
            string strError = "";
            if (dtoNhomHang.TenNhomHang.Trim().Equals("") == true)
            {
                strError = "Tên nhóm hàng không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalNhomHang.UpdateNhomHang(dtoNhomHang);
                return "ok";
            }
            else
            {
                return strError;
            }
            
        }
        public bool DelNhomHang(string strMaNhom)
        {
            return dalNhomHang.DelNhomHang(strMaNhom);
        }

    }
}
