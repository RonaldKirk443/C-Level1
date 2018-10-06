using System;

namespace Lesson1
{
    class Program
    {
        static void Main()
        {
            //Console.Title = "TETSETST";
            Console.SetWindowSize(90, 20);
            Console.SetBufferSize(90, 20);
            String name, lastName;
            int age;
            float height, weight;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your age (years): ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height (m): ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight (kg): ");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine($"You are {name} {lastName} at the age of {age} with the height of {height}cm and the weight of {weight}kg");

            float imt = weight / (height*height);
            Console.WriteLine("Your index of the mass of the body is " + imt + "\n");

            double x1, y1, x2, y2, result;
            Console.WriteLine("Let\'s calculate the distance between the points (x1,y1) and (x2,y2).");
            Console.WriteLine("Type in a number for x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type in a number for y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type in a number for x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type in a number for y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            result = numberThree(x1, x2, y1, y2);
            Console.WriteLine($"The distance between (x1,y1) and (x2,y2) is {result:F2}." + "\n");

            int a, b;
            Console.WriteLine("Now you will type in two numbers and they will switch places without a third number to store anything in.");
            Console.WriteLine("Type in number a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in number b.");
            b = Convert.ToInt32(Console.ReadLine());
            numberFour(a, b);
            Console.WriteLine();

            numberFive("Ronald","Kirk","123 Street Street, City, Country");
            Console.WriteLine();

            Pause("Press any key to exit.");

        }

        static double Sum(double a, double b) {
            return a + b;
        }

        static double numberThree(double x1, double x2, double y1, double y2) {
            double result;
            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }

        static void numberFour(int a, int b) {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Number a is now " + a);
            Console.WriteLine("Number b is now " + b);
        }

        static void numberFive(String name, String lastName, String living) {
            Console.SetCursorPosition((Console.WindowWidth - name.Length) / 2, Console.CursorTop);
            Console.WriteLine(name);
            Console.SetCursorPosition((Console.WindowWidth - lastName.Length) / 2, Console.CursorTop);
            Console.WriteLine(lastName);
            Console.SetCursorPosition((Console.WindowWidth - living.Length) / 2, Console.CursorTop);
            Console.WriteLine(living);
        }

        static void Pause(String message) {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
