using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Nguoi
    {
        public string HoTen {  get; set; }
        public int Tuoi {  get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }

        public Nguoi() { }
        public Nguoi(string hoTen, int tuoi, int namSinh, string queQuan, string gioiTinh)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            NamSinh = namSinh;
            QueQuan = queQuan;
            GioiTinh = gioiTinh;
        }

        public virtual void Nhap()
        {
            try
            {
                Console.Write("Nhập họ tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhập tuổi: ");
                Tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhập năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập quê quán: ");
                QueQuan = Console.ReadLine();
                Console.Write("Nhập giới tính (Nam/Nữ): ");
                GioiTinh = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen} - Tuổi: {Tuoi} - Năm sinh: {NamSinh} - Quê quán: {QueQuan} - Giới tính: {GioiTinh}");
        }
    }
}
