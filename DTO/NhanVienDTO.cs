using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
     public class NhanVienDTO
    {
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private string _maBP;

        public string MaBP
        {
            get { return _maBP; }
            set { _maBP = value; }
        }

        private string _tenNV;

        public string TenNV
        {
            get { return _tenNV; }
            set { _tenNV = value; }
        }

        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        private string _chucVu;

        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }
       
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        private string _soCMND;

        public string CMND
        {
            get { return _soCMND; }
            set { _soCMND = value; }
        }

        private string _soDienThoai;

        public string SoDT
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
