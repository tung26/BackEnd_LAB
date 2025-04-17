using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class XeTai : PTGT
    {
        public double TrongTai { get; set; }

        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("Trọng tải: ");
                TrongTai = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Trọng tải: {TrongTai}.");
        }
    }
}
