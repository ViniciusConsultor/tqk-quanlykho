using System;
using System.Collections.Generic;
using System.Text;
using DAL;
namespace BLL
{
    public class LoginBLL
    {
        public string Login(string strMaNhanVien, string strPassword)
        {
            LoginDAL dalLogin = new LoginDAL();
            return dalLogin.Login(strMaNhanVien, strPassword);
        }
    }

}
