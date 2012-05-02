using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KhuVucDTO
    {
        private string _maKV;

        public string MaKV
        {
            get { return _maKV; }
            set { _maKV = value; }
        }

        private string _tenKV;

        public string TenKV
        {
            get { return _tenKV; }
            set { _tenKV = value; }
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
