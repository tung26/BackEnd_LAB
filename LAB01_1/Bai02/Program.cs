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
                Console.Write("Nhập chiều dài hình chữ nhật: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Nhập chiều rộng hình chữ nhật: ");
                b = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập không đúng vui lòng nhập lại");
            }
        }
        double c = Math.Round((a * b), 2);

        Console.WriteLine($"Diện tích hình chữ nhật là: {c}");
    }
}