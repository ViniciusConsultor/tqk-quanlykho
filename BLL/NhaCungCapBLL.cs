using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL dalNhaCungCap = new NhaCungCapDAL();
        public DataTable GetAllNhaCungCap()
        {
            return dalNhaCungCap.GetAllNhaCungCap();
        }

        public NhaCungCapDTO GetNhaCungCapByID(string strID)
        {
            return dalNhaCungCap.GetNhaCungCapByID(strID);
        }

        public string InsertNhaCungCap(NhaCungCapDTO dtoNhaCungCap)
        {
            string strError = "";
            if (dtoNhaCungCap.TenNCC.Trim().Equals("") == true)
            {
                strError += " Tên nhà cung cấp không được rỗng.";
            }
            if (dtoNhaCungCap.DiaChi.Trim().Equals("") == true)
            {
                strError += " Địa chỉ không được rỗng.";
            }
            if (dtoNhaCungCap.SoTaiKhoan.Trim().Equals("") == true)
            {
                strError += "Số tài khoản không được rỗng.";
            }
            if (dtoNhaCungCap.MaSoThue.Trim().Equals("") == true)
            {
                strError += "Mã số thuế không được rỗng.";
            }
            if (dtoNhaCungCap.NganHang.Trim().Equals("") == true)
            {
                strError += " Tên ngân hàng không được rỗng.";
            }
            if (dtoNhaCungCap.SoDienThoai.Trim().Equals("") == true)
            {
                strError += "Số điện thoại không được rỗng.";
            }
            if (dtoNhaCungCap.Email.Trim().Equals("") == true)
            {
                strError += " Email không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalNhaCungCap.InsertNhaCungCap(dtoNhaCungCap);
                return "ok";
            }
            else
            {
                return strError;
            }

        }

        public string UpdateNhaCungCap(NhaCungCapDTO dtoNhaCungCap)
        {
            string strError = "";
            if (dtoNhaCungCap.TenNCC.Trim().Equals("") == true)
            {
                strError += " Tên nhà cung cấp không được rỗng.";
            }
            if (dtoNhaCungCap.DiaChi.Trim().Equals("") == true)
            {
                strError += " Địa chỉ không được rỗng.";
            }
            if (dtoNhaCungCap.SoTaiKhoan.Trim().Equals("") == true)
            {
                strError += "Số tài khoản không được rỗng.";
            }
            if (dtoNhaCungCap.MaSoThue.Trim().Equals("") == true)
            {
                strError += "Mã số thuế không được rỗng.";
            }
            if (dtoNhaCungCap.NganHang.Trim().Equals("") == true)
            {
                strError += " Tên ngân hàng không được rỗng.";
            }
            if (dtoNhaCungCap.SoDienThoai.Trim().Equals("") == true)
            {
                strError += "Số điện thoại không được rỗng.";
            }
            if (dtoNhaCungCap.Email.Trim().Equals("") == true)
            {
                strError += " Email không được rỗng.";
            }
            if (strError == "")
            {
                bool boolResult = dalNhaCungCap.UpdateNhaCungCap(dtoNhaCungCap);
                return "ok";
            }
            else
            {
                return strError;
            }
        }

        public bool DelNhaCungCap(string strMaNCC)
        {
            return dalNhaCungCap.DelNhaCungCap(strMaNCC);
        }
    }
}
