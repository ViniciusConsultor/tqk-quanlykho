using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class BoPhanBLL
    {
        BoPhanDAL dalBoPhan = new BoPhanDAL();
        public DataTable GetBoPhan()
        {
            return dalBoPhan.GetBoPhan();
        }

        public string  InsertBoPhan(BoPhanDTO dtoBoPhan)
        {
            string strError = "";
            if (dtoBoPhan.TenBoPhan.Trim().Equals("") == true)
            {
                strError = "Tên bộ phận không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalBoPhan.InsertBoPhan(dtoBoPhan);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public string  UpdateBoPhan(BoPhanDTO dtoBoPhan)
        {
            string strError = "";
            if (dtoBoPhan.TenBoPhan.Trim().Equals("") == true)
            {
                strError = "Tên bộ phận không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalBoPhan.UpdateBoPhan(dtoBoPhan);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public bool DelBoPhan(string strMaBP)
        {
            return dalBoPhan.DelBoPhan(strMaBP);
        }
    }
}
