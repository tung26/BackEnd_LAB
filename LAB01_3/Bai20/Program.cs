using System.Security.Cryptography.X509Certificates;
using System.Text;
using Bai20;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<HoiVien> hoiViens = new List<HoiVien>();

        int select;

        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("|1. Thêm hội viên.                 |");
                Console.WriteLine("|2. Hội viên cưới ngày 11/11/2011. |");
                Console.WriteLine("|3. Hội viên có người yêu.         |");
                Console.WriteLine("+----------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();

                if (select == 0) return;

                switch (select)
                {
                    case 1:
                        {
                            int n;
                            Console.Write("Nhập số thành viên thêm: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Clear();
                            int l;
                            int i = 0;
                            while (i < n)
                            {
                                Console.Write($"Kiểu hội viên thứ {i}: (1:NY - 2:GD - 3:Ế): ");
                                l = int.Parse(Console.ReadLine());
                                HoiVien hv;
                                switch (l)
                                {
                                    case 1: hv = new DaNY(); break;
                                    case 2: hv = new DaGiaDinh(); break;
                                    case 3: hv = new HoiVien(); break;
                                    default: continue;
                                }
                                i++;
                                hv.nhap();
                                hoiViens.Add(hv);
                                Console.Clear();
                            }

                            Console.WriteLine("Đã thêm các hội viên vào danh sách.");
                            Console.Write("Nhấn nút bât kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Các hội viên cưới ngày 11/11/2011:");
                            foreach(HoiVien hv  in hoiViens)
                            {
                                if(hv is DaGiaDinh gd && gd.NgayCuoi == new DateTime(2011, 11, 11))
                                {
                                    gd.xuat();
                                    Console.WriteLine("--------------------------------------");
                                }
                            }
                            Console.Write("Nhấn nút bât kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n--- Hội viên có người yêu nhưng chưa lập gia đình ---");
                            foreach (var hv in hoiViens)
                            {
                                if (hv is DaNY ny)
                                {
                                    ny.xuat();
                                    Console.WriteLine("--------------------------------------");
                                }

                            }
                            Console.Write("Nhấn nút bât kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default: continue;
                }
            }
            catch (Exception)
            {
                continue;
            }
        }
    }
}