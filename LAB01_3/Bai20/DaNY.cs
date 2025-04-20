using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class DaNY : HoiVien
    {
        public string TenNy {  get; set; }
        public int SDTNY { get; set; }

        public DaNY() { }
        public DaNY(string tenNy, int sDTNY, string hoTen, string diaChi) : base(hoTen, diaChi)
        {
            TenNy = tenNy;
            SDTNY = sDTNY;
        }

        public override void nhap()
        {
            base.nhap();
            try
            {
                Console.Write("Nhập tên người yêu: ");
                TenNy = Console.ReadLine();
                Console.Write("Nhập số điện thoại người yêu: ");
                SDTNY = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Tên người yêu: {TenNy}");
            Console.WriteLine($"Số điện thoại người yêu: {SDTNY}");
        }
    }
}
