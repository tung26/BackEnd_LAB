using System.Text;
using Bai08;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<TheMuon> danhSach = new List<TheMuon>();
        int chon;

        while (true) {
            try
            {

                Console.Clear();
                Console.WriteLine("+-----------------------------------------+");
                Console.WriteLine("|1. Nhập danh sách sinh viên mượn sách.   |");
                Console.WriteLine("|2. Tìm sinh viên theo mã SV.             |");
                Console.WriteLine("|3. Hiển thị sinh viên đến hạn trả sách.  |");
                Console.WriteLine("|0. Thoát.                                |");
                Console.WriteLine("+-----------------------------------------+");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());
                Console.Clear();

                if (chon == 0) return;

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập số sinh viên: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhập SV thứ {i + 1}:");
                            TheMuon tm = new TheMuon();
                            tm.Nhap();
                            danhSach.Add(tm);
                        }
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Nhập mã SV cần tìm: ");
                        string ma = Console.ReadLine();
                        foreach (var sv in danhSach)
                        {
                            if (sv.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase)) sv.Xuat();
                        }
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;

                    case 3:
                        DateTime now = DateTime.Now;
                        Console.WriteLine($"Các sinh viên đến hạn trả (trước {now:dd/MM/yyyy}):");
                        foreach (var sv in danhSach)
                        {
                            if (sv.HanTra <= now) sv.Xuat();
                        }
                        Console.Write("Nhấn nút bất kì để tiếp tục.");
                        Console.ReadKey();
                        break;
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