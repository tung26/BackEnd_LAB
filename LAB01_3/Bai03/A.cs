using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class A : ThiSinh
    {
        public double Toan {  get; set; }
        public double Ly {  get; set; }
        public double Hoa {  get; set; }

        public A() { }

        public A(int sBD, string hoTen, string diaChi, int uuTien, double toan, double ly, double hoa) : base(sBD, hoTen, diaChi, uuTien)
        {
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
        }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập điểm toán: ");
                Toan = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Lý: ");
                Ly = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Hóa: ");
                Hoa = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm toán: {Toan}");
            Console.WriteLine($"Điểm Lý: {Ly}");
            Console.WriteLine($"Điểm Hóa: {Hoa}");
        }
    }
}
