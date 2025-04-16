using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        double n;
        while (true)
        {
            try
            {
                Console.Write("Nhập số bất kì: ");
                n = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Vui lòng nhập lại.");
            }
        }
        if (n == 0) Console.WriteLine($"{n} là số 0.");
        else if (n > 0) Console.WriteLine($"{n} là số dương.");
        else if (n < 0) Console.WriteLine($"{n} là số âm.");
    }
}