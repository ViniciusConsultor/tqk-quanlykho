using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThueDTO
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
    }
}
