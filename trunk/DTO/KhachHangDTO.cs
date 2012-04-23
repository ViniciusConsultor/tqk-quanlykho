using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {
        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        private string _tenKH;

        public string TenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
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

        private string _maSoThue;

        public string MaSoThue
        {
            get { return _maSoThue; }
            set { _maSoThue = value; }
        }

        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private string _sDT;

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }

        private string _fax;

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
