using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;

namespace DAL
{
    public class LanhDaoDAL
    {
        DataProvider dp = new DataProvider();
        public LanhDaoDTO GetAll()
        {
            LanhDaoDTO dtoLanhDao = new LanhDaoDTO();
            string strQuery = "Select * From LANHDAO";
            DataTable dtLanhDao = dp.ExecuteQuery(strQuery);
            if (dtLanhDao.Rows.Count > 0)
            {
                dtoLanhDao.GiamDoc = dtLanhDao.Rows[0]["GIAMDOC"].ToString();
                dtoLanhDao.KeToanTruong = dtLanhDao.Rows[0]["KETOANTRUONG"].ToString();
                dtoLanhDao.ThuKho = dtLanhDao.Rows[0]["THUKHO"].ToString();
                dtoLanhDao.ThuQuy = dtLanhDao.Rows[0]["THUQUY"].ToString();
            }
            return dtoLanhDao;
        }

        public bool CapNhatLanhDao(LanhDaoDTO dtoLanhDao)
        {
            string strQuery = "Update LANHDAO Set ";
            strQuery += "GIAMDOC = N'" + dtoLanhDao.GiamDoc + "' ";
            strQuery += "KETOANTRUONG = N'" + dtoLanhDao.KeToanTruong + "' ";
            strQuery += "THUKHO = N'" + dtoLanhDao.ThuKho + "' ";
            strQuery += "THUQUY = N'" + dtoLanhDao.ThuQuy + "' ";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
