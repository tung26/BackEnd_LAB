using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    internal class CBGV : Nguoi
    {
        public double LuongCung { get; set; }
        public double Thuong { get; set; }
        public double Phat { get; set; }
        public double LuongThucLinh => LuongCung + Thuong - Phat;

        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("Lương cứng: ");
                LuongCung = double.Parse(Console.ReadLine());
                Console.Write("Thưởng: ");
                Thuong = double.Parse(Console.ReadLine());
                Console.Write("Phạt: ");
                Phat = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Lương cứng: {LuongCung} - Thưởng: {Thuong} - Phạt: {Phat} - Lương thực lĩnh: {LuongThucLinh}");
        }
    }

}
