using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class DaGiac
    {
        protected int SoCanh;
        protected double[] KichThuocCanh;

        public virtual void Nhap()
        {
            try
            {
                Console.Write("Nhập số cạnh của đa giác: ");
                SoCanh = int.Parse(Console.ReadLine());
                KichThuocCanh = new double[SoCanh];

                for (int i = 0; i < SoCanh; i++)
                {
                    Console.Write($"Cạnh thứ {i + 1}: ");
                    KichThuocCanh[i] = double.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual double TinhChuVi()
        {
            double chuVi = 0;
            foreach (double canh in KichThuocCanh)
            {
                chuVi += canh;
            }
            return chuVi;
        }

        public virtual void InCanh()
        {
            Console.Write("Các cạnh: ");
            foreach (double canh in KichThuocCanh)
            {
                Console.Write($"{canh} ");
            }
            Console.WriteLine();
        }
    }

}
