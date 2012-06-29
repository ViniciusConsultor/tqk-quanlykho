using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CT_NhapKhoDTO
    {
        private string _maCTNhapKho;

        public string MaCTNhapKho
        {
            get { return _maCTNhapKho; }
            set { _maCTNhapKho = value; }
        }

        private string _maNhapKho;

        public string MaNhapKho
        {
            get { return _maNhapKho; }
            set { _maNhapKho = value; }
        }

        private string _maMatHang;

        public string MaMatHang
        {
            get { return _maMatHang; }
            set { _maMatHang = value; }
        }

        private int _soLuongNhap;

        public int SoLuongNhap
        {
            get { return _soLuongNhap; }
            set { _soLuongNhap = value; }
        }

        private double _giaNhap;

        public double GiaNhap
        {
            get { return _giaNhap; }
            set { _giaNhap = value; }
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
