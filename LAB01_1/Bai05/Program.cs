using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        double a, b;
        while (true)
        {
            try
            {
                Console.Write("Nhập số a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Nhập số b: ");
                b = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Vui lòng nhập lại.");
            }
        }

        double s = a + b, m = a * b;
        Console.WriteLine($"Tổng hai số là {s}");
        Console.WriteLine($"Tích hai số là {m}");
    }
}