using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class TienMatBLL
    {
        TienMatDAL dalTienMat = new TienMatDAL();

        public TienMatDTO GetTienMat()
        {
            return dalTienMat.GetTienMat();
        }
        public bool UpdateTienMat(TienMatDTO dtoTienMat)
        {
            return dalTienMat.UpdateTienMat(dtoTienMat);
        }
    }
}
