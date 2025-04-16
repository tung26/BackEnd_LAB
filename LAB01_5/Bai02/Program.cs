using System.Diagnostics.Metrics;
using System.Text;
using Bai02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Hinh> hinh = new List<Hinh>();

        int select;

        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("+-------------------------------------------+");
                Console.WriteLine("|1. Thêm hình tam giác.                     |");
                Console.WriteLine("|2. Thêm hình tròn.                         |");
                Console.WriteLine("|3. Thêm hình vuông .                       |");
                Console.WriteLine("|4. Thêm hình chữ nhật.                     |");
                Console.WriteLine("|5. Tổng chu vi và diện tích các hình.      |");
                Console.WriteLine("|0. Thoát chương trình.                     |");
                Console.WriteLine("+-------------------------------------------+");
                Console.Write("Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                Console.Clear();

                if (select == 0) return;

                switch(select)
                {
                    case 1:
                        {
                            double[] a = {0, 0, 0};
                            for(int i = 0; i < 3; i++)
                            {
                                Console.Write($"Nhập cạnh thứ {i + 1}: ");
                                a[i] = double.Parse(Console.ReadLine());
                            }
                            HinhTamGiac hinhTamGiac = new HinhTamGiac(a[0], a[1], a[2]);
                            hinh.Add(hinhTamGiac);

                            Console.Clear();
                            Console.WriteLine("Đã thêm hình vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            double r;
                            Console.Write("Nhập bán kình hình tròn: ");
                            r = double.Parse(Console.ReadLine());
                            Console.Clear();
                            HinhTron hinhTron = new HinhTron(r);
                            hinh.Add(hinhTron);

                            Console.Clear();
                            Console.WriteLine("Đã thêm hình vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            double a;
                            Console.Write("Nhập độ dài cạnh: ");
                            a = double.Parse(Console.ReadLine());
                            HinhVuong hinhVuong = new HinhVuong(a);
                            hinh.Add(hinhVuong);

                            Console.Clear();
                            Console.WriteLine("Đã thêm hình vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            double a, b;
                            Console.Write("Nhập chiều dài: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Nhập chiều rộng: ");
                            b = double.Parse(Console.ReadLine());
                            HinhChuNhat hinhChuNhat = new HinhChuNhat(a, b);
                            hinh.Add(hinhChuNhat);

                            Console.Clear();
                            Console.WriteLine("Đã thêm hình vào danh sách.");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();

                            break;
                        }
                    case 5:
                        {
                            double sumChuVi = 0, sumDienTich = 0;
                            foreach(Hinh h in hinh)
                            {
                                if(h is HinhChuNhat)
                                {
                                    HinhChuNhat H = (HinhChuNhat)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    sumChuVi += a;
                                    sumDienTich += b;
                                    Console.WriteLine($"Hình chữ nhật ({H.Dai} - {H.Rong}) - C: {a} - S: {b}.");
                                }
                                else if(h is HinhTamGiac)
                                {
                                    HinhTamGiac H = (HinhTamGiac)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    sumChuVi += a;
                                    sumDienTich += b;
                                    Console.WriteLine($"Hình tam giác ({H.A} - {H.B}) - {H.C} - C: {a} - S: {b}.");
                                }
                                else if(h is HinhTron)
                                {
                                    HinhTron H = (HinhTron)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    sumChuVi += a;
                                    sumDienTich += b;
                                    Console.WriteLine($"Hình tròn ({H.BanKinh}) - C: {a} - S: {b}.");
                                }
                                else if(h is HinhVuong)
                                {
                                    HinhVuong H = (HinhVuong)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    sumChuVi += a;
                                    sumDienTich += b;
                                    Console.WriteLine($"Hình vuông ({H.Canh}) - C: {a} - S: {b}.");
                                }
                            }
                            Console.WriteLine($"Tổng chu vi: {sumChuVi} - Tổng diện tích: {sumDienTich}.");

                            Console.Write("Nhấn nút bất kì để tiếp tục.");
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