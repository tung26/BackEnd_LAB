using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class TamGiac
    {
        private Diem d1, d2, d3;

        public TamGiac()
        {
            d1 = new Diem();
            d2 = new Diem();
            d3 = new Diem();
        }

        public TamGiac(Diem d1, Diem d2, Diem d3)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
        }

        public void Nhap()
        {
            try
            {
                Console.WriteLine("Nhập điểm thứ 1: ");
                d1.Nhap();

                Console.WriteLine("Nhập điểm thứ 2: ");
                d2.Nhap();

                Console.WriteLine("Nhập điểm thứ 3: ");
                d3.Nhap();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double TinhChuVi()
        {
            double a = d1.TinhKhoangCach(d2);
            double b = d2.TinhKhoangCach(d3);
            double c = d3.TinhKhoangCach(d1);
            return a + b + c;
        }

        public double TinhDienTich()
        {
            double a = d1.TinhKhoangCach(d2);
            double b = d2.TinhKhoangCach(d3);
            double c = d3.TinhKhoangCach(d1);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Xuat()
        {
            Console.Write("Tam giác với các điểm: ");
            d1.Xuat(); Console.Write(" - ");
            d2.Xuat(); Console.Write(" - ");
            d3.Xuat();
            Console.WriteLine();
        }
    }
}
