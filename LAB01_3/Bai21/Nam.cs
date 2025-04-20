using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    internal class Nam : HocSinh
    {
        public double KiThuat { get; set; }

        public Nam() { }
        public Nam(double kiThuat, string maHS, string hoTen, double toan, double ly, double hoa)
            : base(maHS, hoTen, toan, ly, hoa)
        {
            KiThuat = kiThuat;
        }

        public override void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập điểm kĩ thuật: ");
                KiThuat = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm kĩ thuật: {KiThuat}");
        }
    }
}
