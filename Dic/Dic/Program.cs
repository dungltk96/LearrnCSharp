using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "One");
            dic1.Add(2, "Two");
            dic1.Add(3, "Three");

            foreach (KeyValuePair<int, string> kvp in dic1)
            {
                int key = kvp.Key;
                string value = kvp.Value;

                Console.WriteLine("Key: {0} - Value: {1}", key, value);
            }

            for (int i = 0; i < dic1.Count; i++)
            {
                int key = dic1.Keys.ElementAt(i);
                string value = dic1[key];

                Console.WriteLine("Key: {0} - Value: {1}", key, value);
            }
            Console.ReadLine();*/

            //Nhập tên và thủ đô tương ứng của các quốc gia đó
            Dictionary<string, string> dic = new Dictionary<string, string>();  
            List<string> ls1 = new List<string>(5);
            List<string> ls2 = new List<string>(5);

            Console.WriteLine("Ban hay nhap ten cac quoc gia va ten cac thu do tuong ung:");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Nhap ten quoc gia thu {0}: ", i + 1);
                string tenQG = Console.ReadLine();
                ls1.Add(tenQG);

                Console.Write("\t Ten thanh pho: ");
                string tenPT = Console.ReadLine();
                ls2.Add(tenPT);
            }
            // Đổ ls1 và ls2 vào Dictionary
            for (int i = 0; i < 5; i++)
            {
                dic.Add(ls1[i], ls2[i]);
            }

            // Hien thi Dic
            foreach(KeyValuePair<string, string> item in dic)
            { 
                Console.WriteLine("Quoc gia: {0} - Thanh pho {1}", item.Key, item.Value);
            }

            foreach(KeyValuePair <string, string> item in dic)
            {
                if(item.Key.Equals("Viet Nam"))
                {
                    Console.WriteLine("Thu do la: " + item.Value);
                }
            }   
            
            Console.ReadLine();
        }
    }
}