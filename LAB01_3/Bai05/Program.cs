using System.Text;
using Bai05;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<Phong> phongList = new List<Phong>();

        while (true)
        {
			try
			{
                Console.Clear();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("|1. Thêm khách hàng.               |");
                Console.WriteLine("|2. Thông tin các khách hàng thuê. |");
                Console.WriteLine("|3. Tìm kiếm khách theo họ tên.    |");
                Console.WriteLine("|4. Tính tiền cho khách hàng.      |");
                Console.WriteLine("|0. Thoát chương trình.            |");
                Console.WriteLine("+----------------------------------+");
                int select;
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();
                if (select == 0) return;
                switch(select)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhập khách hàng mới: ");
                            Nguoi nguoi = new Nguoi();
                            nguoi.nhap();

                            Phong phong = new Phong();
                            Console.WriteLine("Nhập phòng cho khách hàng: ");
                            phong.nhap(nguoi);

                            phongList.Add(phong);

                            Console.Clear();
                            Console.WriteLine("Đã thêm khách hàng.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Thông tin các khách hàng thuê: ");
                            foreach (Phong phong in phongList)
                            {
                                phong.Nguoi.xuat();
                            }

                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhập tên khách hàng tìm kiếm: ");
                            string name;
                            name = Console.ReadLine();
                            Console.Clear();
                            bool isSearch = false;
                            foreach (Phong phong in phongList)
                            {
                                if(phong.Nguoi.HoTen.Equals(name))
                                {
                                    isSearch = true;
                                    phong.Nguoi.xuat();
                                    break;
                                }
                            }

                            if(!isSearch)
                            {
                                Console.WriteLine("Không tìm thấy.");
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Thông tin tiền trọ các khách hàng: ");
                            foreach (Phong phong in phongList)
                            {
                                phong.Nguoi.xuat();
                                Console.WriteLine("Giá: " + phong.GiaPhong * phong.SoNgayTro);
                                Console.WriteLine("------------------");
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