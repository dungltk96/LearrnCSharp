using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bai 1: Cho phép người dùng nhập môt dãy số nguyên a1, a2, ...an
             * a. Tính tổng và TBC các phần tử trong dãy
             * b. Tìm max và in ra vị trí phần tử max
             * c. Cho người dùng nhập vào 1 phần tử x, tìm và in ra vị trí của phần tử trong dãy có giá trị bằng x */

            int[] a = new int[10];
            int n, i, s = 0, max;
            double tb;

            //Nhap vao mang
            Console.Write("Nhap vao so luong phan tu n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao gia tri cho mang:");
            for (i = 0; i < n; i++)
            {
                Console.Write("\t Phan tu thu " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine()); 
            }

            // Hien thi mang
            Console.WriteLine("Mang vua nhap la: ");
            for(i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }

            //Cau a
            for(i = 0; i < n;i++)
            {
                s += a[i];
            }
            Console.WriteLine("\n\nTong cac phan tu trong mang la: {0}", s);
            Console.WriteLine("Trung binh cong cac phan tu la: {0}", (double)s/n);

            // Cau b
            max = a[0];
            for(i = 0; i < n; i++)
            {
                if(max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Phan tu co gia tri lon nhat la: " + max);
            Console.Write("Vi tri phan tu co gia tri bang max la: ");
            for(i=0; i<n; i++)
            {
                if (a[i] == max)
                {
                    Console.WriteLine(i);
                }
            }

            // Cau c:
            Console.Write("\nNhap vao phan tu x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vi tri phan tu trong mang có gia tri bang x la: ");
            for(i=0; i<n;i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine(i+1);
                }
            }
            Console.ReadLine();
        }
    }
}
