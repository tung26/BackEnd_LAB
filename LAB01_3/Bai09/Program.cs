using System.Text;
using Bai09;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<BienLai> list = new List<BienLai>();

        int select;
		while (true)
        {
			try
			{
				Console.Clear();
                Console.WriteLine("+-------------------------------------+");
                Console.WriteLine("|1. Thêm biên lai cho hộ gia đình.    |");
                Console.WriteLine("|2. Hiển thị thông tin các biên lai.  |");
                Console.WriteLine("|3. Xem thông tin tiền điện.          |");
                Console.WriteLine("|0. Thoát chương trình.               |");
                Console.WriteLine("+-------------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();
                if (select == 0) return;

                switch(select)
                {
                    case 1:
                        {
                            int sl;
                            Console.Write("Nhập số biên lai muốn thêm: ");
                            sl = int.Parse(Console.ReadLine());

                            for (int i = 0; i < sl; i++)
                            {
                                Console.Clear();
                                Console.WriteLine($"Nhập biên lai thứ {i + 1}:");
                                BienLai bienLai = new BienLai();
                                bienLai.NhapBienLai();
                                list.Add(bienLai);
                            }

                            Console.WriteLine("Đã thêm vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Thông tin các biên lai:");
                            foreach(BienLai b in list)
                            {
                                b.HienThiBienLai();
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Thông tin tiền điện các biên lai:");
                            foreach (BienLai b in list)
                            {
                                b.HienThiBienLai();
                                Console.WriteLine("\tTiền điện: " + b.TinhTienDien());
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    default: break;
                }
            }
			catch (Exception)
			{
				continue;
			}
        }
    }
}