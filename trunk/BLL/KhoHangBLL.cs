using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class KhoHangBLL
    {
        KhoHangDAL dalKhoHang = new KhoHangDAL();

        public DataTable GetAllKhoHang()
        {
            return dalKhoHang.GetAllKhoHang();
        }

        public string InsertKhoHang(KhoHangDTO dtoKhoHang)
        {
            string strError = "";
            if (dtoKhoHang.TenKho.Trim().Equals("") == true)
            { 
                strError += " Tên kho không được rỗng.";
            }
            if (dtoKhoHang.DiaChi.Trim().Equals("") == true)
            {
                strError += "Địa chỉ không được rỗng.";
            }
            if(dtoKhoHang.DTDD.Trim().Equals("") == true)
            {
                strError += "Điện thoại không được rỗng.";
            }
            if (dtoKhoHang.SDTB.Trim().Equals("") == true)
            {
                strError += "Điện thoại bàn không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalKhoHang.InsertKhoHang(dtoKhoHang);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public string UpdateKhoHang(KhoHangDTO dtoKhoHang)
        {

            string strError = "";
            if (dtoKhoHang.TenKho.Trim().Equals("") == true)
            {
                strError += " Tên kho không được rỗng.";
            }
            if (dtoKhoHang.DiaChi.Trim().Equals("") == true)
            {
                strError += "Địa chỉ không được rỗng.";
            }
            if (dtoKhoHang.DTDD.Trim().Equals("") == true)
            {
                strError += "Điện thoại không được rỗng.";
            }
            if (dtoKhoHang.SDTB.Trim().Equals("") == true)
            {
                strError += "Điện thoại bàn không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalKhoHang.UpdateKhoHang(dtoKhoHang);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public bool DelKhoHang(string strMaKho)
        {
            return dalKhoHang.DelKhoHang(strMaKho);
        }
    }
}
