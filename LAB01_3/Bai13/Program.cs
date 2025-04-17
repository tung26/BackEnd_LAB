using System.Text;
using Bai13;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        QLPTGT ql = new QLPTGT();
        int chon = 1;

        while (chon != 0) {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|1. Nhập đăng ký phương tiện.             |");
            Console.WriteLine("|2. Tìm phương tiện theo màu hoặc năm SX. |");
            Console.WriteLine("|3. Hiển thị tất cả phương tiện.          |");
            Console.WriteLine("|0. Thoát.                                |");
            Console.WriteLine("+-----------------------------------------+");
            Console.Write("Chọn: ");
            chon = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (chon)
            {
                case 1:
                    {
                        ql.NhapPhuongTien();
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        ql.TimTheoMauHoacNamSX();
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        ql.HienThiTatCa();
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;
                    }
                default: continue;
            }

        } ;
    }
}