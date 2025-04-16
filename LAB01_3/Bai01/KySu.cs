using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class KySu : CanBo
    {
        public string Nganh {  get; set; }

        public KySu() { }
        
        public KySu(string Nganh, string hoTen, byte gioiTinh, int namSinh, string diaChi) : base(hoTen, gioiTinh, namSinh, diaChi)
        {
            this.Nganh = Nganh;
        }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập ngành đào tạo: ");
                Nganh = Console.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Ngành đào tạo: {Nganh}");
        }
    }
}
