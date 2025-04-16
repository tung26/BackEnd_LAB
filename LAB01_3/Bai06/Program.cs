using System;
using System.Collections.Generic;
using System.Text;
using Bai06;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<HSSinhVien> danhSach = new List<HSSinhVien>();
        int luaChon;

		try
		{
            while (true)
            {
                Console.Clear();
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("|1. Nhập danh sách học sinh.             |");
                Console.WriteLine("|2. Hiển thị học sinh nữ sinh năm 1985.  |");
                Console.WriteLine("|3. Tìm kiếm học sinh theo quê quán.     |");
                Console.WriteLine("|0. Thoát.                               |");
                Console.WriteLine("+----------------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                luaChon = int.Parse(Console.ReadLine());
                Console.Clear();

                if (luaChon == 0) return;

                switch (luaChon)
                {
                    case 1:
                        {
                            Console.Write("Nhập số học sinh: ");
                            int n = int.Parse(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine($"Nhập học sinh thứ {i + 1}:");
                                HSSinhVien hs = new HSSinhVien();
                                hs.Nhap();
                                danhSach.Add(hs);
                            }
                            Console.Clear();
                            Console.WriteLine("Đã thêm học sinh vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        } 
                    case 2:
                        {
                            Console.WriteLine("--- Học sinh nữ sinh năm 1985 ---");
                            foreach (var hs in danhSach)
                            {
                                if (hs.GioiTinh.ToLower().Equals("nữ") && hs.NamSinh == 1985)
                                {
                                    hs.Xuat();
                                }
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        } 
                    case 3:
                        {
                            Console.Write("Nhập quê quán cần tìm: ");
                            string que = Console.ReadLine().ToLower();
                            Console.WriteLine($"--- Học sinh quê {que} ---");
                            foreach (var hs in danhSach)
                            {
                                if (hs.QueQuan.ToLower().Contains(que))
                                {
                                    hs.Xuat();
                                }
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        } 
                    default: break;
                }
            }
        }
		catch (Exception)
		{

			throw;
		}
    }
}
