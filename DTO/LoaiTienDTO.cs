using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiTienDTO
    {
        private string _maLoaiTien;

        public string MaLoaiTien
        {
            get { return _maLoaiTien; }
            set { _maLoaiTien = value; }
        }

        private string _tenLoaiTien;

        public string TenLoaiTien
        {
            get { return _tenLoaiTien; }
            set { _tenLoaiTien = value; }
        }
    }
}
