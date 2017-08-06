using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Fizz Buzz Problem *********");
            Console.WriteLine("Enter any key to start.");
            Console.ReadKey();
            for (int i = 1; i < 101; i++)
            {
                if (i%3 == 0 && i%5 ==0)
                {
                    Console.Write(i);
                    Console.WriteLine(" FizzBuzz");
                }
                else if (i%5 == 0)
                {
                    Console.Write(i);
                    Console.WriteLine(" Buzz");
                }
                else if (i%3 == 0)
                {
                    Console.Write(i);
                    Console.WriteLine(" Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Enter any key to quit.");
            Console.ReadKey();
        }
    }
}
