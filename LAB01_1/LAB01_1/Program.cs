using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int x1, x2, y1, y2;

        Console.WriteLine("Nhập tọa độ điểm A(x1, y1): ");
        Console.Write("Nhập x1: ");
        x1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập y1: ");
        y1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập tọa độ điểm A(x2, y2): ");
        Console.Write("Nhập x2: ");
        x2 = int.Parse(Console.ReadLine());
        Console.Write("Nhập y2: ");
        y2 = int.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine($"Khoảng cách 2 điểm là: {d}");
    }
}