using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class QLPTGT
    {
        private List<PTGT> danhSach = new List<PTGT>();

        public void NhapPhuongTien()
        {
            Console.Write("Chọn loại phương tiện (1. Ô tô | 2. Xe máy | 3. Xe tải): ");
            int loai = int.Parse(Console.ReadLine());
            PTGT pt;

            switch (loai)
            {
                case 1: pt = new OTo(); break;
                case 2: pt = new XeMay(); break;
                case 3: pt = new XeTai(); break;
                default: Console.WriteLine("Không hợp lệ."); return;
            }

            pt.Nhap();
            danhSach.Add(pt);
        }

        public void TimTheoMauHoacNamSX()
        {
            Console.Write("Tìm theo (1. Màu | 2. Năm sản xuất): ");
            int chon = int.Parse(Console.ReadLine());
            Console.Clear();
            if (chon == 1)
            {
                Console.Write("Nhập màu cần tìm: ");
                string mau = Console.ReadLine();
                var ketQua = danhSach.Where(p => p.Mau.ToLower() == mau.ToLower());

                foreach (var pt in ketQua)
                    pt.HienThi();
            }
            else if (chon == 2)
            {
                Console.Write("Nhập năm sản xuất: ");
                int nam = int.Parse(Console.ReadLine());
                var ketQua = danhSach.Where(p => p.NamSX == nam);

                foreach (var pt in ketQua)
                    pt.HienThi();
            }
        }

        public void HienThiTatCa()
        {
            foreach (var pt in danhSach)
            {
                pt.HienThi();
                Console.WriteLine("------------------");
            }
        }
    }
}
