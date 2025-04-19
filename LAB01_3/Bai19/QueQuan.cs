using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class QueQuan
    {
        public string Xa {  get; set; }
        public string Huyen { get; set; }
        public string Tinh { get; set; }

        public QueQuan() { }
        public QueQuan(string xa, string huyen, string tinh)
        {
            Xa = xa;
            Huyen = huyen;
            Tinh = tinh;
        }

        public string xuat() => $"{Xa}, {Huyen}, {Tinh}";
    }
}
