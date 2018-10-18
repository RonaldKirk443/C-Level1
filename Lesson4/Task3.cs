using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    partial class Program
    {

        static void task3() {
            int size, first, step;
            Console.WriteLine("Enter the size of the array: ");
            
            Int32.TryParse(Console.ReadLine(), out size);
            Console.WriteLine("");
            Console.WriteLine("Enter the first number of the array: ");
            
            Int32.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("");
            Console.WriteLine("Enter the steps between the numbers of the array: ");
            
            Int32.TryParse(Console.ReadLine(), out step);
            Console.WriteLine("");
            Array array = new Array(size, first, step);
            pause();
        }

    }


    class Array {

        static int arrayMenuChoice = 0;

        public Array(int size, int firstNum, int step) {
            int[] ar = new int[size];
            ar[0] = firstNum;
            Console.Write(ar[0] + " ");
            for (int i = 1; i < size; i++) {
                ar[i] = firstNum + step * i;
                Console.Write(ar[i] + " ");
            }

            Console.WriteLine("");
            arrayMenu();


            Console.WriteLine("");
            switch (arrayMenuChoice)
            {
                case 0:
                    Program.menu();
                    break;
                case 1:
                    Console.WriteLine(Sum(ar));
                    break;
                case 2:
                    Inverse(ar);
                    break;
                case 3:
                    Multi(ar);
                    break;
                case 4:
                    Console.WriteLine("The maximum number of the array is " + MaxCount(ar));
                    break;


            }

        }

        static void arrayMenu() {
            Console.WriteLine("");
            Console.WriteLine("Array Menu: ");
            Console.WriteLine("0. Return to Main Menu.");
            Console.WriteLine("1. Get Sum of all of the numbers in the array.");
            Console.WriteLine("2. Inverse the numbers in the array.");
            Console.WriteLine("3. Multiply all of the numbers in the array by a certain number.");
            Console.WriteLine("4. Get the amount of numbers in the array.");
            //(Я не очень понял что вы имели в виду в MaxCount)
            Console.WriteLine("");
            Int32.TryParse(Console.ReadLine(), out arrayMenuChoice);
        }

        static int Sum(int[] a)
        {

            int sumNum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sumNum += a[i];
            }
            return sumNum;
        }

        static int[] Inverse(int[] a) {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {

                b[i] = a[i] * -1;
                Console.Write(b[i] + " ");

            }
            Console.WriteLine("");
            return b;
        }

        static int[] Multi(int[] a)
        {
            int m;
            Console.WriteLine("Enter the number you want to multiply by.");
            Console.WriteLine("");
            Int32.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("");
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {

                b[i] = a[i] * m;
                Console.Write(b[i] + " ");

            }
            Console.WriteLine("");

            return b;
        }

        static int MaxCount(int[] a)
        {

            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) {
                    max = a[i];
                }
            }
            return max;
        }

    }
}
