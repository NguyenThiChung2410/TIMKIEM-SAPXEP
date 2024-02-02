using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vd2
{
    class Program
    {
        static void PhatSinhMang(int[] a, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(50);
            }
        }
        static void NhapMang(int[]a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap a [{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuatmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        static void InterChangeSort(int[] a, int n)
        {
            int temp;
            int dem = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                        dem++;
                    }
                }
                Console.Write($"\nLan lap i={i}:");
                Xuatmang(a, n);
            }
            Console.WriteLine($"\nSo lan hoan vi:{dem}");
        }

        static int TimTuyenTinh(int[] a, int n, int x)
        {
            int i = 0;
            while (i < n && a[i] != x)
            {
                i++;
            }
            if (i == n)
                return -1;
            else
                return i;
        }
        static int TimNhiPhan(int[] a, int n, int x)
        {
            int left, right, mid;
            left = 0;
            right = n - 1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (a[mid] == x)
                    return mid;
                else if (a[mid] > x)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }
        static void InsertionSort(int []a,int n)
        {
            
            for (int i = 0; i < n ; i++)
            {
                int x = a[i];
                int pos = i;
                while (pos > 0 && a[pos - 1] > x)
                {
                    a[pos] = a[pos - 1];
                    pos--;
                }
                a[pos] = x;
                Console.Write($"\nLan lap i={i}:");
                Xuatmang(a, n);
            }
        }
        static void BubbleSort(int[]a,int n)
        {
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for(int j = n- 1; j >i; j--)
                {
                    if (a[j-1] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j-1];
                        a[j] = temp;
                        
                    }
                }
                Console.Write($"\nLan lap i={i}:");
                Xuatmang(a, n);
            }
           
        }
        public int QuickSort(int[]a,int left,int right)
        {
            int temp;
            int i = left;
            int j = right;
            int x = a[(left + right)/ 2];
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(a, left, j);
            if (i < right)
                QuickSort(a, i, right);
            return j;

        }
        
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n;
            Console.Write("Cho biet so phan tu cua mang:");
            n = int.Parse(Console.ReadLine());
            NhapMang(a, n);
            Console.WriteLine("Mang ban dau duoc phat sinh ngau nhien:");
            Xuatmang(a, n);
            Console.WriteLine("\nKet qua tung buoc cua thuat toan:");
            BubbleSort(a, n);
           
            Console.WriteLine("\nMang duoc sap xep tang:");
            Xuatmang(a, n);
            Console.ReadLine();
        }
    }
}
