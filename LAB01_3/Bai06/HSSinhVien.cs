using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class HSSinhVien : Nguoi
    {
        public string Lop { get; set; }
        public string KhoaHoc { get; set; }
        public string KyHoc { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập lớp: ");
            Lop = Console.ReadLine();
            Console.Write("Nhập khoá học: ");
            KhoaHoc = Console.ReadLine();
            Console.Write("Nhập kỳ học: ");
            KyHoc = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Lớp: {Lop} - Khoá học: {KhoaHoc} - Kỳ học: {KyHoc}");
        }
    }
}
