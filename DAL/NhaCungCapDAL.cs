using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class NhaCungCapDAL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAllNhaCungCap()
        {
            string strQuery = "Select * From NHACUNGCAP Where TINHTRANG = 1";
            return dp.ExecuteQuery(strQuery);
        }

        public NhaCungCapDTO GetNhaCungCapByID(string strID)
        {
            string strQuery = "Select * From NHACUNGCAP Where TINHTRANG = 1 and MANHACUNGCAP = N'" + strID + "'";
            DataTable dt = dp.ExecuteQuery(strQuery);
            NhaCungCapDTO dtoNhaCungCap = new NhaCungCapDTO();
            if (dt.Rows.Count > 0)
            {
                dtoNhaCungCap.MaNCC = dt.Rows[0]["MANHACUNGCAP"].ToString();
                dtoNhaCungCap.TenNCC = dt.Rows[0]["TENNHACUNGCAP"].ToString();
                dtoNhaCungCap.DiaChi = dt.Rows[0]["DIACHI"].ToString();
                dtoNhaCungCap.MaSoThue = dt.Rows[0]["MASOTHUE"].ToString();
                dtoNhaCungCap.SoTaiKhoan = dt.Rows[0]["SOTAIKHOAN"].ToString();
                dtoNhaCungCap.NganHang = dt.Rows[0]["NGANHANG"].ToString();
                dtoNhaCungCap.SoDienThoai = dt.Rows[0]["SODIENTHOAI"].ToString();
                dtoNhaCungCap.Email = dt.Rows[0]["EMAIL"].ToString();
            }
            return dtoNhaCungCap;
        }

        public bool InsertNhaCungCap(NhaCungCapDTO dtoNhaCungCap)
        {
            string strQuery = "Insert Into NHACUNGCAP Values(";
            strQuery += "N'" + dtoNhaCungCap.MaNCC + "',";
            strQuery += "N'" + dtoNhaCungCap.TenNCC + "',";
            strQuery += "N'" + dtoNhaCungCap.DiaChi + "',";
            strQuery += "N'" + dtoNhaCungCap.MaSoThue + "',";
            strQuery += "N'" + dtoNhaCungCap.SoTaiKhoan + "',";
            strQuery += "N'" + dtoNhaCungCap.NganHang + "',";
            strQuery += dtoNhaCungCap.DuNo + ",";
            strQuery += "N'" + dtoNhaCungCap.SoDienThoai + "',";
            strQuery += "N'" + dtoNhaCungCap.Email + "',";
            strQuery += "N'" + dtoNhaCungCap.GhiChu + "', 1)";
            return dp.ExecuteNonQuery(strQuery);
        }

        public bool UpdateNhaCungCap(NhaCungCapDTO dtoNhaCungCap)
        {
            string strQuery = "Update NHACUNGCAP Set ";
            strQuery += "TENNHACUNGCAP = N'" + dtoNhaCungCap.TenNCC + "',";
            strQuery += "DIACHI = N'" + dtoNhaCungCap.DiaChi + "',";
            strQuery += "MASOTHUE = N'" + dtoNhaCungCap.MaSoThue + "',";
            strQuery += "SOTAIKHOAN = N'" + dtoNhaCungCap.SoTaiKhoan + "',";
            strQuery += "NGANHANG = N'" + dtoNhaCungCap.NganHang + "',";
            strQuery += "DUNO = " + dtoNhaCungCap.DuNo + ",";
            strQuery += "SODIENTHOAI = N'" + dtoNhaCungCap.SoDienThoai + "',";
            strQuery += "EMAIL = N'" + dtoNhaCungCap.Email + "',";
            strQuery += "GHICHU = N'" + dtoNhaCungCap.GhiChu + "' ";
            strQuery += "Where MANHACUNGCAP = N'" + dtoNhaCungCap.MaNCC + "'";
            return dp.ExecuteNonQuery(strQuery);
            
        }

        public bool UpdateCongNo(string strMaNhaCC, double dbDuNo)
        {
            string strQuery = "Update NHACUNGCAP Set ";
            strQuery += "DUNO = " + dbDuNo + " ";
            strQuery += "Where MANHACUNGCAP = N'" + strMaNhaCC + "'";
            return dp.ExecuteNonQuery(strQuery);

        }

        public bool DelNhaCungCap(string strMaNCC)
        {
            string strQuery = "Update NHACUNGCAP Set TINHTRANG = 0 where MANHACUNGCAP = N'" + strMaNCC + "'";
            return dp.ExecuteNonQuery(strQuery);
        }
    }
}
