using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CT_XuatKhoDTO
    {
        private string _maCTXuatKho;

        public string MaCTXuatKho
        {
            get { return _maCTXuatKho; }
            set { _maCTXuatKho = value; }
        }

        private string _maXuatKho;

        public string MaXuatKho
        {
            get { return _maXuatKho; }
            set { _maXuatKho = value; }
        }

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

        private double _giaTien;

        public double GiaTien
        {
            get { return _giaTien; }
            set { _giaTien = value; }
        }

        private double _thanhTien;

        public double ThanhTien
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
