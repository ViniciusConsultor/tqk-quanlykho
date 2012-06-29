using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class PhieuThuBLL
    {
        PhieuThuDAL dalPhieuThu = new PhieuThuDAL();
        public string InsertPhieuThu(PhieuThuDTO dtoPhieuThu)
        {
            string strError = "";
            if (dtoPhieuThu.KhachHang.Trim().Equals("") == true)
            {
                strError += " Tên người nhận không được rỗng.";
            }
            if (dtoPhieuThu.SoTien.Equals("") == true)
            {
                strError += " Số tiền không được rỗng.";
            }
            if (dtoPhieuThu.VietBangChu.Trim().Equals("") == true)
            {
                strError += "Số tiền viết bằng chữ không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalPhieuThu.InsertPhieuThu(dtoPhieuThu);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public DataTable TimKiem(string strIDKhachHang, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            return dalPhieuThu.TimKiem(strIDKhachHang, dtNgayBD, dtNgayKT);
        }

        public DataTable TimKiemChiTiet(string strIDKhachHang, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            return dalPhieuThu.TimKiemChiTiet(strIDKhachHang, dtNgayBD, dtNgayKT);
        }
    }
}
