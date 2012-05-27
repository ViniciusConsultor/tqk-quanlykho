using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public  class MatHangBLL
    {
        MatHangDAL dalMatHang = new MatHangDAL();
        public DataTable GetAllMatHang()
        {
            return dalMatHang.GetAllMatHang();
        }
        public string InsertMatHang(MatHangDTO dtoMatHang)
        {
            string strError = "";
            if (dtoMatHang.TenMH.Trim().Equals("") == true)
            {
                strError = "Tên mặt hàng không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalMatHang.InsertMatHang(dtoMatHang);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public string  UpdateMatHang(MatHangDTO dtoMatHang)
        {
            string strError = "";
            if (dtoMatHang.TenMH.Trim().Equals("") == true)
            {
                strError = "Tên mặt hàng không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalMatHang.UpdateMatHang(dtoMatHang);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public bool DelMatHang(string strMaMH)

        {
            return dalMatHang.DelMatHang(strMaMH);
        }
    }
}
