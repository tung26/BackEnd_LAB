using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class CoQuan : Nguoi
    {
        public string DonVi { get; set; }
        public double HeSoLuong { get; set; }
        public const double LuongCoBan = 1050000;

        public CoQuan() { }
        public CoQuan(string donVi, double heSoLuong, string hoTen, bool gioiTinh, int tuoi) : base(hoTen, gioiTinh, tuoi)
        {
            DonVi = donVi;
            HeSoLuong = heSoLuong;
        }

        public override void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập đơn vị: ");
                DonVi = Console.ReadLine();
                Console.Write("Nhập hệ số lương: ");
                HeSoLuong = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double TinhLuong()
        {
            return HeSoLuong * LuongCoBan;
        }
        public override void In()
        {
            base.In();
            Console.WriteLine($"Đơn vị: {DonVi}");
            Console.WriteLine($"Hệ số lương: {HeSoLuong}");
            Console.WriteLine($"Lương: {TinhLuong():N0} VNĐ");
        }
    }
}
