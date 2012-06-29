using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;

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

        public DataTable TimKiemDuNo(DateTime dtNgayBD, DateTime dtNgayKT, string strNhaCungCap)
        {
            return dalNhapKho.TimKiemDuNo(dtNgayBD, dtNgayKT, strNhaCungCap);
        }

        public DataTable TimKiemTongNhap(DateTime dtNgayBD, DateTime dtNgayKT, string strMaMatHang)
        {
            return dalNhapKho.TimKiemTongNhap(dtNgayBD, dtNgayKT, strMaMatHang);
        }

        public DataTable TimKiemCTDuNo(DateTime dtNgayBD, DateTime dtNgayKT, string strNhaCungCap)
        {
            return dalNhapKho.TimKiemCTDuNo(dtNgayBD, dtNgayKT, strNhaCungCap);
        }
    }
}
