using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal abstract class CanBo
    {
        public string HoTen {  get; set; }
        public byte GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }

        public CanBo() { }

        public CanBo(string hoTen, byte gioiTinh, int namSinh, string diaChi)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NamSinh = namSinh;
            this.DiaChi = diaChi;
        }

        public void nhap()
        {
            try
            {
                Console.Write("Nhập họ tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhập giới tính: ");
                GioiTinh = Byte.Parse(Console.ReadLine());
                Console.Write("Nhập năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
                if (NamSinh <= 0) throw new Exception();
                Console.Write("Nhập địa chỉ: ");
                DiaChi = Console.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void xuat()
        {
            Console.WriteLine($"Họ và tên: {HoTen}.");
            string gender = GioiTinh == 1 ? "Nam" : "Nữ";
            Console.WriteLine($"Giới Tính: {gender}.");
            Console.WriteLine($"Năm sinh: {NamSinh}.");
            Console.WriteLine($"Địa chỉ: {DiaChi}.");
        }
    }
}
