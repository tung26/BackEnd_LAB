using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal abstract class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }

        public TaiLieu() { }

        public TaiLieu(string maTaiLieu, string nhaXuatBan, int soBanPhatHanh)
        {
            MaTaiLieu = maTaiLieu;
            NhaXuatBan = nhaXuatBan;
            SoBanPhatHanh = soBanPhatHanh;
        }

        public void nhap()
        {
            Console.Write("Nhập mã: ");
            MaTaiLieu = Console.ReadLine();
            Console.Write("Nhập tên nhà xuất bản: ");
            NhaXuatBan = Console.ReadLine();
            Console.Write("Nhập số bản phát hành: ");
            try
            {
                SoBanPhatHanh = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void xuat()
        {
            Console.WriteLine($"Mã: {MaTaiLieu}");
            Console.WriteLine($"Nhà sản xuất: {NhaXuatBan}");
            Console.WriteLine($"Số bản phát hành: {NhaXuatBan}");
        }
    }
}
