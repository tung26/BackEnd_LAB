using System.Text;
using Bai22;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<HocSinh> danhSach = new List<HocSinh>();

        Console.Write("Nhập số lượng học sinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập học sinh thứ {i + 1}:");
            HocSinh hs = new HocSinh();
            hs.Nhap();
            danhSach.Add(hs);
        }


        danhSach = danhSach.OrderByDescending(h => h.TongDiem).ThenBy(h => h.NamSinh).ToList();


        Console.WriteLine("\nDanh sách học sinh đã sắp xếp:");
        Console.WriteLine($"{"Họ tên",-25} | {"Năm sinh",-10} | {"Tổng điểm",-10}");
        Console.WriteLine(new string('-', 50));
        foreach (var hs in danhSach)
        {
            hs.Xuat();
        }

        Console.ReadKey();
    }
}