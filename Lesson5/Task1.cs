using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson4
{
    partial class Program
    {
        static void task1() {
            Console.WriteLine("");
            Console.WriteLine("Enter a login.");
            String login = Console.ReadLine();
            Regex regex = new Regex("^[A-Za-z][A-Za-z0-9]{1,9}$");
            Console.WriteLine(regex.IsMatch(login));
            pause();
        }
    }
}
