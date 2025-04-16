using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;

        while (true)
        {
            Console.Write("Nhập số: ");
            n = int.Parse(Console.ReadLine());
            break;
        }

        if (n <= 0)
        {
            Console.WriteLine($"{n} không phải số nguyên tố.");
        }
        else if (n == 1 || n == 2)
        {
            Console.WriteLine($"{n} là số nguyên tố.");
        }
        else
        {
            bool isP = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isP = false;
                    break;
                }
            }

            if (isP)
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không phải số nguyên tố.");
            }
        }
    }
}