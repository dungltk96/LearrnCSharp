using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap vao mot chuoi bat ky:");
            string str = Console.ReadLine();

            str = str.ToUpper();

            Console.WriteLine("Chuoi vua nhap la: " + str);

            Console.ReadLine();
        }
    }
}
