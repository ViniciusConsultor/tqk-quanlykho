using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TienMatDTO
    {
        private string _maTienMat;

        public string MaTienMat
        {
            get { return _maTienMat; }
            set { _maTienMat = value; }
        }

        private float _soTien;

        public float SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }
    }
}
