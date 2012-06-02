using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LanhDaoDTO
    {
        private string _giamDoc;

        public string GiamDoc
        {
            get { return _giamDoc; }
            set { _giamDoc = value; }
        }
        private string _keToanTruong;

        public string KeToanTruong
        {
            get { return _keToanTruong; }
            set { _keToanTruong = value; }
        }
        private string _thuQuy;

        public string ThuQuy
        {
            get { return _thuQuy; }
            set { _thuQuy = value; }
        }
        private string _thuKho;

        public string ThuKho
        {
            get { return _thuKho; }
            set { _thuKho = value; }
        }

        public LanhDaoDTO()
        {
            GiamDoc = "Chưa có";
            ThuKho = "Chưa có";
            ThuQuy = "Chưa có";
            KeToanTruong = "Chưa có";
        }
    }
}
