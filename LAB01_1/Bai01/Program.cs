using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string name;
        int age;
        while (true)
        {
            try
            {
                Console.Write("Nhập tên: ");
                name = Console.ReadLine();
                Console.Write("Nhập tuổi: ");
                age = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập không đúng vui lòng nhập lại.");
            }
        }

        Console.WriteLine($"Xin chào {name}, bạn {age} tuổi");
    }
}