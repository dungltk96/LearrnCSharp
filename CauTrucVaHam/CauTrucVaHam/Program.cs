using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a, b, c;
            do
            {
                Console.Write("Nhap vao canh a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao canh b = ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao canh c = ");
                c = int.Parse(Console.ReadLine());

                if(a + b <= c || a + c <= b || c + b <= a)
                {
                    Console.WriteLine("Dieu kien lap tam giac khong thoa man! Vui long nhap lai!");
                }
            } while (a + b <= c || a + c <= b || c + b <= a);
            Console.WriteLine("\n3 canh la: {0},{1},{2}", a,b,c);
            Console.ReadLine();
        } */

            //Áp dụng hàm để giải bài toán tinh dt và cv tam giác
            int a, b, c;
            Console.Write("Nhap vao canh a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh c = ");
            c = int.Parse(Console.ReadLine());

            // Kiem tra
            int kt = KiemTraTamGiac(a, b, c);

            // Tinh toan
            
            if (kt == 1)
            {
                int p = (a + b + c) / 2;
                double dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                //Hien thi ra man hinh
                Console.WriteLine("Chu vi la: {0}", p * 2);
                Console.WriteLine("Dien tich la: {0}", dt);
            }
            else
            {
                Console.WriteLine("Dieu kien lap tam giac khong thoa man! Vui long nhap lai!");
            }
            Console.ReadLine();
        }

        //Method
        private static int KiemTraTamGiac(int a1, int b1, int c1)
        {
            if (a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
