using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MatHangDTO
    {
        private string _maMH;

        public string MaMH
        {
            get { return _maMH; }
            set { _maMH = value; }
        }

        private string _maNH;

        public string MaNH
        {
            get { return _maNH; }
            set { _maNH = value; }
        }

        private string _maKho;

        public string MaKho
        {
            get { return _maKho; }
            set { _maKho = value; }
        }

        private string _tenMH;

        public string TenMH
        {
            get { return _tenMH; }
            set { _tenMH = value; }
        }

        private string _maDonViTinh;

        public string MaDonViTinh
        {
            get { return _maDonViTinh; }
            set { _maDonViTinh = value; }
        }

        private float _tonDau;

        public float TonDau
        {
            get { return _tonDau; }
            set { _tonDau = value; }
        }

        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
