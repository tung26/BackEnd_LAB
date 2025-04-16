using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class SoPhuc
    {
        private double phanThuc;
        private double phanAo;

        // Constructor không đối số
        public SoPhuc()
        {
            phanThuc = 0;
            phanAo = 0;
        }

        public SoPhuc(double a, double b)
        {
            phanThuc = a;
            phanAo = b;
        }

        public void Nhap()
        {
            Console.Write("Nhập phần thực: ");
            phanThuc = double.Parse(Console.ReadLine());

            Console.Write("Nhập phần ảo: ");
            phanAo = double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine($"{phanThuc} + {phanAo}i");
        }

        public SoPhuc Cong(SoPhuc sp)
        {
            return new SoPhuc(this.phanThuc + sp.phanThuc, this.phanAo + sp.phanAo);
        }

        public SoPhuc Tru(SoPhuc sp)
        {
            return new SoPhuc(this.phanThuc - sp.phanThuc, this.phanAo - sp.phanAo);
        }

        public SoPhuc Nhan(SoPhuc sp)
        {
            double thuc = this.phanThuc * sp.phanThuc - this.phanAo * sp.phanAo;
            double ao = this.phanThuc * sp.phanAo + this.phanAo * sp.phanThuc;
            return new SoPhuc(thuc, ao);
        }

        public SoPhuc Chia(SoPhuc sp)
        {
            double mau = sp.phanThuc * sp.phanThuc + sp.phanAo * sp.phanAo;
            double thuc = (this.phanThuc * sp.phanThuc + this.phanAo * sp.phanAo) / mau;
            double ao = (this.phanAo * sp.phanThuc - this.phanThuc * sp.phanAo) / mau;
            return new SoPhuc(thuc, ao);
        }
    }
}
