using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Basic Console I/O ***********");

            GetUserData();
            Console.WriteLine("Some More Text!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("{0}, Number {0}, Number {0}", 9);

            Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
            Console.ReadLine();
            Console.Clear();

            DemonstrateAlignment();

            FormatNumericalData();

            Console.ReadLine();
        }

        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:C}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }

        static void DemonstrateAlignment()
        {
            LeftAlign();
            RightAlign();
        }

        static void LeftAlign()
        {
            string lineOutputFormat = "{0,-15} {1,-2} {2,-5}";
            Console.WriteLine(lineOutputFormat, "John Doe", "OH", "44113");
            Console.WriteLine(lineOutputFormat, "Jane Doe", "NY", "12065");
            Console.WriteLine(lineOutputFormat, "Cheech Marin", "CA", "90210");
            Console.ReadLine();
            Console.Clear();
        }

        static void RightAlign()
        {
            Console.WriteLine("Account Balances");
            string lineOutputFormat = "{0,-15} {1,12:C}";
            Console.WriteLine(lineOutputFormat, "A12345567", 5302.327);
            Console.WriteLine(lineOutputFormat, "A23412345", 27.32);
            Console.WriteLine(lineOutputFormat, "B28274939", 32706.00);
            Console.ReadLine();
            Console.Clear();
        }

        static void GetUserData()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            Console.ForegroundColor = prevColor;
        }
    }
}
