using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class PhieuChiBLL
    {
        PhieuChiDAL dalPhieuChi = new PhieuChiDAL();
        
        public string InsertPhieuChi(PhieuChiDTO dtoPhieuChi)
        {
            string strError = "";
            if (dtoPhieuChi.KhachHang.Trim().Equals("") == true)
            {
                strError += " Tên người nhận không được rỗng.";
            }
            if (dtoPhieuChi.SoTien.Equals("") == true)
            {
                strError += " Số tiền không được rỗng.";
            }
            if (dtoPhieuChi.VietBangChu.Trim().Equals("") == true)
            {
                strError += "Số tiền viết bằng chữ không được rỗng.";
            }
            if(strError == "")
            {
                bool boolResult = dalPhieuChi.InsertPhieuChi(dtoPhieuChi);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public DataTable TimKiem(string strIDNhaCungCap, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            return dalPhieuChi.TimKiem(strIDNhaCungCap, dtNgayBD, dtNgayKT);
        }

        public DataTable TimKiemChiTiet(string strIDNhaCungCap, DateTime dtNgayBD, DateTime dtNgayKT)
        {
            return dalPhieuChi.TimKiemChiTiet(strIDNhaCungCap, dtNgayBD, dtNgayKT);
        }
    }
}
