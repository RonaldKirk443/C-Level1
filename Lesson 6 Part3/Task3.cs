using System;
using System.Collections;
using System.IO;

namespace Lesson_6_Part3
{
    class Task3
    {
        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int course = 0;
            int year = 0;
            // Создадим необобщенный список
            ArrayList list = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    //Console.Write("{4}", s[0], s[1], s[2], s[3], s[4]);
                    //Console.WriteLine("");
                    list.Add(s[5]);// Добавляем склееные имя и фамилию
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    if (int.Parse(s[7]) == 5 || int.Parse(s[7]) == 6) course++;
                    if (int.Parse(s[5]) <= 18 || int.Parse(s[5]) >= 20) year++;
                }
                catch
                {
                }
            }
            sr.Close();
            list.Sort();
            
            Console.WriteLine("Total Students :{0}", list.Count);
            Console.WriteLine("Magistr :{0}", magistr);
            Console.WriteLine("Bachelor :{0}", bakalavr);
            Console.WriteLine("Course 5 or 6 :{0}", course);
            Console.WriteLine("Students between 18 and 20 :{0}", year);
            foreach (var v in list) Console.WriteLine(v);
            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }

    }
}
