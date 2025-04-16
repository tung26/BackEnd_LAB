using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class NhanVien : CanBo
    {
        public string job {  get; set; }

        public NhanVien () { }

        public NhanVien (string job, string hoTen, byte gioiTinh, int namSinh, string diaChi) : base(hoTen, gioiTinh, namSinh, diaChi) { this.job = job; }

        public new void nhap()
        {
            try
            {
                base.nhap();
                Console.Write("Nhập công việc: ");
                job = Console.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"Công việc: {job}");
        }
    }
}
