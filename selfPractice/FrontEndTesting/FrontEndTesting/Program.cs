using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n");

            Console.Write("‗");
            for (int k = 0; k < 10; k++)
            {
                
                Console.Write("‗‗‗‗‗‗");
            }
            Console.WriteLine();
            Console.WriteLine("║     ║     ║     ║     ║     ║     ║     ║     ║     ║     ║");
               
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("║‗‗‗‗‗");
                }
                Console.WriteLine("║");
                Console.WriteLine("║     ║     ║     ║     ║     ║     ║     ║     ║     ║     ║");
            }
            Console.Write("║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║‗‗‗‗‗║");

            Console.ReadLine();
        }
    }
}
