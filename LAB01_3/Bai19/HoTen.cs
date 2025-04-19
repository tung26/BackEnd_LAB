using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class HoTen
    {
        public string Ho {  get; set; }
        public string TenDem { get; set; }
        public string Ten {  get; set; }

        public HoTen() { }
        public HoTen(string ho, string tenDem, string ten)
        {
            Ho = ho;
            TenDem = tenDem;
            Ten = ten;
        }

        public string xuat() => $"{Ho} {TenDem} {Ten}";
    }
}
