using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    internal class TheMuon : SinhVien
    {
        public string SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string SoHieuSach { get; set; }

        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("Số phiếu mượn: ");
                SoPhieuMuon = Console.ReadLine();
                Console.Write("Ngày mượn (dd/MM/yyyy): ");
                NgayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Hạn trả (dd/MM/yyyy): ");
                HanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Số hiệu sách: ");
                SoHieuSach = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số phiếu: {SoPhieuMuon} - Ngày mượn: {NgayMuon:dd/MM/yyyy} - Hạn trả: {HanTra:dd/MM/yyyy} - Số hiệu sách: {SoHieuSach}.");
        }
    }

}
