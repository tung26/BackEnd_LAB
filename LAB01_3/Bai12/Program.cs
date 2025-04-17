using System.Collections.Specialized;
using System.Text;
using Bai12;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        MaTran A = new MaTran();
        MaTran B = new MaTran();

        int select;

        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+------------------------+");
                Console.WriteLine("|1. Nhập 2 ma trận.      |");
                Console.WriteLine("|2. Cộng hai ma trận.    |");
                Console.WriteLine("|3. Trừ hai ma trận.     |");
                Console.WriteLine("|4. Nhân hai ma trận.    |");
                Console.WriteLine("|5. Chia hai ma trận.    |");
                Console.WriteLine("|0. Thoát chương trình.  |");
                Console.WriteLine("+------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();

                if (select == 0) return;

                switch (select)
                {
                    case 1:
                        {
                            A.nhap();
                            B.nhap();
                            Console.WriteLine("Đã nhập 2 ma trận.");
                            Console.Write("bấm nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ma trận A: ");
                            A.xuat();
                            Console.WriteLine("Ma trận B: ");
                            B.xuat();
                            MaTran C = A.Cong(B);
                            Console.WriteLine("A + B:");
                            C.xuat();
                            Console.Write("bấm nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ma trận A: ");
                            A.xuat();
                            Console.WriteLine("Ma trận B: ");
                            B.xuat();
                            MaTran C = A.Tru(B);
                            Console.WriteLine("A - B:");
                            C.xuat();
                            Console.Write("bấm nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ma trận A: ");
                            A.xuat();
                            Console.WriteLine("Ma trận B: ");
                            B.xuat();
                            MaTran C = A.Nhan(B);
                            Console.WriteLine("A * B:");
                            C.xuat();
                            Console.Write("bấm nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Ma trận A: ");
                            A.xuat();
                            Console.WriteLine("Ma trận B: ");
                            B.xuat();
                            MaTran C = A.Chia(B);
                            Console.WriteLine("A / B:");
                            C.xuat();
                            Console.Write("bấm nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }
            catch (Exception)
            {
                continue;
            }
        }
    }
}