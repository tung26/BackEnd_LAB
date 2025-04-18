using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Diem
    {
        public double x, y;

        public Diem() { }

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Nhap()
        {
            try
            {
                Console.Write("Nhập hoành độ x: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("Nhập tung độ y: ");
                y = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Xuat()
        {
            Console.Write($"({x}, {y})");
        }

        public double TinhKhoangCach(Diem d2)
        {
            return Math.Sqrt(Math.Pow(x - d2.x, 2) + Math.Pow(y - d2.y, 2));
        }
    }
}
