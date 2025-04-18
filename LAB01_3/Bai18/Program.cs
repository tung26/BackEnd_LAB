using System.Text;
using System.Text.RegularExpressions;
using Bai18;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<CoQuan> coQuans = new List<CoQuan>();
        int select;
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+------------------------------------+");
                Console.WriteLine("|1. Thêm nhân viên.                  |");
                Console.WriteLine("|2. Các nhân viên phòng hành chính.  |");
                Console.WriteLine("|3. Tìm kiếm thông tin theo họ tên.  |");
                Console.WriteLine("|0. Thoát chương trình.              |");
                Console.WriteLine("+------------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();

                if (select == 0) return;

                switch(select)
                {
                    case 1:
                        {
                            CoQuan coQuan = new CoQuan();
                            Console.WriteLine("Nhập thông tin cho nhân viên: ");
                            coQuan.nhap();
                            coQuans.Add(coQuan);
                            Console.Clear();
                            Console.WriteLine("Đã thêm nhân viên vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Các nhân viên thuộc phòng hành chính: ");
                            foreach (CoQuan c in coQuans)
                            {
                                string donVI = c.DonVi.ToLower();
                                donVI = Regex.Replace(donVI, @"\s+", "");
                                if(donVI.Equals("hànhchính"))
                                {
                                    c.In();
                                }
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            string name;
                            Console.Write("Nhập tên muốn tìm kiếm: ");
                            name = Console.ReadLine();
                            name = name.ToLower();
                            name = Regex.Replace(name, @"\s+", "");
                            foreach (CoQuan c in coQuans)
                            {
                                string oName = c.getHoTen().ToLower();
                                oName = Regex.Replace(oName, @"\s+", "");
                                if (oName.Equals(name))
                                {
                                    c.In();
                                }
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