using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class MucThueBLL
    {
        MucThueDAL dalMucThue = new MucThueDAL();

        public DataTable GetMucThue()
        {
            return dalMucThue.GetMucThue();
        }

        public string InsertThue(MucThueDTO dtoMucThue)
        {
            string strError = "";
            if (dtoMucThue.SoThue.Equals("") == true)
            {
                strError = "Mức thuế không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalMucThue.InsertThue(dtoMucThue);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public string UpdateThue(MucThueDTO dtoMucThue)
        {
            string strError = "";
            if (dtoMucThue.SoThue.Equals("") == true)
            {
                strError = "Mức thuế không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalMucThue.UpdateThue(dtoMucThue);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public bool DelMucThue(string strMaTH)
        {
            return dalMucThue.DelMucThue(strMaTH);
        }
    }
}
