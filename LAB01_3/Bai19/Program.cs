using System.Text;
using Bai19;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<ThiSinh> thiSinhs = new List<ThiSinh>();

        int select;
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+---------------------------------------------+");
                Console.WriteLine("|1. Thêm thí sinh.                            |");
                Console.WriteLine("|2. Thí sinh tổng điểm > 15.                  |");
                Console.WriteLine("|3. Sắp xếp thí sinh giảm dần theo tổng điểm. |");
                Console.WriteLine("+---------------------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();

                if (select == 0) return;

                switch(select)
                {
                    case 1:
                        {
                            int n;
                            Console.Write("Nhập số sinh viên muốn thêm: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Clear();

                            int i = 0;
                            while(i < n)
                            {
                                ThiSinh ts = new ThiSinh();
                                Console.WriteLine($"Nhập thông tin cho thí sinh {i + 1}:");
                                ts.nhap();
                                thiSinhs.Add(ts);
                                Console.Clear();
                                i++;
                            }
                            Console.WriteLine("Đã thêm vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            foreach(ThiSinh ts in thiSinhs)
                            {
                                if(ts.Diem.TongDiem() > 15.0)
                                {
                                    ts.xuat();
                                    Console.WriteLine("-----------------------------");
                                }
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            thiSinhs = (List<ThiSinh>)thiSinhs.OrderByDescending(h => h.Diem.TongDiem());
                            foreach (ThiSinh ts in thiSinhs)
                            {
                                ts.xuat();
                                Console.WriteLine("-------------------------------");
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default: continue;
                }
            }
            catch (Exception)
            {
                continue;
            }
        }
    }
}