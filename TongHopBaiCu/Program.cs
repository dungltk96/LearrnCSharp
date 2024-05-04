using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Khắc phục lỗi font tiếng việt
            //Console.OutputEncoding = Encoding.UTF8;

            /*
            //Console.Write(Console.Read()); //nhập được nhiều dòng nhưng chỉ đọc được 1 ký tự đầu tiên từ bàn phím bằng lệnh Console.Read() sau đó in ra ký tự vừa đọc được.(trả về kiểu số nguyên)
            Console.Write(Console.ReadLine()); //đọc dữ liệu từ bàn phím cho đến khi gặp ký tự xuống dòng thì dừng và giá trị đọc được luôn là một chuỗi.
            Console.Write(Console.ReadKey()); //Lệnh này cũng dùng để đọc một ký tự từ bàn phím nhưng trả về kiểu ConsoleKeyInfo (là một kiểu dữ liệu có cấu trúc được định nghĩa sẵn để chứa những ký tự của bàn phím bao gồm các phím chức năng)
            Console.ReadKey(); //lệnh này dùng với mục đích dừng màn hình để xem kết quả.
            */

            /*
            //Cách 1
            //int a = 5;
            //Console.Write("a = ");
            //Console.Write(a);  

            //Cách 2
            //int a = 5;
            //Console.WriteLine("a = " + a);

            //Cách 3
            //int a = 5;
            Console.WriteLine("a = {0}", a);
            Console.Write(Environment.NewLine); 
            Console.WriteLine("{0} {1} {2}", 3, 2, "Xin chào");

            //Lệnh dừng màn hình để xem kết quả
            Console.ReadKey();
            //Console.ReadLine();
            */

            //Console.WriteLine("         K team"); // In chữ "K team" sau đó xuống dòng.
            //Console.Write(" Moi ban nhap ten cua minh: "); // In không xuống dòng.
            //Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó. Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine() sau đó thực hiện cộng chuỗi và cuối cùng in chuỗi ra màn hình.
            //Console.Write(" Moi ban nhap ngay sinh: ");
            //Console.WriteLine(" Ngay sinh cua ban la: " + Console.ReadLine()); // Tương tự như trên
            //Console.Write(" Moi ban nhap que quan: ");
            //Console.WriteLine(" Que quan: " + Console.ReadLine()); // Tương tự như trên.
            //Console.ReadKey();

            //Ex01
            //Console.Write("HowKteam.com xin chào: " + Console.ReadLine());
            //Console.ReadKey();

            //Ex02
            //Console.OutputEncoding = Encoding.UTF8; 
            //Console.Write("Bạn tên: " + Console.ReadLine() + ", " + Console.ReadLine() + " tuổi, " + "ở " + Console.ReadLine());
            //Console.ReadLine();

            /*
            int kieusonguyen = 3;
            float bienkieusothuc = 2.3f;
            string bienkieuchuoi = "Dung";
            bool bienkieuluanly = true;
            char bienkieukytu = 'd';

            int aNum = 3;
            int bNum = 5;
            int cNum = aNum + bNum;

            Console.WriteLine("Gia tri la: a + b = c: {0} + {1} = {2}", aNum, bNum, cNum);
            Console.ReadLine();
            */

            /*
            // Bai0: Xác định giá trị x,y,z
            //int x, y, z;
            //x = 9;
            //y = x++;
            //z = x--;

            //Console.WriteLine("x = {0}, y = {1}, z = {2}", x,y,z);
            //Console.ReadLine(); 


            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Moi ban nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            // Bai01: Sử dụng hàm if else kiểm tra số nhập vào là số chẵn hay lẻ
            //if (n%2 == 0)
            //{
            //    Console.WriteLine("{0} là so chan", n);
            //}else
            //{
            //    Console.WriteLine("{0} la so le", n);
            //}
            //Console.ReadLine();


            //Bai02: Kiểm tra số nhập vào là số 0, nguyên âm hay nguyên dương
            // Cách 1 sd 3 hàm if
            //if (n == 0)
            //{
            //    Console.WriteLine("{0} la so 0", n);
            //}
            //if (n > 0) //Hoặc dùng else if
            //{
            //    Console.WriteLine("{0} là số nguyên dương", n);
            //}
            //if (n <0)
            //{
            //    Console.WriteLine("{0} là số nguyên âm", n);
            //}
            //Console.ReadLine();

            // Cách 2 sử dụng hàm if else  
            //if (n != 0) 
            //{ 
            //    if (n > 0)
            //    {
            //        Console.WriteLine("{0} la so nguyen duong", n);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} la so nguyen am", n);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("{0} la 0", n);
            //}
            //Console.ReadLine();


            //Bai03: Nhập số hiển thị ngày trong tuần
            if (n >= 2 && n <= 8)
            {
                switch (n)
                {
                    case 2:
                        Console.WriteLine("Thứ 2");
                        break;
                    case 3:
                        Console.WriteLine("Thứ 3");
                        break;
                    case 4:
                        Console.WriteLine("Thứ 4");
                        break;
                    case 5:
                        Console.WriteLine("Thứ 5");
                        break;
                    case 6:
                        Console.WriteLine("Thứ 6");
                        break;
                    case 7:
                        Console.WriteLine("Thứ 7");
                        break;
                    default:
                        Console.WriteLine("Chủ nhật");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số trong khoảng từ 2 đến 8!");
            }
            Console.ReadLine();
            */
            ///111111111
            //Vi du vong lap for
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("So cute!");
            //}
            //Console.ReadLine();


            // Tinh tong s = 1 + 2 + ... + n 
            //Console.Write("Nhap n: ");
            //int n = int.Parse(Console.ReadLine());
            //int tong = 0;
            //for (int i = 0; i < n; i++) {
            //    tong += i;
            //}
            //Console.WriteLine("Tong cua day là: " + tong);
            //Console.ReadLine(); 

            // Tim USCLN
            Console.Write("Nhap vao so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            int b = int.Parse(Console.ReadLine());

            int m = a;
            int n = b;

            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            Console.WriteLine("USCLN ({0}, {1}) = {2}", m, n, b);
            Console.ReadLine();
        }
    }
}
