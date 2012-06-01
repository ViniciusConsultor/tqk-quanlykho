using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
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
            if (dtoPhieuChi.DiaChi.Trim().Equals("") == true)
            {
                strError += " Địa chỉ người nhận không được rỗng.";
            }
            if (dtoPhieuChi.LyDoChi.Trim().Equals("") == true)
            {
                strError += " Lý do chi không được rỗng.";
            }
            if (dtoPhieuChi.SoTien.Equals("") == true)
            {
                strError += " Số tiền không được rỗng.";
            }
            if (dtoPhieuChi.VietBangChu.Trim().Equals("") == true)
            {
                strError += "Số tiền viết bằng chữ không được rỗng.";
            }
            if(dtoPhieuChi.SoPhieu.Trim().Equals("") == true)
            {
                strError += " Số phiếu không được rỗng.";
            }
            if(dtoPhieuChi.No.Equals("") == true)
            {
                strError += " No không được rỗng.";
            }
            if(dtoPhieuChi.Co.Equals("") == true)
            {
                strError += " Co không được rỗng.";
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
    }
}
