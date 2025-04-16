using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string SoCMND { get; set; }

        public Nguoi() { }
        public Nguoi(string hoTen, int namSinh, string queQuan, string soCMND)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            QueQuan = queQuan;
            SoCMND = soCMND;
        }

        public virtual void Nhap()
        {
            try
            {
                Console.Write("Họ tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Quê quán: ");
                QueQuan = Console.ReadLine();
                Console.Write("Số CMND: ");
                SoCMND = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen} - Năm sinh: {NamSinh} - Quê quán: {QueQuan} - CMND: {SoCMND}");
        }
    }

}
