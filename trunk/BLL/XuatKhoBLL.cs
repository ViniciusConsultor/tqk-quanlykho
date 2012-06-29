using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class XuatKhoBLL
    {
        XuatKhoDAL dalXuatKho = new XuatKhoDAL();
        public string InsertXuatKho(XuatKhoDTO dtoXuatKho)
        {
            string strError = "";
            if (dtoXuatKho.SoHoaDon == "")
            {
                strError += "Số hóa đơn không được để trống";
            }
            if (strError == "")
            {
                if (dalXuatKho.InsertXuatKho(dtoXuatKho) == true)
                    return "ok";
            }
            return strError;
        }

        public bool UpdateXuatKho(XuatKhoDTO dtoXuatKho)
        {
            return dalXuatKho.UpdateXuatKho(dtoXuatKho);
        }

        public bool DelXuatKho(string strMaXK)
        {
            return dalXuatKho.DelXuatKho(strMaXK);
        }

        public DataTable TimKiem(DateTime dtNgayBD, DateTime dtNgayKT, string strKhachHang)
        {
            return dalXuatKho.TimKiemCongNo(dtNgayBD, dtNgayKT, strKhachHang);
        }

        public DataTable TimKiemTongXuat(DateTime dtNgayBD, DateTime dtNgayKT, string strMaMatHang)
        {
            return dalXuatKho.TimKiemTongXuat(dtNgayBD, dtNgayKT, strMaMatHang);
        }

        public DataTable TimKiemChiTiet(DateTime dtNgayBD, DateTime dtNgayKT, string strKhachHang)
        {
            return dalXuatKho.TimKiemCTCongNo(dtNgayBD, dtNgayKT, strKhachHang);
        }
    }
}
