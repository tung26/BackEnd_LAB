using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_3
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo()
        {
            TuSo = 1;
            MauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            }
            TuSo = tuSo;
            MauSo = mauSo;
        }

        public void nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine($"Phân số: {TuSo} / {MauSo}.");
        }

        public bool checkToiGian()
        {
            if (MauSo == 1) return true;

            for (int i = 2; i <= MauSo; i++)
            {
                if (TuSo % i == 0 && MauSo % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void toiGian()
        {
            for (int i = MauSo; i > 1; i--)
            {
                if (TuSo % i == 0 && MauSo % i == 0)
                {
                    TuSo = TuSo / i;
                    MauSo = MauSo / i;
                }
            }
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo phanSoTong = new PhanSo();
            phanSoTong.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            phanSoTong.MauSo = a.MauSo * b.MauSo;
            phanSoTong.toiGian();
            return phanSoTong;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo phanSoHieu = new PhanSo();
            phanSoHieu.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            phanSoHieu.MauSo = a.MauSo * b.MauSo;
            phanSoHieu.toiGian();
            return phanSoHieu;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo phanSoNhan = new PhanSo();
            phanSoNhan.TuSo = a.TuSo * b.TuSo;
            phanSoNhan.MauSo = a.MauSo * b.MauSo;
            phanSoNhan.toiGian();
            return phanSoNhan;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo phanSoChia = new PhanSo();
            phanSoChia.TuSo = a.TuSo * b.MauSo;
            phanSoChia.MauSo = a.MauSo * b.TuSo;
            phanSoChia.toiGian();
            return phanSoChia;
        }
    }
}
