using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class PTGT
    {
        public string HangSX { get; set; }
        public int NamSX { get; set; }
        public double GiaBan { get; set; }
        public string Mau { get; set; }

        public PTGT() { }
        public PTGT(string hangSX, int namSX, double giaBan, string mau)
        {
            HangSX = hangSX;
            NamSX = namSX;
            GiaBan = giaBan;
            Mau = mau;
        }

        public virtual void Nhap()
        {
            try
            {
                Console.Write("Hãng sản xuất: ");
                HangSX = Console.ReadLine();
                Console.Write("Năm sản xuất: ");
                NamSX = int.Parse(Console.ReadLine());
                Console.Write("Giá bán: ");
                GiaBan = double.Parse(Console.ReadLine());
                Console.Write("Màu: ");
                Mau = Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Hãng SX: {HangSX} - Năm SX: {NamSX} - Giá: {GiaBan} - Màu: {Mau}.");
        }
    }
}
