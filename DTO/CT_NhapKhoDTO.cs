using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CT_NhapKhoDTO
    {
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

        private float _giaNhap;

        public float GiaNhap
        {
            get { return _giaNhap; }
            set { _giaNhap = value; }
        }

        private string _maThue;

        public string MaThue
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
