using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    public class CT_NhapKhoBLL
    {
        CT_NhapKhoDAL dalCTNhapKho = new CT_NhapKhoDAL();

        public bool InsertCT_NhapKho(CT_NhapKhoDTO dtoCT_NhapKho)
        {
            return dalCTNhapKho.InsertCT_NhapKho(dtoCT_NhapKho);
        }

        public bool UpdateCT_NhapKho(CT_NhapKhoDTO dtoCT_NhapKho)
        {
            return dalCTNhapKho.UpdateCT_NhapKho(dtoCT_NhapKho);
        }

        public bool DelCT_NhapKho(string strMaNhapKho)
        {
            return dalCTNhapKho.DelCT_NhapKho(strMaNhapKho);
        }
    }
}
