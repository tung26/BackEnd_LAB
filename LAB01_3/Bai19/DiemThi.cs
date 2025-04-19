using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class DiemThi
    {
        public double Toan {  get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }

        public DiemThi() { }
        public DiemThi(double toan, double ly, double hoa)
        {
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
        }

        public double TongDiem() => Toan + Ly + Hoa;

        public string xuat() =>  $"Toán: {Toan}, Lý: {Ly}, Hóa: {Hoa} - Tổng: {TongDiem()}";
    }
}
