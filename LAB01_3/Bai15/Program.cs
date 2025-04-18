using System.Text;
using Bai15;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true) {
			try
			{
                Console.Write("Nhập số lượng tam giác: ");
                int n = int.Parse(Console.ReadLine());
                List<TamGiac> dsTG = new List<TamGiac>();
                Console.Clear();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhập tam giác thứ {i + 1} ---");
                    TamGiac tg = new TamGiac();
                    tg.Nhap();
                    dsTG.Add(tg);
                    Console.Clear();
                }

                Console.WriteLine("\n--- Các tam giác thỏa mãn định lý Pythagoras ---");
                foreach (TamGiac tg in dsTG)
                {
                    if (tg.LaTamGiacVuong())
                    {
                        tg.InCanh();
                    }
                }

                break;
            }
			catch (Exception)
			{
                Console.Clear();
                continue;
			}
        }
    }
}