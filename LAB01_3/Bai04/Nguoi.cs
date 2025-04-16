using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Nguoi
    {
        public int CCCD { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public Nguoi() { }
        public Nguoi(int cCCD, string hoTen, int namSinh, string ngheNghiep)
        {
            CCCD = cCCD;
            HoTen = hoTen;
            NamSinh = namSinh;
            NgheNghiep = ngheNghiep;
        }

        public void nhap()
        {
            try
            {
                Console.Write("\tNhập CCCD: ");
                CCCD = int.Parse(Console.ReadLine());
                Console.Write("\tNhập họ và tên: ");
                HoTen = Console.ReadLine();
                Console.Write("\tNhập năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
                Console.Write("\tNhập nghề nghiệp: ");
                NgheNghiep = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void xuat()
        {
            Console.WriteLine($"CCCD: {CCCD} - Họ tên: {HoTen} - Năm sinh: {NamSinh} - Nghề nghiệp: {NgheNghiep}.");
        }
    }
}
