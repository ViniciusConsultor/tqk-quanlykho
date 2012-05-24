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

        public bool InsertBoPhan(BoPhanDTO dtoBoPhan)
        {
            return dalBoPhan.InsertBoPhan(dtoBoPhan);
        }

        public bool UpdateBoPhan(BoPhanDTO dtoBoPhan)
        {
            return dalBoPhan.UpdateBoPhan(dtoBoPhan);
        }

        public bool DelBoPhan(string strMaBP)
        {
            return dalBoPhan.DelBoPhan(strMaBP);
        }
    }
}
