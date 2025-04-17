using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class OTo : PTGT
    {
        public int SoChoNgoi { get; set; }
        public string KieuDongCo { get; set; }

        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("Số chỗ ngồi: ");
                SoChoNgoi = int.Parse(Console.ReadLine());
                Console.Write("Kiểu động cơ: ");
                KieuDongCo = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Số chỗ ngồi: {SoChoNgoi} - Kiểu động cơ: {KieuDongCo}.");
        }
    }
}
