using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class MatHangDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAllMatHang()
        {
            string strQuery = "Select * From MATHANG mh, NHOMHANG nh, KHO k, DONVITINH dvt Where mh.MANHOMHANG = nh.MANHOMHANG and mh.MAKHO = k.MAKHO and mh.MADONVITINH = dvt.MADONVITINH and mh.TINHTRANG = 1";
            return dp.ExecuteQuery(strQuery);
        }
        public bool InsertMatHang(MatHangDTO dtoMatHang)
        {
            string strQuery = "Insert Into MATHANG Values(";
            strQuery += "N'" + dtoMatHang.MaMH + "',";
            strQuery += "N'" + dtoMatHang.MaNH + "',";
            strQuery += "N'" + dtoMatHang.MaKho + "',";
            strQuery += "N'" + dtoMatHang.TenMH + "',";
            strQuery += "N'" + dtoMatHang.MaDonViTinh + "',";
            strQuery += dtoMatHang.TonDau + ",";
            strQuery += "N'" + dtoMatHang.MoTa + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateMatHang(MatHangDTO dtoMatHang)
        {
            string strQuery = "Update MATHANG Set ";
            strQuery += "MANHOMHANG = N'" + dtoMatHang.MaNH + "',";
            strQuery += "MAKHO = N'" + dtoMatHang.MaKho + "',";
            strQuery += "TENMATHANG = N'" + dtoMatHang.TenMH + "',";
            strQuery += "MADONVITINH = N'" + dtoMatHang.MaDonViTinh + "',";
            strQuery += "TONDAU = " + dtoMatHang.TonDau + ",";
            strQuery += "MOTA = N'" + dtoMatHang.MoTa + "' ";
            strQuery += "Where MAMATHANG = N'" + dtoMatHang.MaMH + "'";
            return dp.ExecuteNonQuery(strQuery);

        }

        public bool DelMatHang(string strMaMH)
        {
            string strQuery = "Update MATHANG Set TINHTRANG = 0 Where MAMATHANG = N'" + strMaMH + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
