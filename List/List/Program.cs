using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhap vao 1 danh sach cac so nguyen,chuyen ds nay thanh mang 1 chieu roi sap xep lai danh sach do.
           // Khoi tao List
            List<int> lst = new List<int>();
            int i = 0;
            String ch = "";

            // Nhap vao danh sach
            Console.WriteLine("Nhap vao danh sach so nguyen");
            do
            {
                Console.Write("\tPhan tu {0}: ", i + 1);
                int a = int.Parse(Console.ReadLine());
                lst.Add(a);
                i++;

                Console.Write("Ban co muon tiep tuc nhap hay khong (c/k)?");
                ch = Console.ReadLine();
                if (ch.Equals("k"))
                {
                    break;
                }
            } while (ch.Equals("c"));

            // Hien thi
            Console.WriteLine("Danh sach vua nhap la:");
            foreach(int a in lst)
            {
                Console.Write(a + "\t");
            }

            // Chuyen danh sach sang mang 1 chieu
            // ToArray(): Copy cac phan tu trong danh sach sang 1 mang khac
            int[] arr= lst.ToArray();

            // Sap xep danh sach
            lst.Sort();

            //Sap xep tren mang 1 chieu
            for(i = 0;i < (arr.Length-1);i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tg = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tg;    
                    }
                }
            }
            // Hien thi danh sach sau khi sap xep
            Console.WriteLine("\nDanh sach sau khi sap xep la:");
            foreach (int a in lst)
            {
                Console.Write(a + "\t");
            }
        }
    }
}
