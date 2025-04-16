using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public int CCCD { get; set; }

        public Nguoi() {}
        public Nguoi(string hoTen, int namSinh, int cCCD)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            CCCD = cCCD;
        }

        public void nhap() {
            try {
                Console.Write("Nhập họ và tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhập năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập CCCD: ");
                CCCD = int.Parse(Console.ReadLine());
            }
            catch {
                throw;
            }
        }

        public void xuat() {
            Console.WriteLine($"CCCD: {CCCD} - Họ tên: {HoTen} - Năm sinh: {NamSinh}.");
        }
    }
}
