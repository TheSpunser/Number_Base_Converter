using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace UniversalConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("Enter 1 for regular number converter");
            Console.WriteLine("Enter 2 for Converter with Maths");
            Console.WriteLine("Enter 3 for Square Root of number");
            Console.WriteLine("");
            Int64 input = Int64.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    UniConverter();
                    break;
                case 2:
                    ConMath();
                    break;
                case 3:
                    SquareCon();
                    break;
            }
        }
        public static void UniConverter()
        {
            Console.Clear();                                // Aesthetics to make the console cleaner
            Console.WriteLine("Enter number");
            string no = Console.ReadLine();                 // User enters a number of their choice
            Console.WriteLine("Enter input base of number");
            int InBase = int.Parse(Console.ReadLine());     // User indentifies what base this number is
            Console.WriteLine("Enter output base");
            int OutBase = int.Parse(Console.ReadLine());    // User defines what base they want the number to be converted Int64o

            string result = Convert.ToString(Convert.ToInt64(no, InBase), OutBase); // Converts the number to specified base
            Console.WriteLine("");                          // Aesthetics
            Console.WriteLine("Output = " + result);        // Outputs new number onto the screen
        }

        public static void ConMath()
        {
            Console.Clear();
            Console.WriteLine("Enter First number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter first number base");
            int fromBase1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            string number2 = Console.ReadLine();
            Console.WriteLine("Enter second number base");
            int fromBase2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter output base");
            string toBase1 = Console.ReadLine();

            string result1 = Convert.ToString(Convert.ToInt64(number1, fromBase1), 10);
            string result2 = Convert.ToString(Convert.ToInt64(number2, fromBase2), 10);

            Int64 IntRes1 = Int64.Parse(result1);
            Int64 IntRes2 = Int64.Parse(result2);

            Console.WriteLine("+ - * / ?");
            string ConSym = Console.ReadLine();

            int outBase = 0;

            outBase = int.Parse(toBase1);

            switch (ConSym)
            {
                case "+":
                    Int64 Total = IntRes1 + IntRes2;
                    string TotRes = Convert.ToString(Convert.ToInt64(Total), outBase);
                    Console.WriteLine("Total = " + TotRes);
                    break;
                case "-":
                    Int64 Total2 = IntRes1 - IntRes2;
                    string TotRes2 = Convert.ToString(Convert.ToInt64(Total2), outBase);
                    Console.WriteLine("Total = " + TotRes2);
                    break;
                case "/":
                    Int64 Total3 = IntRes1 / IntRes2;
                    string TotRes3 = Convert.ToString(Convert.ToInt64(Total3), outBase);
                    Console.WriteLine("Total = " + TotRes3);
                    break;
                case "*":
                    Int64 Total4 = IntRes1 * IntRes2;
                    string TotRes4 = Convert.ToString(Convert.ToInt64(Total4), outBase);
                    Console.WriteLine("Total = " + TotRes4);
                    break;
            }
        }

        public static void SquareCon()
        {
            Console.Clear();
            Console.WriteLine("Enter number");
            string no = Console.ReadLine();
            Console.WriteLine("Enter input base");
            int InBase = int.Parse(Console.ReadLine());

            string PrePreResult = Convert.ToString(Convert.ToInt32(no, InBase), 10);
            Int64 PreResult = Int64.Parse(PrePreResult);

            double Square = Math.Sqrt(PreResult);

            Console.WriteLine("");
            Console.WriteLine("Output = " + Square);
        }
    }
}
