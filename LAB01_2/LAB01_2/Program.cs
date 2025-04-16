using System.Security.Cryptography;
using System.Text;

internal class Program
{
    public static void soLuongAmDuong(int[] a)
    {
        int[] sl = { 0, 0 };
        foreach (int i in a)
        {
            if (i > 0) sl[1] ++;
            else if (i < 0) sl[0] ++;
        }

        Console.WriteLine($"Số lượng số âm: {sl[0]}");
        Console.WriteLine($"Số lượng số dương: {sl[1]}");
    }

    public static bool isPrime(int n)
    {
        if (n <= 0) return false;
        if (n == 1 || n == 2) return true;
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
    
    public static int tongSoChan(int[] a)
    {
        int s = 0;
        foreach (int i in a)
        {
            if (i % 2 == 0)
            {
                s += i;
            }
        }

        return s;
    }

    public static void merge(int[] a, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] lArr = new int[n1];
        int[] rArr = new int[n2];

        Array.Copy(a, l, lArr, 0, n1);
        Array.Copy(a, m + 1, rArr, 0, n2);

        int i = 0, j = 0, k = l;
        while (i < n1 && j < n2)
        {
            if (lArr[i] <= rArr[j])
            {
                a[k] = lArr[i];
                i++;
            }
            else
            {
                a[k] = rArr[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            a[k] = lArr[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            a[k] = rArr[j];
            j++;
            k++;
        }
    }

    public static void mergeSort(int[] a, int l, int r)
    {
        if(l < r)
        {
            int m = (l + r) / 2;

            mergeSort(a, l, m);
            mergeSort(a, m + 1, r);

            merge(a, l, m, r);
        }
    }

    public static void hoanViHaiSo(ref int a, ref int b)
    {
        int s = a;
        a = b; b = s;
    }

    public static int soLonThuHai(int[] a)
    {
        int m = int.MinValue;

        foreach (int i in a)
        {
            if (m < i) m = i;
        }

        int m2 = int.MinValue;
        foreach (int i in a)
        {
            if (m2 < i && i < m) m2 = i;
        }

        return m2;
    }

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        while (true)
        {
            try
            {
                Console.Write("Nhập số phần tử trong mảng: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0) throw new Exception();
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập lại số phần tử mảng.");
            }
        }

        int[] a = new int[n];
        while (true)
        {
            try
            {
                for(int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập giá trị phần tử {i}: ");
                    a[i] = int.Parse(Console.ReadLine());
                }
                break;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Nhập lại giá trị các phần tử mảng.");
            }
        }
        int s = 0;
        foreach(int i in a)
        {
            s += i;
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là: {s}.");

        // Bài 1.
        Console.WriteLine($"Tổng các phần tử chẵn trong mảng là: {tongSoChan(a)}.");

        // Bài 2.
        Console.WriteLine("Các số nguyên tố trong mảng:");
        for(int i = 0; i < n; i++)
        {
            if (isPrime(a[i]))
            {
                Console.WriteLine($"\ti: {i} - v: {a[i]}");
            }
        }

        // Bài 3.
        soLuongAmDuong(a);

        // Bài 4.
        Console.WriteLine($"Số lớn thứ 2 trong mảng là: {soLonThuHai(a)}");
        // Bài 5.
        int shv1, shv2;
        Console.Write("Nhập số cần hoán vị đầu tiên: ");
        shv1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cần hoán vị thứ 2: ");
        shv2 = int.Parse(Console.ReadLine());
        hoanViHaiSo(ref shv1 , ref shv2);
        Console.WriteLine($"Sau khi hoán vị: ");
        Console.WriteLine($"\tSố đầu tiên: {shv1}");
        Console.WriteLine($"\tSố thứ 2: {shv2}");
        // Bài 6.
        mergeSort(a, 0, a.Length - 1);
        foreach(int i in a)
        {
            Console.Write(i + " ");
        }
    }
}