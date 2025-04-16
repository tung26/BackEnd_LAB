using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int a;
        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên dương: ");
                a = int.Parse(Console.ReadLine());

                if (a <= 0) throw new Exception();
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập lại.");
            }
        }

        int P = 1;
        for (int i = a; i > 0; i--)
        {
            P *= i;
        }
        Console.WriteLine($"{a}! = {P}");
    }
}