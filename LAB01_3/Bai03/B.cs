using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class B : ThiSinh
    {
        public double Toan { get; set; }
        public double Sinh { get; set; }
        public double Hoa { get; set; }

        public B() { }

        public B(int sBD, string hoTen, string diaChi, int uuTien, double toan, double sinh, double hoa) : base(sBD, hoTen, diaChi, uuTien)
        {
            Toan = toan;
            Sinh = sinh;
            Hoa = hoa;
        }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập điểm toán: ");
                Toan = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm sinh: ");
                Sinh = double.Parse(Console.ReadLine());
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
            Console.WriteLine($"Điểm Sinh: {Sinh}");
            Console.WriteLine($"Điểm Hóa: {Hoa}");
        }
    }
}
