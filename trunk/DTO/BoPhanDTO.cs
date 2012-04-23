using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BoPhanDTO
    {
        private string _maBP;

        public string MaBP
        {
            get { return _maBP; }
            set { _maBP = value; }
        }

        private string _tenBoPhan;

        public string TenBoPhan
        {
            get { return _tenBoPhan; }
            set { _tenBoPhan = value; }
        }

        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
