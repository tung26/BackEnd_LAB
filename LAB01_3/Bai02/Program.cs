using System.Collections;
using System.Text;
using Bai02;

internal class Program
{
    public static void xemDanhSach(List<TaiLieu> L)
    {
        foreach (TaiLieu l in L)
        {
            Console.WriteLine("------------------------");
            if (l is Bao)
            {
                Bao bao = (Bao)l;
                bao.xuat();
            }
            else if (l is Sach)
            {
                Sach bao = (Sach)l;
                bao.xuat();
            }
            else if (l is TapChi)
            {
                TapChi bao = (TapChi)l;
                bao.xuat();
            }
            Console.WriteLine("------------------------");
        }
    }

    public static void searchLoai(int t, List<TaiLieu> L)
    {
        foreach (TaiLieu l in L)
        {
            Console.WriteLine("------------------------");
            if (l is Bao && t == 3)
            {
                Bao bao = (Bao)l;
                bao.xuat();
            }
            else if (l is Sach && t == 2)
            {
                Sach bao = (Sach)l;
                bao.xuat();
            }
            else if (l is TapChi && t == 1)
            {
                TapChi bao = (TapChi)l;
                bao.xuat();
            }
            Console.WriteLine("------------------------");
        }
    }

    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<TaiLieu> taiLieu = new List<TaiLieu>();

        int select;
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|0. Thoát chương trình.          |");
                Console.WriteLine("|1. Thêm sách mới.               |");
                Console.WriteLine("|2. Thêm tạp chí mới.            |");
                Console.WriteLine("|3. Thêm báo mới.                |");
                Console.WriteLine("|4. Xem thông tin các tài liệu.  |");
                Console.WriteLine("|5. Tìm kiếm tài liệu theo loại. |");
                Console.WriteLine("+--------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();
                if (select == 0) break;

                switch(select)
                {
                    case 1:
                        {
                            Sach sach = new Sach();
                            sach.nhap();
                            taiLieu.Add(sach);
                            Console.Clear();
                            Console.WriteLine("Đã thêm sách vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            TapChi tapChi = new TapChi();
                            tapChi.nhap();
                            taiLieu.Add(tapChi);
                            Console.Clear();
                            Console.WriteLine("Đã thêm tạp chí vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Bao bao = new Bao();
                            bao.nhap();
                            taiLieu.Add(bao);
                            Console.Clear();
                            Console.WriteLine("Đã thêm báo vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            xemDanhSach(taiLieu);
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            while (true)
                            {
                                Console.WriteLine("+----------------------+");
                                Console.WriteLine("|1. Tìm theo tạp chí.  |");
                                Console.WriteLine("|2. Tìm theo sách.     |");
                                Console.WriteLine("|3. Tìm theo báo.      |");
                                Console.WriteLine("+----------------------+");
                                Console.Write("Nhập lựa chọn: ");
                                select = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if(select > 0 && select < 4)
                                {
                                    searchLoai(select, taiLieu);
                                    break;
                                }
                            }
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}