using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Nguoi
    {
        protected string HoTen;
        protected bool GioiTinh;
        protected int Tuoi;

        public Nguoi() { }

        public Nguoi(string hoTen, bool gioiTinh, int tuoi)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
        }

        public string getHoTen()
        {
            return HoTen;
        }

        public virtual void nhap()
        {
            try
            {
                Console.Write("Nhập họ tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhập giới tính(True: Nam - False: Nữ): ");
                GioiTinh = bool.Parse(Console.ReadLine());
                Console.Write("Nhập tuổi: ");
                Tuoi = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void In()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Giới tính: {(GioiTinh ? "Nam" : "Nữ")}");
            Console.WriteLine($"Tuổi: {Tuoi}");
        }
    }
}
