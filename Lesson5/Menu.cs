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
            Console.WriteLine("1. Enter a login from 2-10 symbols where the first symbol cannot be a number.");
            //Я забыл про домашку и вспомнил только когда было поздно. Я успел зделать только первое задание. Извините. :(
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

            }
        }
    }
}
