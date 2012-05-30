using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
    public class NhapKhoBLL
    {

        NhapKhoDAL dalNhapKho = new NhapKhoDAL();

        public string InsertNhapKho(NhapKhoDTO dtoNhapKho)
        {
            string strError = "";
            if (dtoNhapKho.SoHoaDon == "")
            {
                strError += "Số hóa đơn không được để trống";
            }
            if (strError == "")
            {
                if (dalNhapKho.InsertNhapKho(dtoNhapKho) == true)
                    return "ok";
            }
            return strError;
        }

        public bool UpdateNhapKho(NhapKhoDTO dtoNhapKho)
        {
            return dalNhapKho.UpdateNhapKho(dtoNhapKho);
        }

    }
}
