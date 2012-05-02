using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class XuatKhoDTO
    {
        private string _maXuatKho;

        public string MaXuatKho
        {
            get { return _maXuatKho; }
            set { _maXuatKho = value; }
        }

        private string _maKhachHang;

        public string MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }

        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private DateTime _ngayXuat;

        public DateTime NgayXuat
        {
            get { return _ngayXuat; }
            set { _ngayXuat = value; }
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
