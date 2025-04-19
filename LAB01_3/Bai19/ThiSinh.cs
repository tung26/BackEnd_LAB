using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class ThiSinh
    {
        public HoTen FullName { get; set; }
        public QueQuan DiaChi { get; set; }
        public string Truong {  get; set; }
        public int Tuoi { get; set; }
        public string SBD { get; set; }
        public DiemThi Diem {  get; set; }

        public ThiSinh() { }
        public ThiSinh(HoTen fullName, QueQuan diaChi, string truong, int tuoi, string sBD, DiemThi diem)
        {
            FullName = fullName;
            DiaChi = diaChi;
            Truong = truong;
            Tuoi = tuoi;
            SBD = sBD;
            Diem = diem;
        }

        public void nhap()
        {
            try
            {
                string ho, dem, ten, xa, huyen, tinh, sBD, truong;
                double T, L, H;
                int age;

                Console.Write("Nhập họ: ");
                ho = Console.ReadLine();
                Console.Write("Nhập tên đệm: ");
                dem = Console.ReadLine();
                Console.Write("Nhập tên: ");
                ten = Console.ReadLine();
                Console.Write("Nhập xã: ");
                xa = Console.ReadLine();
                Console.Write("Nhập huyện: ");
                huyen = Console.ReadLine();
                Console.Write("Nhập tỉnh: ");
                tinh = Console.ReadLine();
                Console.Write("Nhập trường: ");
                truong = Console.ReadLine();
                Console.Write("Nhập tuổi: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Nhập số báo danh: ");
                sBD = Console.ReadLine();
                Console.Write("Nhập điểm toán: ");
                T = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm lý: ");
                L = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm hóa: ");
                H = double.Parse(Console.ReadLine());

                FullName = new HoTen(ho, dem, ten);
                DiaChi = new QueQuan(xa, huyen, tinh);
                Diem = new DiemThi(T, L, H);
                Truong = truong;
                Tuoi = age;
                SBD = sBD;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void xuat()
        {
            FullName.xuat();
            DiaChi.xuat();
            Console.WriteLine($"Trường: {Truong}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Số báo danh: {SBD}");
            Diem.xuat();
        }
    }
}
