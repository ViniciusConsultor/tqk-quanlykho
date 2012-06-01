using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
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
            if (dtoPhieuThu.DiaChi.Trim().Equals("") == true)
            {
                strError += " Địa chỉ người nhận không được rỗng.";
            }
            if (dtoPhieuThu.LyDoThu.Trim().Equals("") == true)
            {
                strError += " Lý do thu không được rỗng.";
            }
            if (dtoPhieuThu.SoTien.Equals("") == true)
            {
                strError += " Số tiền không được rỗng.";
            }
            if (dtoPhieuThu.VietBangChu.Trim().Equals("") == true)
            {
                strError += "Số tiền viết bằng chữ không được rỗng.";
            }
            if (dtoPhieuThu.SoPhieu.Trim().Equals("") == true)
            {
                strError += " Số phiếu không được rỗng.";
            }
            if (dtoPhieuThu.No.Equals("") == true)
            {
                strError += " No không được rỗng.";
            }
            if (dtoPhieuThu.Co.Equals("") == true)
            {
                strError += " Co không được rỗng.";
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
    }
}
