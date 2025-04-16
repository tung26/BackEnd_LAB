using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class HinhTron : Hinh
    {
        public double BanKinh {  get; set; }

        public HinhTron() { }
        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double ChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public override double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }
}
