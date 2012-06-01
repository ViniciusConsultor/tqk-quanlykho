using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dalTaiKhoan = new TaiKhoanDAL();
        public string InsertTaiKhoan(TaiKhoanDTO dtoTaiKhoan)
        {
            string strError = "";
            if (dtoTaiKhoan.SoTaiKhoan.Trim().Equals("") == true)
            {
                strError += " Số tài khoản không được rỗng.";
            }
            if (dtoTaiKhoan.NganHang.Trim().Equals("") == true)
            {
                strError += " Tên ngân hàng không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalTaiKhoan.InsertTaiKhoan(dtoTaiKhoan);
                return "ok";
            }
            else
            {
                return strError;
            }
        }
        public string UpdateTaiKhoan(TaiKhoanDTO dtoTaiKhoan)
        {
            string strError = "";
            if (dtoTaiKhoan.SoTaiKhoan.Trim().Equals("") == true)
            {
                strError += " Số tài khoản không được rỗng.";
            }
            if (dtoTaiKhoan.NganHang.Trim().Equals("") == true)
            {
                strError += " Tên ngân hàng không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalTaiKhoan.UpdateTaiKhoan(dtoTaiKhoan);
                return "ok";
            }
            else
            {
                return strError;
            }
        }
    }
}
