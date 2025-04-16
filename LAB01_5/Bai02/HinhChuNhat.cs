using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class HinhChuNhat : Hinh
    {
        public double Dai {  get; set; }
        public double Rong { get; set; }

        public HinhChuNhat() { }
        public HinhChuNhat(double dai, double rong)
        {
            Dai = dai;
            Rong = rong;
        }

        public override double ChuVi()
        {
            return 2 * (Dai + Rong);
        }

        public override double DienTich()
        {
            return Dai * Rong;
        }
    }
}
