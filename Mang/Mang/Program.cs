using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Khai bao mang
            int[] a = new int[10];

            // Nhap n
            Console.Write("Nhap vao so luong phan tu n = ");
            int n = int.Parse(Console.ReadLine());

            // Nhap gia tri cho mang
            Console.WriteLine("Nhap vao gia tri cho mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\tPhan tu thu " + (i+1) + " la: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            // Duyet mang
            Console.WriteLine("Duyet mang theo for:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "     ");
            }

            Console.WriteLine("\nDuyet mang theo foreach:");
            foreach (int i in a)
            {
                Console.Write(i + "     ");
            }
         
            Console.ReadLine();
        }
    }
}
