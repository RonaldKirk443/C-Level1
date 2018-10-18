using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    partial class Program
    {
        public static void menu() {
            int menuChoice;
            Console.WriteLine("");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("0. Exit.");
            Console.WriteLine("1. Random Array Number pairs where ONE NUMBER OF THE PAIR is dividable by 3.");
            Console.WriteLine("2. Number 1 but with a file selected.");
            Console.WriteLine("3. Create an array through custom class.");
            Console.WriteLine("4. Login and Password.");
            Console.WriteLine("");
            Int32.TryParse(Console.ReadLine(), out menuChoice);
            Console.WriteLine("");
            switch (menuChoice){
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;

            }
        }
    }
}
