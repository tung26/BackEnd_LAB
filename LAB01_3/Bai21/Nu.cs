using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    internal class Nu : HocSinh
    {
        public double NuCong {  get; set; }

        public Nu() { }
        public Nu(double nuCong, string maHS, string hoTen, double toan, double ly, double hoa)
            : base(maHS, hoTen, toan, ly, hoa)
        {
            NuCong = nuCong;
        }

        public override void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập điểm nữ công: ");
                NuCong = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm nữ công: {NuCong}");
        }
    }
}
