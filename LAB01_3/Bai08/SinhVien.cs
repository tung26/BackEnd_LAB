using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string Lop { get; set; }

        public virtual void Nhap()
        {
            try
            {
                Console.Write("Mã SV: ");
                MaSV = Console.ReadLine();
                Console.Write("Họ tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Lớp: ");
                Lop = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Mã SV: {MaSV} - Họ tên: {HoTen} - Năm sinh: {NamSinh} - Lớp: {Lop}.");
        }
    }

}
