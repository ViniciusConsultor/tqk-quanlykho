using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    public class CT_XuatKhoBLL
    {
        CT_XuatKhoDAL dalCTXuatKho = new CT_XuatKhoDAL();

        public bool InsertCT_XuatKho(CT_XuatKhoDTO dtoCT_XuatKho)
        {
            return dalCTXuatKho.InsertCT_XuatKho(dtoCT_XuatKho);
        }
    }
}
