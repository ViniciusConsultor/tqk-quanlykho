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
            strQuery += "N'" + dtoCT_XuatKho.MaHoaDonXuat + "',";
            strQuery += "N'" + dtoCT_XuatKho.MaMatHang + "',";
            strQuery += dtoCT_XuatKho.SoLuongXuat + ",";
            strQuery += dtoCT_XuatKho.GiaTien + ",";
            strQuery += "N'" + dtoCT_XuatKho.MaThue + "',";
            strQuery += dtoCT_XuatKho.ThanhTien + ",1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateCT_XuatKho(CT_XuatKhoDTO dtoCT_XuatKho)
        {
            string strQuery = "Update CT_XUATKHO Set ";
            strQuery += "MAMATHANG = N'" + dtoCT_XuatKho.MaMatHang + "',";
            strQuery += "SOLUONGXUAT = " + dtoCT_XuatKho.SoLuongXuat + ",";
            strQuery += "GIATIEN = " + dtoCT_XuatKho.GiaTien + ",";
            strQuery += "MATHUE = N'" + dtoCT_XuatKho.MaThue + "',";
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
