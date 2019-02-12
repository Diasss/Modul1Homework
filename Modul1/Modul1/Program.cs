using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - to open task1, 2 - to open task2");
            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
            }
        }
        static void task1()
        {
            Console.WriteLine("Write your name and fname");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
        static void task2()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("sum = {0}", a + b);
        }

    }
}
