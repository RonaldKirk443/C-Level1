using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    partial class Program
    {
        static void task2() {
            String s = StaticClass.getPath();
            int[] task2Array = StaticClass.getArray(@s);
            if (task2Array == null)
            {
                pause();
            }
            else
            {
                StaticClass.calcArray(task2Array);
                pause();
            }
        }
    }

    static class StaticClass {

        static int count;

        public static void calcArray(int[] arr) {
            for (int i = 0; i < arr.Length -1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i + 1] % 3 == 0 && arr[i] % 3 != 0))
                {
                    count++;
                }
            }

            Console.WriteLine("There were " + count + " pairs which have ONLY ONE number OF THE PAIR dividable by 3.");
            
        }

        public static String getPath() {
         
            
                Console.WriteLine("");
                Console.WriteLine("Type in the path to a file with ONLY NUMBERS:");
                Console.WriteLine("It should have the following format: c(disk letter):\\folder\\folder\\file.txt");
                Console.WriteLine("Or if it is not in a folder then: c(disk letter):\\file.txt");
                Console.WriteLine("");
                String f = Console.ReadLine();
                Console.WriteLine("");
                return f;
            


        }

        public static int[] getArray(string file) {

            int[] a;

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(file);
                int size = File.ReadLines(file).Count();
                a = new int[size];
                //Console.WriteLine(size);
                int i = 0;
                do
                {

                    a[i] = int.Parse(sr.ReadLine());
                    //Console.WriteLine(a[i]);
                    i++;
                }
                while (!sr.EndOfStream);

                return a;

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found. Oops.");
               
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            finally
            {
                if (sr != null) sr.Close();
            }
        }

    }

}
