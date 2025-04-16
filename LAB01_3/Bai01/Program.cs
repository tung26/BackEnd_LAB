using System.Collections;
using System.Text;
using Bai01;

internal class Program
{
    public static void searchName(List<CanBo> l, string name)
    {
        foreach (CanBo c in l)
        {
            if (c.HoTen.Equals(name))
            {
                Console.WriteLine("--------------------");
                c.xuat();
            }
        }
        Console.WriteLine("--------------------");
    }

    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<CanBo> canBoList = new List<CanBo> ();
        int select;
        while (true)
        {
            try
            {
                Console.WriteLine("+------- QUẢN LÝ CÁN BỘ -------+");
                Console.WriteLine("|0. Thoát chương trình.        |");
                Console.WriteLine("|1. Thêm nhân viên.            |");
                Console.WriteLine("|2. Thêm kỹ sư.                |");
                Console.WriteLine("|3. Thêm công nhân.            |");
                Console.WriteLine("|4. Xem danh sách cán bộ.      |");
                Console.WriteLine("|5. Tìm kiếm cán bộ theo tên.  |");
                Console.WriteLine("+------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();
                if (select == 0) break;
                switch (select)
                {
                    case 1:
                        {
                            NhanVien nhanVien = new NhanVien();
                            Console.WriteLine("Nhập thông tin cho nhân viên mới: ");
                            nhanVien.nhap();
                            canBoList.Add(nhanVien);
                            Console.WriteLine("Đã thêm nhân viên vào danh sách.");
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            KySu kySu = new KySu();
                            Console.WriteLine("Nhập thông tin cho kỹ sư mới: ");
                            kySu.nhap();
                            canBoList.Add(kySu);
                            Console.WriteLine("Đã thêm kỹ sư vào danh sách.");
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            CongNhan congNhan = new CongNhan();
                            Console.WriteLine("Nhập thông tin cho công nhân mới: ");
                            congNhan.nhap();
                            canBoList.Add(congNhan);
                            Console.WriteLine("Đã thêm công nhân vào danh sách.");
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            foreach(var cb in canBoList)
                            {
                                Console.WriteLine("-----------------------------");
                                if (cb is NhanVien)
                                {
                                    NhanVien nhanVien = (NhanVien) cb;
                                    nhanVien.xuat();
                                }
                                else if (cb is CongNhan)
                                {
                                    CongNhan congNhan = (CongNhan) cb;
                                    congNhan.xuat();
                                }
                                else if (cb is KySu)
                                {
                                    KySu kySu = (KySu) cb;
                                    kySu.xuat();
                                }
                                    Console.WriteLine("-----------------------------");
                            }
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            string name;
                            Console.Write("Nhập tên muốn tìm kiếm: ");
                            name = Console.ReadLine();
                            searchName(canBoList, name);
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default: break;
                }

                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Nhập không hợp lệ vui lòng nhập lại.");
            }
        }
    }
}