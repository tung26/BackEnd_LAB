using Bai11;

internal class Program
{
    private static void Main(string[] args)
    {
        SoPhuc A = new SoPhuc();
        SoPhuc B = new SoPhuc();

        Console.WriteLine("Nhập số phức A:");
        A.Nhap();

        Console.WriteLine("Nhập số phức B:");
        B.Nhap();

        Console.WriteLine("Chọn thao tác:");
        Console.WriteLine("a) Cộng hai số phức");
        Console.WriteLine("b) Trừ hai số phức");
        Console.WriteLine("c) Nhân hai số phức");
        Console.WriteLine("d) Chia hai số phức");
        Console.Write("Lựa chọn của bạn: ");
        string chon = Console.ReadLine();

        SoPhuc ketQua;

        switch (chon)
        {
            case "a":
                ketQua = A.Cong(B);
                Console.Write("Tổng = ");
                ketQua.HienThi();
                break;

            case "b":
                ketQua = A.Tru(B);
                Console.Write("Hiệu = ");
                ketQua.HienThi();
                break;

            case "c":
                ketQua = A.Nhan(B);
                Console.Write("Tích = ");
                ketQua.HienThi();
                break;

            case "d":
                ketQua = A.Chia(B);
                Console.Write("Thương = ");
                ketQua.HienThi();
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }
}