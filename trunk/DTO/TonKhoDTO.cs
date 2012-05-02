using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TonKhoDTO
    {
        private string _maTonKho;

        public string MaTonKho
        {
            get { return _maTonKho; }
            set { _maTonKho = value; }
        }

        private DateTime _ngayThang;

        public DateTime NgayThang
        {
            get { return _ngayThang; }
            set { _ngayThang = value; }
        }

        private string _maMatHang;

        public string MaMatHang
        {
            get { return _maMatHang; }
            set { _maMatHang = value; }
        }

        private int _soLuongDau;

        public int SoLuongDau
        {
            get { return _soLuongDau; }
            set { _soLuongDau = value; }
        }

        private int _soLuongNhap;

        public int SoLuongNhap
        {
            get { return _soLuongNhap; }
            set { _soLuongNhap = value; }
        }

        private int _soLuongXuat;

        public int SoLuongXuat
        {
            get { return _soLuongXuat; }
            set { _soLuongXuat = value; }
        }

        private int _soLuongTon;

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }
    }
}
