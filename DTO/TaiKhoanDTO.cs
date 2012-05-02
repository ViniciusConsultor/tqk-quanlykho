using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string _maTaiKhoan;

        public string MaTaiKhoan
        {
            get { return _maTaiKhoan; }
            set { _maTaiKhoan = value; }
        }

        private string _soTaiKhoan;

        public string SoTaiKhoan
        {
            get { return _soTaiKhoan; }
            set { _soTaiKhoan = value; }
        }

        private string _nganHang;

        public string NganHang
        {
            get { return _nganHang; }
            set { _nganHang = value; }
        }

        private float _luongTien;

        public float LuongTien
        {
            get { return _luongTien; }
            set { _luongTien = value; }
        }

        private string _loaiTien;

        public string LoaiTien
        {
            get { return _loaiTien; }
            set { _loaiTien = value; }
        }
    }
}
