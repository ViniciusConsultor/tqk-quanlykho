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

        public MatHangDTO GetMatHangByID(string strMaMatHang)
        {
            return dalMatHang.GetMatHangByID(strMaMatHang);
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

        public bool UpdateTonDauKy(string strMaMatHang, int intSoLuong)
        {
            return dalMatHang.UpdateTonDauKy(strMaMatHang, intSoLuong);
        }

        public bool UpdateTonNhap(string strMaMatHang, int intSoLuong)
        {
            return dalMatHang.UpdateTonNhap(strMaMatHang, intSoLuong);
        }

        public bool UpdateTonXuat(string strMaMatHang, int intSoLuong)
        {
            return dalMatHang.UpdateTonXuat(strMaMatHang, intSoLuong);
        }

        public bool UpdateHangTon(string strMaMatHang, int intSoLuongTon, int intTonDau)
        {
            return dalMatHang.UpdateHangTon(strMaMatHang, intSoLuongTon, intTonDau);
        }
    }
}
