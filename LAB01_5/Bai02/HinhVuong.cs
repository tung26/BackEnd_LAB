using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class HinhVuong : Hinh
    {
        public double Canh { get; set; }

        public HinhVuong() { }
        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        public override double ChuVi()
        {
            return 4 * Canh;
        }

        public override double DienTich()
        {
            return Canh * Canh;
        }
    }
}
