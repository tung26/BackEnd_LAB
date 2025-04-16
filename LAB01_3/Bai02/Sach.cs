using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang {  get; set; }

        public Sach() : base() { }

        public Sach(string tenTacGia, int soTrang, string maTaiLieu, string nhaXuatBan, int soBanPhatHanh) : base(maTaiLieu, nhaXuatBan, soBanPhatHanh)
        {
            TenTacGia = tenTacGia;
            SoTrang = soTrang;
        }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập tên tác giả: ");
                TenTacGia = Console.ReadLine();
                Console.Write("Nhập số trang: ");
                SoTrang = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Tác giả: {TenTacGia}");
            Console.WriteLine($"Số trang: {SoTrang}");
        }
    }
}
