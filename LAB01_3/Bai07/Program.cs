using System;
using System.Collections.Generic;
using System.Text;
using Bai07;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<CBGV> danhSach = new List<CBGV>();
        int chon;
        try
        {
            while (true) {
            Console.Clear();
            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("|1. Nhập cán bộ GV.                 |");
            Console.WriteLine("|2. Tìm theo quê quán.              |");
            Console.WriteLine("|3. Hiển thị GV có lương > 5 triệu. |");
            Console.WriteLine("|0. Thoát.                          |");
            Console.WriteLine("+-----------------------------------+");
            Console.Write("Nhập lựa chọn: ");
            chon = int.Parse(Console.ReadLine());
            Console.Clear();

            if (chon == 0) return;

            switch (chon)
            {
                case 1:
                    {
                        Console.Write("Số lượng GV: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Nhập GV thứ {i + 1}:");
                            CBGV gv = new CBGV();
                            gv.Nhap();
                            danhSach.Add(gv);
                        }
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;
                    } 
                case 2:
                    {
                        Console.Write("Nhập quê cần tìm: ");
                        string que = Console.ReadLine();
                        foreach (var gv in danhSach)
                        {
                            if (gv.QueQuan.ToLower().Contains(que.ToLower())) gv.Xuat();
                        }
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;
                    } 
                case 3:
                    {
                        foreach (var gv in danhSach)
                        {
                            if (gv.LuongThucLinh > 5000000) gv.Xuat();
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
