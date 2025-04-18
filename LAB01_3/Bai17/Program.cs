using System;
using System.Collections.Generic;
using System.Text;
using Bai17;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<HinhTron> ds = new List<HinhTron>();
        int select;
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("|1. Thêm hình tròn.                |");
                Console.WriteLine("|2. Xem hình tròn giao nhiều nhất. |");
                Console.WriteLine("|0. Thoát chương trình.            |");
                Console.WriteLine("+----------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();

                if (select == 0) return;

                switch(select)
                {
                    case 1:
                        {
                            int n;
                            Console.Write("Nhập số lượng hình thêm: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Clear();

                            double x, y, r;
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write("Nhập hoành độ tâm điểm: ");
                                x = double.Parse(Console.ReadLine());
                                Console.Write("Nhập tung độ tâm điểm: ");
                                y = double.Parse(Console.ReadLine());
                                Console.Write("Nhập độ dài bán kính: ");
                                r = double.Parse(Console.ReadLine());
                                Diem diem = new Diem(x, y);
                                HinhTron hinhTron = new HinhTron(diem, r);
                                ds.Add(hinhTron);
                                Console.Clear();
                            }

                            Console.WriteLine("Đã thêm vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            int maxGiao = -1;
                            HinhTron hinhMax = null;

                            foreach (var ht1 in ds)
                            {
                                int dem = 0;
                                foreach (var ht2 in ds)
                                {
                                    if (ht1 != ht2 && ht1.GiaoNhau(ht2))
                                        dem++;
                                }

                                if (dem > maxGiao)
                                {
                                    maxGiao = dem;
                                    hinhMax = ht1;
                                }
                            }

                            Console.WriteLine("Hình tròn giao với nhiều hình khác nhất: ");
                            hinhMax?.InThongTin();
                            Console.WriteLine($"Số lượng hình tròn giao nhau: {maxGiao}");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default: break;
                }
            }
            catch (Exception)
            {
                continue;
            }
        }
    }
}
