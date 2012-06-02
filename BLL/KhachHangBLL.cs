using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL dalKhachHang = new KhachHangDAL();
        public DataTable GetAllKhachHang()
        {
            return dalKhachHang.GetAllKhachHang();
        }
        public string InsertKhachHang(KhachHangDTO dtoKhachHang)
        {
            string strError = "";
            if (dtoKhachHang.TenKH.Trim().Equals("") == true)
            {
                strError += "Tên khách hàng không được rỗng.";
            }
            if (dtoKhachHang.SoTaiKhoan.Trim().Equals("") == true)
            {
                strError += " Số tài khoản không được rỗng.";
            }
            if (dtoKhachHang.MaSoThue.Trim().Equals("") == true)
            {
                strError += " Mã số thuế không được rỗng.";
            }
            if (dtoKhachHang.NganHang.Trim().Equals("") == true)
            {
                strError += " Tên ngân hàng không được rỗng.";
            }
            if (dtoKhachHang.SDT.Trim().Equals("") == true)
            {
                strError += " Số điện thoại không được rỗng.";
            }

            if (dtoKhachHang.DiaChi.Trim().Equals("") == true)
            {
                strError += " Địa chỉ không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalKhachHang.InsertKhachHang(dtoKhachHang);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public string  UpdateKH(KhachHangDTO dtoKhachHang)
        {
            string strError = "";
            if (dtoKhachHang.TenKH.Trim().Equals("") == true)
            {
                strError += " Tên khách hàng không được rỗng.";
            }
            if (dtoKhachHang.SoTaiKhoan.Trim().Equals("") == true)
            {
                strError += " Số tài khoản không được rỗng.";
            }
            if (dtoKhachHang.MaSoThue.Trim().Equals("") == true)
            {
                strError += " Mã số thuế không được rỗng.";
            }
            if (dtoKhachHang.NganHang.Trim().Equals("") == true)
            {
                strError += " Tên ngân hàng không được rỗng.";
            }
            if (dtoKhachHang.SDT.Trim().Equals("") == true)
            {
                strError += " Số điện thoại không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalKhachHang.UpdateKH(dtoKhachHang);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public bool DelKhachHang(string strMaKH)
        {
            return dalKhachHang.DelKhachHang(strMaKH);
        }

        public KhachHangDTO GetKhachHangByID(string strID)
        {
            return dalKhachHang.GetKhachHangByID(strID);
        }
    }
}
