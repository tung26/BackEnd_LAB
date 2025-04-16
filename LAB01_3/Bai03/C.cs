using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class C : ThiSinh
    {
        public double Van { get; set; }
        public double Su { get; set; }
        public double Dia { get; set; }

        public C() { }

        public C(int sBD, string hoTen, string diaChi, int uuTien, double van, double su, double dia) : base(sBD, hoTen, diaChi, uuTien)
        {
            Van = van;
            Su = su;
            Dia = dia;
        }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập điểm văn: ");
                Van = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm sử: ");
                Su = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm địa: ");
                Dia = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm văn: {Van}");
            Console.WriteLine($"Điểm sử: {Su}");
            Console.WriteLine($"Điểm đại: {Dia}");
        }
    }
}
