using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_операторы
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                a = (int)Math.Pow(a, 3);
                Console.WriteLine(a);
            }
            else
            {
                a = 0;
                Console.WriteLine(a);
            }
            if (b >= 0)
            {
                b = (int)Math.Pow(b, 3);
                Console.WriteLine(b);
            }
            else
            {
                b = 0;
                Console.WriteLine(b);
            }
            if (c >= 0)
            {
                c = (int)Math.Pow(c, 3);
                Console.WriteLine(c);
            }
            else
            {
                c = 0;
                Console.WriteLine(c);
            }
            Console.ReadKey();

        }
    }
}
