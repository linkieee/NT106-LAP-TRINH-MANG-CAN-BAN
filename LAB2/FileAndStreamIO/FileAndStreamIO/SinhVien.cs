using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndStreamIO
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public float DiemToan { get; set; }
        public float DiemVan { get; set; }
        public override string ToString()
        {
            return MSSV + " - " + HoTen + " - " + SDT + " - " + DiemToan + " - " + DiemVan;
        }
    }
}
