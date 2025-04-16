using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class CongNhan : CanBo
    {
        public int CapBac {  get; set; }

        public CongNhan(int CapBac, string hoTen, byte gioiTinh, int namSinh, string diaChi) : base(hoTen, gioiTinh, namSinh, diaChi)
        {
            this.CapBac = CapBac;
        }

        public CongNhan() { }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.WriteLine("Nhập cấp bậc: ");
                CapBac = int.Parse(Console.ReadLine());
                if (CapBac <= 0 || CapBac > 7) throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Cấp bậc: {CapBac}");
        }
    }
}
