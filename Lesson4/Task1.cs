using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    partial class Program
    {
        static void task1() {
            Random rnd = new Random();
            int task1Min = -10000;
            int task1Max = 10000;
            int count = 0;
            int[] task1Arr = new int[20];
            for (int i = 0; i < 20; i++) {
                task1Arr[i] = rnd.Next(task1Min, task1Max +1);
                Console.Write(" " + task1Arr[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            

            for (int i = 0; i < 19; i++)
            {
                if ((task1Arr[i] % 3 == 0 && task1Arr[i+1] % 3 != 0) || (task1Arr[i+1] % 3 == 0 && task1Arr[i] % 3 != 0)) {
                    count++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("There were " + count + " pairs which have ONLY ONE number OF THE PAIR dividable by 3.");
            pause();
        }
    }
}
