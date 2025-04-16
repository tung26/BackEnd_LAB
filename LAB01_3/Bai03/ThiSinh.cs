using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal abstract class ThiSinh
    {
        public int SBD { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int UuTien { get; set; }

        public ThiSinh() { }

        public ThiSinh(int sBD, string hoTen, string diaChi, int uuTien)
        {
            SBD = sBD;
            HoTen = hoTen;
            DiaChi = diaChi;
            UuTien = uuTien;
        }

        public void xuat()
        {
            Console.WriteLine($"Số báo danh: {SBD}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Ưu tiên: {UuTien}");
        }

        public void nhap()
        {
            try
            {
                Console.Write("Nhập số báo danh: ");
                SBD = int.Parse( Console.ReadLine() );
                Console.Write("Nhập họ tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhập địa chỉ: ");
                DiaChi = Console.ReadLine();
                Console.Write("Nhập điểm ưu tiên: ");
                UuTien = int.Parse( Console.ReadLine() );
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
