using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }

        public TapChi() { }

        public TapChi(int soPhatHanh, int thangPhatHanh, string maTaiLieu, string nhaXuatBan, int soBanPhatHanh) : base(maTaiLieu, nhaXuatBan, soBanPhatHanh)
        {
            SoPhatHanh = soPhatHanh;
            ThangPhatHanh = thangPhatHanh;
        }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập số phát hành: ");
                SoPhatHanh = int.Parse(Console.ReadLine());
                Console.Write("Nhập tháng phát hành: ");
                ThangPhatHanh= int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Số phát hành: {SoPhatHanh}");
            Console.WriteLine($"Tháng phát hành: {ThangPhatHanh}");
        }
    }
}
