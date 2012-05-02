using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhapKhoDTO
    {
        private string _maNhapKho;

        public string MaNhapKho
        {
            get { return _maNhapKho; }
            set { _maNhapKho = value; }
        }

        private string _maNCC;

        public string MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }

        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private DateTime _ngayNhap;

        public DateTime NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }

        private int _soHoaDon;

        public int SoHoaDon
        {
            get { return _soHoaDon; }
            set { _soHoaDon = value; }
        }

        private DateTime _ngayLapHD;

        public DateTime NgayLapHD
        {
            get { return _ngayLapHD; }
            set { _ngayLapHD = value; }
        }

        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
