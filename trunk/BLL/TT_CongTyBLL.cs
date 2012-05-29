using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
namespace BLL
{
    public class TT_CongTyBLL
    {
        TT_CongTyDAL dalTT_CT = new TT_CongTyDAL();
        
         public string UpdateTT_CongTy(TT_CongTyDTO dtoTT_CT)
        {
            string strError = "";
            if (dtoTT_CT.TenCT.Trim().Equals("") == true)
            {
                strError += " Tên công ty không được rỗng.";
            }
            if (dtoTT_CT.MaThue.Trim().Equals("") == true)
            {
                strError += " Mã số thuế không được rỗng.";
            }
            if (dtoTT_CT.SoTaiKhoan.Trim().Equals("") == true)
            {
                strError += " Số tài khoản không được rỗng.";
            }
            if (dtoTT_CT.NganHang.Trim().Equals("") == true)
            {
                strError += " Tên ngân hàng không được rỗng.";
            }
            if (dtoTT_CT.DiaChi.Trim().Equals("") == true)
            {
                strError += " Địa chỉ không được rỗng.";
            }
            if (dtoTT_CT.SoDT.Trim().Equals("") == true)
            {
                strError += "Số điện thoại không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalTT_CT.UpdateTT_CongTy(dtoTT_CT);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

    }
}
