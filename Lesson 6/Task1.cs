using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{

    delegate double Func(double x, double a);

    class Task1
    {
        public static void Table(Func Func, double x, double y, double a, double b)
        {
            Console.WriteLine("      X         Y");
            while (a <= b)
            {
                Console.WriteLine("{0,8:0.00}      {1,0:0.00}", x, Func(x, y));
                x++;
                a++;
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static double cubed(double x, double a)
        {
            return a * x * x;
        }

        public static double squared(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Function Table MyFunction:");
            Table(new Func(cubed), 2, 3, 1, 6);

            Console.WriteLine("Sin Function Table:");
            Table(new Func(squared), 2, 3, 1, 6);
            Console.ReadKey();
        }
    }
}
