using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class TamGiac : DaGiac
    {
        public TamGiac() {
            SoCanh = 3;
        }
        public override void Nhap()
        {
            try
            {
                KichThuocCanh = new double[SoCanh];
                Console.WriteLine("Nhập 3 cạnh của tam giác:");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Cạnh {i + 1}: ");
                    KichThuocCanh[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double TinhDienTich()
        {
            double a = KichThuocCanh[0];
            double b = KichThuocCanh[1];
            double c = KichThuocCanh[2];
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool LaTamGiacVuong()
        {
            Array.Sort(KichThuocCanh);
            double a = KichThuocCanh[0];
            double b = KichThuocCanh[1];
            double c = KichThuocCanh[2];

            return c * c == a * a + b * b;
        }
    }

}
