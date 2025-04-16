using System.Text;
using Bai03;

internal class Program
{
    public static double caculPoint(double a, double b, double c)
    {
        return (a + b + c) / 3.0;
    }

    public static void DSStudentPass(List<ThiSinh> l)
    {
        foreach(ThiSinh s in l)
        {
            if(s is A)
            {
                A nA = (A)s;
                if(caculPoint(nA.Toan, nA.Ly, nA.Hoa) + nA.UuTien >= 7.5)
                {
                    Console.WriteLine($"Mã sinh viên: {nA.SBD}");
                }
            }
            else if(s is B)
            {
                B nB = (B)s;
                if(caculPoint(nB.Toan, nB.Sinh, nB.Hoa) + nB.UuTien >= 7.5)
                {
                    Console.WriteLine($"Mã sinh viên: {nB.SBD}");
                }
            }
            else if (s is C)
            {
                 C nC = (C)s;
                if (caculPoint(nC.Van, nC.Su, nC.Dia) + nC.UuTien >= 8.5)
                {
                    Console.WriteLine($"Mã sinh viên: {nC.SBD}");
                }
            }
        }
    }

    public static void searchBySBD(int SBD, List<ThiSinh> l)
    {
        foreach (ThiSinh s in l)
        {
            if(s.SBD == SBD)
            {
                if (s is A)
                {
                    A nA = (A)s;
                    nA.xuat();
                }
                else if (s is B)
                {
                    B nB = (B)s;
                    nB.xuat();
                }
                else if (s is C)
                {
                    C nC = (C)s;
                    nC.xuat();
                }
                break;
            }
        }
    }

    private static void Main(string[] args)
    {
        List<ThiSinh> lThiSinh = new List<ThiSinh>();

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("|1. Thêm thí sinh khối A.                |");
                Console.WriteLine("|2. Thêm thí sinh khối B.                |");
                Console.WriteLine("|3. Thêm thí sinh khối C.                |");
                Console.WriteLine("|4. Danh sách thông tin trúng tuyển.     |");
                Console.WriteLine("|5. Tìm kiếm thí sinh theo số báo danh.  |");
                Console.WriteLine("|0. Thoát chương trình                   |");
                Console.WriteLine("+----------------------------------------+");
                int select;
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(select)
                {
                    case 0: return;
                    case 1:
                        {
                            A a = new A();
                            a.nhap();
                            lThiSinh.Add(a);
                            Console.Clear();
                            Console.WriteLine("Đã thêm thí sinh khối A vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            B b = new B();
                            b.nhap();
                            lThiSinh.Add(b);
                            Console.Clear();
                            Console.WriteLine("Đã thêm thí sinh khối B vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            C c = new C();
                            c.nhap();
                            lThiSinh.Add(c);
                            Console.Clear();
                            Console.WriteLine("Đã thêm thí sinh khối C vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            DSStudentPass(lThiSinh);
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Nhập số báo danh: ");
                            int SBD = int.Parse(Console.ReadLine());
                            Console.Clear();
                            searchBySBD(SBD, lThiSinh);
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}