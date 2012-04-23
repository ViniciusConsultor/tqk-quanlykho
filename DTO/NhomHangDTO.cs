using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhomHangDTO
    {
        private string _maNH;

        public string MaNH
        {
            get { return _maNH; }
            set { _maNH = value; }
        }

        private string _tenNhomHang;

        public string TenNhomHang
        {
            get { return _tenNhomHang; }
            set { _tenNhomHang = value; }
        }

        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}
