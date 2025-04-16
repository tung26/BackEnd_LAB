using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine($"Bảng nhân {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"\t{i} * {j} = {i * j}");
            }
        }
    }
}