using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int y;
        while (true)
        {
            try
            {
                Console.Write("Nhập năm: ");
                y = int.Parse(Console.ReadLine());
                if (y <= 0) throw new Exception();
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập năm không hợp lệ.");
            }
        }

        if (y % 4  == 0)
        {
            Console.WriteLine($"{y} là năm nhuận.");
        }
        else if (y % 100 == 0 && y % 400 == 0)
        {
            Console.WriteLine($"{y} là năm nhuận.");
        }
        else
        {
            Console.WriteLine($"{y} không phải là năm nhuận.");
        }
    }
}