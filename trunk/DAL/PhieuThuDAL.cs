using System;
using System.Collections.Generic;
using System.Text;
using DTO;
namespace DAL
{
    public class PhieuThuDAL
    {
        DataProvider dp = new DataProvider();
        public bool InsertPhieuThu(PhieuThuDTO dtoPhieuThu)
        {
            string strQuery = "Insert Into PHIEUTHU Values(";
            strQuery += "N'" + dtoPhieuThu.MaPhieuThu + "',";
            strQuery += "N'" + dtoPhieuThu.MaNV + "',";
            strQuery += "N'" + dtoPhieuThu.KhachHang + "',";
            strQuery += "N'" + dtoPhieuThu.DiaChi + "',";
            strQuery += "N'" + dtoPhieuThu.NgayLap + "',";
            strQuery += "N'" + dtoPhieuThu.SoPhieu + "',";
            strQuery += dtoPhieuThu.No + ",";
            strQuery += dtoPhieuThu.Co + ",";
            strQuery += "N'" + dtoPhieuThu.LyDoThu + "',";
            strQuery += dtoPhieuThu.SoTien + ",";
            strQuery += "N'" + dtoPhieuThu.VietBangChu + "',";
            strQuery += "N'" + dtoPhieuThu.KemTheo + "')";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
