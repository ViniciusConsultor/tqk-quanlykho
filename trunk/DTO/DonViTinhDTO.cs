using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DonViTinhDTO
    {
        private string _maDVT;

        public string MaDVT
        {
            get { return _maDVT; }
            set { _maDVT = value; }
        }

        private string _donViTinh;

        public string DonViTinh
        {
            get { return _donViTinh; }
            set { _donViTinh = value; }
        }
    }
}
