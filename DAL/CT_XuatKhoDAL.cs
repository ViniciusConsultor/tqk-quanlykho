using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class CT_XuatKhoDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertCT_XuatKho(CT_XuatKhoDTO dtoCT_XuatKho)
        {
            string strQuery = "Insert Into CT_XUATKHO Values(";
            strQuery += "N'" + dtoCT_XuatKho.MaCTXuatKho + "',";
            strQuery += "N'" + dtoCT_XuatKho.MaXuatKho + "',";
            strQuery += "N'" + dtoCT_XuatKho.MaMatHang + "',";
            strQuery += dtoCT_XuatKho.SoLuongXuat + ",";
            strQuery += dtoCT_XuatKho.GiaTien + ",";
            strQuery += dtoCT_XuatKho.ThanhTien + "," + dtoCT_XuatKho.TinhTrang + ")";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateCT_XuatKho(CT_XuatKhoDTO dtoCT_XuatKho)
        {
            string strQuery = "Update CT_XUATKHO Set ";
            strQuery += "MAMATHANG = N'" + dtoCT_XuatKho.MaMatHang + "',";
            strQuery += "SOLUONGXUAT = " + dtoCT_XuatKho.SoLuongXuat + ",";
            strQuery += "GIATIEN = " + dtoCT_XuatKho.GiaTien + ",";
            strQuery += "THANHTIEN = " + dtoCT_XuatKho.ThanhTien ;
            strQuery += "Where MAHOADONXUAT = N'" + dtoCT_XuatKho.MaHoaDonXuat + "'";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool DelCT_XuatKho(string strMaHoaDonXuat)
        {
            string strQuery = "Update CT_XUATKHO Set TINHTRANG = False Where MAHOADONXUAT = N'" + strMaHoaDonXuat + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
