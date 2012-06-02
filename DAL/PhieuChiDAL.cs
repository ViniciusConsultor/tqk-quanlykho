using System;
using System.Collections.Generic;
using System.Text;
using DTO;
namespace DAL
{
    public class PhieuChiDAL
    {
        DataProvider dp = new DataProvider();

        public bool InsertPhieuChi(PhieuChiDTO dtoPhieuChi)
        {
            string strQuery = "Insert Into PHIEUCHI Values(";
            strQuery += "N'" + dtoPhieuChi.MaPhieuChi + "',";
            strQuery += "N'" + dtoPhieuChi.MaNV + "',";
            strQuery += "N'" + dtoPhieuChi.KhachHang + "',";
            strQuery += "N'" + dtoPhieuChi.NgayLap + "',";
            strQuery += "N'" + dtoPhieuChi.DiaChi + "',";
            strQuery += "N'" + dtoPhieuChi.SoPhieu + "',";
            strQuery +=  dtoPhieuChi.No + ",";
            strQuery +=  dtoPhieuChi.Co + ",";
            strQuery += "N'" + dtoPhieuChi.LyDoChi + "',";
            strQuery +=  dtoPhieuChi.SoTien + ",";
            strQuery += "N'" + dtoPhieuChi.VietBangChu + "',";
            strQuery += "N'" + dtoPhieuChi.KemTheo + "')";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
