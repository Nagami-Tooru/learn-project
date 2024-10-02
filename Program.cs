using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
                Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Gia tri tu 0 den a:");
            for (int i = 0; i <= a; i++)
            { 
                Console.WriteLine(i);
            }
            Console.WriteLine($"Gia tri tu a den 0:");
            for (int i = a;i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
