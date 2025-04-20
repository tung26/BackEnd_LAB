using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class DaGiaDinh : HoiVien
    {
        public string TenNY {  get; set; }
        public DateTime NgayCuoi { get; set; }

        public DaGiaDinh() { }
        public DaGiaDinh(string tenNY, DateTime ngayCuoi, string hoTen, string diaChi) : base(hoTen, diaChi)
        {
            TenNY = tenNY;
            NgayCuoi = ngayCuoi;
        }

        public override void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập tên vợ: ");
                TenNY = Console.ReadLine();
                Console.Write("Nhập ngày cưới: ");
                NgayCuoi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Tên vợ: {TenNY}");
            Console.WriteLine($"Ngày cưới: {NgayCuoi:dd/MM/yyyy}");
        }
    }
}
