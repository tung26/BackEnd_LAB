using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class HinhTamGiac : Hinh
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public HinhTamGiac() { }
        public HinhTamGiac(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double ChuVi()
        {
            return A + B + C;
        }

        public override double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
