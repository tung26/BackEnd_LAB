using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    internal class HinhTron
    {
        public Diem Tam { get; set; }
        public double BanKinh { get; set; }

        public HinhTron()
        {
            Tam = new Diem();
            BanKinh = 0;
        }
        public HinhTron(Diem d, double bk)
        {
            Tam = d;
            BanKinh = bk;
        }

        public double ChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
        public double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
        public bool GiaoNhau(HinhTron ht)
        {
            double kcTam = this.Tam.TinhKhoangCach(ht.Tam);
            return kcTam < (this.BanKinh + ht.BanKinh);
        }
        public void InThongTin()
        {
            Console.WriteLine($"Tâm: ({Tam.x}, {Tam.y}), Bán kính: {BanKinh}, Chu vi: {ChuVi():F2}, Diện tích: {DienTich():F2}");
        }
    }
}
