using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TienMatDTO
    {
        private double _soTien;

        public double SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }

        public TienMatDTO()
        {
            SoTien = 0;
        }
    }
}
