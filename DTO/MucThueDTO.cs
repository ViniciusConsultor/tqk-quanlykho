using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MucThueDTO
    {
        private string _maTH;

        public string MaTH
        {
            get { return _maTH; }
            set { _maTH = value; }
        }

        private int _soThue;

        public int SoThue
        {
            get { return _soThue; }
            set { _soThue = value; }
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
