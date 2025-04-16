using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class KhachHang
    {
        public string HoTen { get; set; }
        public string SoNha { get; set; }
        public string MaCongTo { get; set; }

        public void Nhap()
        {
            try
            {
                Console.Write("Nhập họ tên chủ hộ: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhập số nhà: ");
                SoNha = Console.ReadLine();
                Console.Write("Nhập mã số công tơ: ");
                MaCongTo = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen} - Số nhà: {SoNha} - Mã công tơ: {MaCongTo}.");
        }
    }

}
