using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CT_XuatKhoDTO
    {
        private string _maHoaDonXuat;

        public string MaHoaDonXuat
        {
            get { return _maHoaDonXuat; }
            set { _maHoaDonXuat = value; }
        }

        private string _maMatHang;

        public string MaMatHang
        {
            get { return _maMatHang; }
            set { _maMatHang = value; }
        }

        private int _soLuongXuat;

        public int SoLuongXuat
        {
            get { return _soLuongXuat; }
            set { _soLuongXuat = value; }
        }

        private float _giaTien;

        public float GiaTien
        {
            get { return _giaTien; }
            set { _giaTien = value; }
        }

        private int _maThue;

        public int MaThue
        {
            get { return _maThue; }
            set { _maThue = value; }
        }

        private float _thanhTien;

        public float ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }

        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
