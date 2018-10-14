using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    //Ronald Kirk
    //Домашнее задание урок 3 - номер 3

    class Program
    {

        static int f1A, f1B, f2A, f2B;

        static Fraction f1 = new Fraction(1, 1);
        static Fraction f2 = new Fraction(1, 1);

        static void Main(string[] args)
        {
            input();
        }

        static void input()
        {
            Console.WriteLine("Enter the nominator of the first fraction (top number): ");
            Int32.TryParse(Console.ReadLine(), out f1A);
            Console.WriteLine("Enter the denominator of the first fraction (bottom number): ");
            Int32.TryParse(Console.ReadLine(), out f1B);
            f1.Numerator = f1A;
            f1.Denominator = f1B;
            Console.WriteLine("");
            Fraction.simplify(f1);
            Console.WriteLine("");
            Console.WriteLine("Enter the nominator of the second fraction (top number): ");
            Int32.TryParse(Console.ReadLine(), out f2A);
            Console.WriteLine("Enter the denominator of the second fraction (bottom number): ");
            Int32.TryParse(Console.ReadLine(), out f2B);
            f2.Numerator = f2A;
            f2.Denominator = f2B;
            Console.WriteLine("");
            Fraction.simplify(f2);
            Console.WriteLine("");
            Console.WriteLine($"Your first fraction is {f1} and your second fraction is {f2}.");

            menu();
        }

        static void menu()
        {
            int result;
            Console.WriteLine("");
            Console.WriteLine("Main Menu: ");
            Console.WriteLine("1. Change fractions: ");
            Console.WriteLine("2. Add the two fractions: ");
            Console.WriteLine("3. Substract the first fraction from the second fraction: ");
            Console.WriteLine("4. Multiply the two fractions: ");
            Console.WriteLine("5. Divide the first fraction by the second fraction: ");
            Console.WriteLine("");
            int.TryParse(Console.ReadLine(), out result);
            Console.WriteLine("");

            switch (result)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    input();
                    break;
                case 2:
                    add();
                    break;
                case 3:
                    substract();
                    break;
                case 4:
                    multiply();
                    break;
                case 5:
                    divide();
                    break;
                default:
                    Console.WriteLine("Invalid Option. Try Again: ");
                    Console.WriteLine("");
                    menu();
                    break;
            }

        }

        static void add()
        {
            Fraction f3 = Fraction.add(f1, f2);
            Fraction.simplify(f3);
            Console.WriteLine(f1 + " + " + f2 + " = " + f3);
            pause();
        }

        static void substract()
        {
            Fraction f3 = Fraction.substract(f1, f2);
            Fraction.simplify(f3);
            Console.WriteLine(f1 + " - " + f2 + " = " + f3);
            pause();
        }

        static void multiply()
        {
            Fraction f3 = Fraction.multiply(f1, f2);
            Fraction.simplify(f3);
            Console.WriteLine(f1 + " * " + f2 + " = " + f3);
            pause();
        }

        static void divide()
        {
            Fraction f3 = Fraction.divide(f1, f2);
            Fraction.simplify(f3);
            Console.WriteLine(f1 + " / " + f2 + " = " + f3);
            pause();
        }

        static void pause()
        {
            int result;
            Console.WriteLine("");
            Console.WriteLine("0. Exit Program.");
            Console.WriteLine("1. Return to main menu.");
            Console.WriteLine("");
            int.TryParse(Console.ReadLine(), out result);
            Console.WriteLine("");

            switch (result)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    menu();
                    break;
                default:
                    pause();
                    Console.WriteLine("Invalid Option. Try Again: ");
                    Console.WriteLine("");
                    break;
            }
        }

    }

    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        
        public int Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

      
        public int Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }

                this.denominator = value;
            }
        }

        public static void simplify(Fraction frac1) {

            int divisor = gcd(frac1.Numerator, frac1.Denominator);

            if (divisor != 1)
            {
                frac1.Numerator = division(frac1.Numerator, divisor);
                frac1.Denominator = division(frac1.Denominator, divisor);
                Console.WriteLine("The resulted fraction was reduced to {0}/{1}", frac1.Numerator, frac1.Denominator);
            }
            else {
            }
        }

        static int division(int a, int b)
        {
            int remainder = a, quotient = 0;
            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }
            return quotient;
        }

        static int gcd(int a, int b)
        {
            //Greatest Common Denominator through Euclid’s algorithm
            while (a != b)
                if (a < b && a > -1) b = b - a;
                else if (a < b && a <= -1) b = b + a;
                else a = a - b;
            return a;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Numerator + "/" + this.Denominator);
            return sb.ToString();
        }

        public static Fraction add(Fraction frac1, Fraction frac2) {
            int newNumerator = frac1.Numerator * frac2.Denominator + frac2.Numerator * frac1.Denominator;
            int newDenominator = frac1.Denominator * frac2.Denominator;
            return (new Fraction(newNumerator, newDenominator));
        }

        public static Fraction multiply(Fraction frac1, Fraction frac2) {
            int newNumerator = frac1.Numerator * frac2.Numerator;
            int newDenominator = frac1.Denominator * frac2.Denominator;
            return (new Fraction(newNumerator, newDenominator));
        }

        public static Fraction divide(Fraction frac1, Fraction frac2) {
            Fraction tempFrac = frac2;
            tempFrac.Numerator = tempFrac.Numerator + tempFrac.Denominator;
            tempFrac.Denominator = tempFrac.Numerator - tempFrac.Denominator;
            tempFrac.Numerator = tempFrac.Numerator - tempFrac.Denominator;
            int newNumerator = frac1.Numerator * tempFrac.Numerator;
            int newDenominator = frac1.Denominator * tempFrac.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction substract(Fraction frac1, Fraction frac2) {
            return (Fraction.add(frac1, Fraction.opposite(frac2)));
        }

        private static Fraction opposite(Fraction frac1)
        {
            int newNumerator = -frac1.Numerator;
            int newDenominator = frac1.Denominator;
            return new Fraction(newNumerator, newDenominator);

        }

    }

}
