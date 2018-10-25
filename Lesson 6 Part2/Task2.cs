using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Part2
{

    delegate double Func(double x);

    class Task2
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double A(double x)
        {
            return x * x;
        }

        public static double B(double x)
        {
            return (x * x) - x;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, double choice, Func f)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));

                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();

        }


        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("1. x * x - 50 * x + 10");
            Console.WriteLine("2. x * x");
            Console.WriteLine("3. x * x - x");
            Console.WriteLine("");
            Int32.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("");
            if (c == 1)
            {
                SaveFunc("data.bin", -100, 100, 0.5, c, new Func(F));
            }
            else if (c == 2) {
                SaveFunc("data.bin", -100, 100, 0.5, c, new Func(A));
            }
            else if (c == 3)
            {
                SaveFunc("data.bin", -100, 100, 0.5, c, new Func(B));
            }
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}
