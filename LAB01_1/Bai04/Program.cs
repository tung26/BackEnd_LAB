using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int n;
        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên bất kì: ");
                n = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Vui lòng nhập lại.");
            }
        }
        if (n == 0) Console.WriteLine($"{n} không phải số chẵn hay số lẻ.");
        else if (n % 2 == 0) Console.WriteLine($"{n} là số chẵn.");
        else if (n % 2 != 0) Console.WriteLine($"{n} là số lẻ.");
    }
}