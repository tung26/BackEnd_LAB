using Bai01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while(true)
        {
            try
            {
                Console.Write("Nhập số lượng phân số: ");
                int n = int.Parse(Console.ReadLine());

                List<PhanSo> danhSach = new List<PhanSo>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhập phân số thứ {i + 1}:");
                    PhanSo ps = new PhanSo();
                    ps.Nhap();
                    danhSach.Add(ps);
                }

                PhanSo tong = new PhanSo(0, 1);
                foreach (PhanSo ps in danhSach)
                {
                    tong = PhanSo.Cong(tong, ps);
                }

                Console.WriteLine("\nTổng các phân số là:");
                tong.HienThi();

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