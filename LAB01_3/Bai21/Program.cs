using System.Text;
using Bai21;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<HocSinh> hocSinhs = new List<HocSinh>();

        int select;
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+-----------------------------------------+");
                Console.WriteLine("|1. Thêm học sinh.                        |");
                Console.WriteLine("|2. Các học sinh nam điểm kic thuật >= 8. |");
                Console.WriteLine("|3. Danh sách học sinh Nam -> Nữ.         |");
                Console.WriteLine("+-----------------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());

                Console.Clear();
                if (select == 0) return;

                switch(select)
                {
                    case 1:
                        {
                            int n;
                            Console.Write("Nhập số học sinh muốn thêm: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Clear();
                            int i = 0;
                            while (i < n)
                            {
                                int s;
                                Console.WriteLine($"Nhập thông tin học sinh {i + 1} (1:Nam - 2:Nữ):");
                                s = int.Parse(Console.ReadLine());
                                HocSinh h;
                                switch(s)
                                {
                                    case 1: h = new Nam(); break;
                                    case 2: h = new Nu(); break;
                                    default: continue;
                                }
                                h.nhap();
                                i++;
                                hocSinhs.Add(h);
                                Console.Clear();
                            }
                            Console.WriteLine("Đã thêm vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            foreach(HocSinh h in hocSinhs)
                            {
                                if(h is Nam hsN && hsN.KiThuat >= 8)
                                {
                                    hsN.xuat();
                                    Console.WriteLine("-------------------------");
                                }
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Danh sách sinh viên Nam -> Nữ:");
                            foreach (HocSinh h in hocSinhs)
                            {
                                if (h is Nam hsN)
                                {
                                    hsN.xuat();
                                    Console.WriteLine("-------------------------");
                                }
                            }
                            foreach (HocSinh h in hocSinhs)
                            {
                                if (h is Nu hsN)
                                {
                                    hsN.xuat();
                                    Console.WriteLine("-------------------------");
                                }
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