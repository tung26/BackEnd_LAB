using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        while (true)
        {
            try
            {
                Console.Write("Nhập số phần tử trong mảng: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0) throw new Exception();
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập lại số phần tử mảng.");
            }
        }

        int[] a = new int[n];
        while (true)
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập giá trị phần tử {i}: ");
                    a[i] = int.Parse(Console.ReadLine());
                }
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập lại giá trị các phần tử mảng.");
            }
        }

        int s = 0;
        foreach (int i in a)
        {
            s += i;
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là {s}.");
    }
}