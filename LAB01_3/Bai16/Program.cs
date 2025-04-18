using System.Text;
using Bai16;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            try
            {
                Console.Write("Nhập số lượng tam giác: ");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                List<TamGiac> danhSachTG = new List<TamGiac>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhập tam giác thứ {i + 1} ---");
                    TamGiac tg = new TamGiac();
                    tg.Nhap();
                    danhSachTG.Add(tg);
                    Console.Clear();
                }

                double tongChuVi = 0;
                double tongDienTich = 0;

                Console.WriteLine("\n--- Thông tin các tam giác ---");
                foreach (TamGiac tg in danhSachTG)
                {
                    tg.Xuat();
                    double chuVi = tg.TinhChuVi();
                    double dienTich = tg.TinhDienTich();
                    Console.WriteLine($"-> Chu vi: {chuVi:F2}, Diện tích: {dienTich:F2}\n");
                    tongChuVi += chuVi;
                    tongDienTich += dienTich;
                }

                Console.WriteLine($"==> Tổng chu vi: {tongChuVi:F2}.");
                Console.WriteLine($"==> Tổng diện tích: {tongDienTich:F2}.");
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