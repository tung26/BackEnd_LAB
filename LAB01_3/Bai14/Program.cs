using System.Text;
using Bai14;

internal class Program
{

    public static void nhap(PhanSo a)
    {
        while (true)
        {
            try
            {
                a.nhap();
                if (a.MauSo == 0) throw new Exception();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Vui lòng nhập lại.");
            }
            finally
            {
                Console.Clear();
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        PhanSo a = new PhanSo();
        PhanSo b = new PhanSo();
        PhanSo c = new PhanSo();

        int select;
        while (true)
        {
            try
            {
                Console.WriteLine("+-------------------------------+");
                Console.WriteLine("|0. Thoát.                      |");
                Console.WriteLine("|1. Cộng hai phân số.           |");
                Console.WriteLine("|2. Trừ hai phân số.            |");
                Console.WriteLine("|3. Nhân hai phân số.           |");
                Console.WriteLine("|4. Chia hai phân số.           |");
                Console.WriteLine("|5. Tối giản phân số.           |");
                Console.WriteLine("|6. Kiểm tra tối giản phân số.  |");
                Console.WriteLine("+-------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();
                if (select == 0) break;
                switch (select)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhập phân số a: ");
                            nhap(a);
                            Console.WriteLine("Nhập phân số b: ");
                            nhap(b);
                            c = a + b;
                            c.xuat();
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhập phân số a: ");
                            nhap(a);
                            Console.WriteLine("Nhập phân số b: ");
                            nhap(b);
                            c = a - b;
                            c.xuat();
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nhập phân số a: ");
                            nhap(a);
                            Console.WriteLine("Nhập phân số b: ");
                            nhap(b);
                            c = a * b;
                            c.xuat();
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Nhập phân số a: ");
                            nhap(a);
                            Console.WriteLine("Nhập phân số b: ");
                            nhap(b);
                            c = a / b;
                            c.xuat();
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Nhập phân số a: ");
                            nhap(a);
                            Console.WriteLine($"Phân số sau khi tối giản: ");
                            a.toiGian();
                            a.xuat();
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Nhập phân số a: ");
                            nhap(a);
                            bool isToiGian = a.checkToiGian();
                            if (isToiGian)
                            {
                                Console.WriteLine("Phân số đã tối giản.");
                            }
                            else
                            {
                                Console.WriteLine("Phân số chưa tối giản.");
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Nhập không hợp lệ vui lòng nhập lại.");
            }
        }
    }
}