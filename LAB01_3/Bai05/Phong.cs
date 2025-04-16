using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Phong
    {
        public int SoNgayTro {  get; set; }
        public string LoaiPhong { get; set; }
        public float GiaPhong { get; set; }
        public Nguoi Nguoi { get; set; }

        public Phong() { }
        public Phong(int soNgayTro, string loaiPhong, float giaPhong, Nguoi nguoi)
        {
            SoNgayTro = soNgayTro;
            LoaiPhong = loaiPhong;
            GiaPhong = giaPhong;
            Nguoi = nguoi;
        }

        public void nhap(Nguoi nguoiThue)
        {
            try
            {
                Console.Write("Nhập số ngày trọ: ");
                SoNgayTro = int.Parse(Console.ReadLine());
                Console.Write("Nhập loại phòng: ");
                LoaiPhong = Console.ReadLine();
                Console.Write("Nhập giá phòng: ");
                GiaPhong = int.Parse(Console.ReadLine());
                Nguoi = nguoiThue;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
