using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class HoiVien
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public HoiVien() { }
        public HoiVien(string hoTen, string diaChi)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
        }

        public virtual void nhap()
        {
            Console.Write("Nhập họ và tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void xuat()
        {
            Console.WriteLine($"Họ và tên: {HoTen}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
        }
    }
}
