using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class HoDan
    {
        public string SoNha { get; set; }
        public int SoThanhVien { get; set; }
        public List<Nguoi> ThanhVien { get; set; }

        public HoDan() {
            ThanhVien = new List<Nguoi>();
        }
        public HoDan(string soNha, int soThanhVien, List<Nguoi> thanhVien)
        {
            if(SoThanhVien != thanhVien.Count)
            {
                Console.WriteLine("Không hợp lệ!!");
                return;
            }
            SoNha = soNha;
            SoThanhVien = soThanhVien;
            ThanhVien = thanhVien;
        }

        public void nhap()
        {
            try
            {
                Console.Write("Nhập số nhà: ");
                SoNha = Console.ReadLine();
                Console.Write("Nhập số thành viên: ");
                SoThanhVien = int.Parse(Console.ReadLine());
                for(int i = 0; i < SoThanhVien; i++)
                {
                    Console.WriteLine($"Nhập thành viên thứ {i}:");
                    Nguoi nguoi = new Nguoi();
                    nguoi.nhap();
                    ThanhVien.Add(nguoi);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void xuat()
        {
            Console.WriteLine($"Số nhà: {SoNha}");
            Console.WriteLine($"Số thành viên: {SoThanhVien}");
            foreach(Nguoi nguoi in ThanhVien)
            {
                nguoi.xuat();
            }
        }
    }
}
