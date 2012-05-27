using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class DonViTinhBLL
    {
        DonViTinhDAL dalDonViTinh = new DonViTinhDAL();
        public DataTable GetDonViTinh()
        {
            return dalDonViTinh.GetDonViTinh();
        }
        public string InsertDonViTinh(DonViTinhDTO dtoDonViTinh)
        {
            string strError = "";
            if (dtoDonViTinh.DonViTinh.Trim().Equals("") == true)
            {
                strError = "Tên đơn vị tính không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalDonViTinh.InsertDonViTinh(dtoDonViTinh);
                return "ok";
            }
            else
            {
                return strError;
            }
        }
        public string UpdateDonViTinh(DonViTinhDTO dtoDonViTinh)
        {
            string strError = "";
            if (dtoDonViTinh.DonViTinh.Trim().Equals("") == true)
            {
                strError = "Tên đơn vị tính không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalDonViTinh.UpdateDonViTinh(dtoDonViTinh);
                return "ok";
            }
            else
            {
                return strError;
            }
        }
        public bool DelDonViTinh(string strMaDVT)
        {
            return dalDonViTinh.DelDonViTinh(strMaDVT);
        }
    }
    
}