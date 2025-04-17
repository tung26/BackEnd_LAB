using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class MaTran
    {
        public int H {  get; set; }
        public int C { get; set; }
        public int[,] MTran { get; set; }

        public MaTran() { }
        public MaTran(int h, int c)
        {
            H = h;
            C = c;
            MTran = new int[H, C];
        }

        public void nhap()
        {
            try
            {
                int n, m;
                Console.Write("Nhập số hàng: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Nhập số cột: ");
                m = int.Parse(Console.ReadLine());

                H = n;
                C = m;

                Console.Clear();
                int[,] nMTran = new int[H, C];
                Console.WriteLine("Nhập ma trận: ");
                for (int i = 0; i < H; i++)
                {
                    for (int l = 0; l < C; l++)
                    {
                        for (int j = 0; j < H; j++)
                        {
                            for (int k = 0; k < C; k++)
                            {
                                if ((i == j && l == k) || (i == j && l < k))
                                {
                                    char x = j == i && l == k ? 'X' : 'O';
                                    Console.Write($"{x, -4} ");
                                }
                                else
                                {
                                    Console.Write($"{nMTran[j, k], -4} ");
                                }
                            }
                            Console.WriteLine();
                        }

                        Console.Write("Nhập vị trí X: ");
                        nMTran[i, l] = int.Parse( Console.ReadLine() );
                        Console.Clear();
                    } 
                }

                MTran = nMTran;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void xuat()
        {
            for (int i = 0; i < H; i++)
            {
                for(int l = 0;l < C; l++)
                {
                    Console.Write($"{MTran[i, l], -4} ");
                }
                Console.WriteLine();
            }
        }

        public MaTran Cong(MaTran B)
        {
            try
            {
                if (this.H != B.H || this.C != B.C) throw new Exception("Kích thước hai ma trận không hợp lệ.");
                MaTran D = new MaTran(H, C);
                for(int i = 0; i < H; i++)
                {
                    for(int j = 0; j < C; j++)
                    {
                        D.MTran[i, j] = MTran[i, j] + B.MTran[i, j];
                    }
                }

                return D;

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.Write("Nhấn nút bất kì để tiếp tục.");
                Console.ReadKey();

                return null;
            }
        }

        public MaTran Tru(MaTran B)
        {
            try
            {
                if (this.H != B.H || this.C != B.C)
                    throw new Exception("Kích thước hai ma trận không hợp lệ.");
                MaTran D = new MaTran(H, C);
                D.MTran = new int[H, C];
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < C; j++)
                    {
                        D.MTran[i, j] = MTran[i, j] - B.MTran[i, j];
                    }
                }
                return D;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.Write("Nhấn nút bất kỳ để tiếp tục.");
                Console.ReadKey();
                return null;
            }
        }

        public MaTran Nhan(MaTran B)
        {
            try
            {
                if (this.C != B.H)
                    throw new Exception("Số cột ma trận A phải bằng số hàng ma trận B.");
                MaTran D = new MaTran(this.H, B.C);
                D.MTran = new int[this.H, B.C];
                for (int i = 0; i < this.H; i++)
                {
                    for (int j = 0; j < B.C; j++)
                    {
                        D.MTran[i, j] = 0;
                        for (int k = 0; k < this.C; k++)
                        {
                            D.MTran[i, j] += this.MTran[i, k] * B.MTran[k, j];
                        }
                    }
                }
                return D;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.Write("Nhấn nút bất kỳ để tiếp tục.");
                Console.ReadKey();
                return null;
            }
        }

        public MaTran Chia(MaTran B)
        {
            try
            {
                if (this.H != B.H || this.C != B.C)
                    throw new Exception("Kích thước hai ma trận không hợp lệ.");
                MaTran D = new MaTran(H, C);
                D.MTran = new int[H, C];
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < C; j++)
                    {
                        if (B.MTran[i, j] == 0)
                            throw new Exception($"Phần tử B[{i},{j}] bằng 0. Không thể chia.");
                        D.MTran[i, j] = MTran[i, j] / B.MTran[i, j];
                    }
                }
                return D;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.Write("Nhấn nút bất kỳ để tiếp tục.");
                Console.ReadKey();
                return null;
            }
        }

    }
}
