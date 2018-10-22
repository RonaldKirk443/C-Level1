using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    partial class Program
    {
        public static void pause()
        {
            int pauseChoice;
            Console.WriteLine("");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Return to Main Menu");
            Console.WriteLine("");
            Int32.TryParse(Console.ReadLine(), out pauseChoice);
            Console.WriteLine("");
            switch (pauseChoice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    menu();
                    break;
            }
        }
    }
}
