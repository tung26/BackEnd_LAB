using System.Text;
using Bai10;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string s;

        VanBan vanBan = new VanBan();

        int select;
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+----------------------+");
                Console.WriteLine("|1. Nhập văn bản mới.  |");
                Console.WriteLine("|2. Đếm số kí tự h/H.  |");
                Console.WriteLine("|3. Đếm số từ.         |");
                Console.WriteLine("|4. Chuẩn hóa văn bản. |");
                Console.WriteLine("|0. Thoát chương trình.|");
                Console.WriteLine("+----------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());

                if (select == 0) return;

                Console.Clear();

                if (select > 1 && select <= 4)
                {
                    Console.WriteLine(vanBan.VBan);
                }

                switch (select)
                {
                    case 1:
                        {
                            Console.Write("Nhập văn bản mới: ");
                            s = Console.ReadLine();
                            vanBan.VBan = s;

                            Console.WriteLine("Đã sửa thành văn bản mới.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Số kí tự h/H: {vanBan.countHWord()}");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Số từ: {vanBan.countWord()}");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Văn bản chuẩn hóa: {vanBan.chuanHoaVBan()}");
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