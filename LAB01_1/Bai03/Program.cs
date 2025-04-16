using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        double c;
        while (true)
        {
            try
            {
                Console.Write("Nhập nhiệt độ (C): ");
                c = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Vui lòng nhập lại.");
            }
        }
        double f = (c * (9 / 5)) + 32;
        Console.WriteLine($"Nhiệt độ (F) là: {f}");
    }
}