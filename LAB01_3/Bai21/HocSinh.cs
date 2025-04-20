using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    internal class HocSinh
    {
        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }

        public HocSinh() { }
        public HocSinh(string maHS, string hoTen, double toan, double ly, double hoa)
        {
            MaHS = maHS;
            HoTen = hoTen;
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
        }

        public virtual void nhap()
        {
            try
            {
                Console.Write("Nhập mã học sinh: ");
                MaHS = Console.ReadLine();
                Console.Write("Nhập tên học sinh");
                HoTen = Console.ReadLine();
                Console.Write("Nhập điểm toán: ");
                Toan = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm lý: ");
                Ly = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm hóa: ");
                Hoa = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void xuat()
        {
            Console.WriteLine($"Mã học sinh: {MaHS}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Điểm toán: {Toan}");
            Console.WriteLine($"Điểm lý: {Ly}");
            Console.WriteLine($"Điểm hóa: {Hoa}");
        }
    }
}
