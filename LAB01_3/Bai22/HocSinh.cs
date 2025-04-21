using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    internal class HocSinh
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public double TongDiem { get; set; }

        public HocSinh() { }

        public HocSinh(string hoTen, int namSinh, double tongDiem)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            TongDiem = tongDiem;
        }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập tổng điểm: ");
            TongDiem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void Xuat()
        {
            Console.WriteLine($"{ChuanHoaTen(HoTen),-25} | {NamSinh,-10} | {TongDiem,-10:F2}");
        }

        private string ChuanHoaTen(string ten)
        {
            var words = ten.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                words[i] = char.ToUpper(words[i][0]) + words[i][1..].ToLower();

            return string.Join(' ', words);
        }
    }
}
