using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class BienLai : KhachHang
    {
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }

        public void NhapBienLai()
        {
            base.Nhap();
            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = int.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
        }

        public int SoDien()
        {
            return ChiSoMoi - ChiSoCu;
        }

        public int TinhTienDien()
        {
            int soDien = SoDien();
            if (soDien < 50)
                return soDien * 1250;
            else if (soDien < 100)
                return soDien * 1500;
            else
                return soDien * 2000;
        }

        public void HienThiBienLai()
        {
            base.HienThi();
            Console.WriteLine($"\tChỉ số cũ: {ChiSoCu} - Chỉ số mới: {ChiSoMoi} - Số điện: {SoDien()}.");
        }
    }

}
