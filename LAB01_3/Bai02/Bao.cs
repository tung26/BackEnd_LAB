using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Bao : TaiLieu
    {
        public int NgayPhatHanh {  get; set; }

        public Bao() { }

        public Bao(int ngayPhatHanh, string maTaiLieu, string nhaXuatBan, int soBanPhatHanh) : base(maTaiLieu, nhaXuatBan, soBanPhatHanh)
        {
            NgayPhatHanh = ngayPhatHanh;
        }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập ngày phát hành: ");
                NgayPhatHanh = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Ngày phát hành: {NgayPhatHanh}");
        }
    }
}
