using System.Text;
using Bai04;

internal class Program
{
    private static void Main(string[] args)
    {
		Console.InputEncoding = Encoding.UTF8;
		Console.OutputEncoding = Encoding.UTF8;
		int isoHoDan;
		try
		{
            Console.Write("Nhập số hộ dân: ");
			isoHoDan = int.Parse(Console.ReadLine());
		}
		catch (Exception)
		{
			throw;
		}

		List<HoDan> list = Enumerable.Repeat(new HoDan(), isoHoDan).ToList();
		Console.Clear();
		try {
			foreach(HoDan hoDan in list) {
				hoDan.nhap();
			}
		}
		catch {
			throw;
		}

		while(true) {
			try {
				Console.Clear();
				Console.WriteLine("+----------------------------+");
				Console.WriteLine("|1. Tìm hộ dân theo tên.     |");
				Console.WriteLine("|2. Tìm hộ dân theo số nhà.  |");
				Console.WriteLine("|3. Xem danh sách hộ dân.    |");
				Console.WriteLine("|0. Thoát.                   |");
				Console.WriteLine("+----------------------------+");
				int select;
				Console.Write("Nhập lựa chọn: ");
				select = int.Parse(Console.ReadLine());
				Console.Clear();
				if(select == 0) return;

				switch(select) {
					case 1: {
						string nameSearch;
						System.Console.Write("Nhập tên tìm kiếm: ");
						nameSearch = Console.ReadLine();
						bool isSearch = false;
						foreach(HoDan hoDan in list) {
							List<Nguoi> thanhVien = hoDan.ThanhVien;
							foreach(Nguoi nguoi in thanhVien) {
								if(nameSearch.Equals(nguoi.HoTen)) {
									isSearch = true;
									hoDan.xuat();
									break;
								}
							}
							if(isSearch) break;
						}
						
						if(!isSearch) {
							Console.Clear();
							Console.WriteLine("Không tìm thấy hộ dân.");
						}
						Console.WriteLine("Bấm nút bất kì để tiếp tục.");
						Console.ReadKey();
						break;
					}
					case 2: {
						string soNha;
						System.Console.Write("Nhập số nhà tìm kiếm: ");
						soNha = Console.ReadLine();
						bool isSearch = false;
						foreach(HoDan hoDan in list) {
							if(hoDan.SoNha.Equals(soNha)) {
								hoDan.xuat();
								isSearch = true;
								break;
							}
						}
						
						if(!isSearch) {
							Console.Clear();
							Console.WriteLine("Không tìm thấy hộ dân.");
						}
						Console.WriteLine("Bấm nút bất kì để tiếp tục.");
						Console.ReadKey();
						break;
					}
					case 3: {
						foreach(HoDan hoDan in list) {
							hoDan.xuat();
						}
						Console.WriteLine("Bấm nút bất kì để tiếp tục.");
						Console.ReadKey();
						break;
					}
				}
			}
			catch {
				throw;
			}
		}		
    }
}