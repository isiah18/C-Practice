using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.BLL;
using Factorizor.Models;

namespace Factorizor.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            FactorChecker checker = new FactorChecker();
            FactorResult result = checker.CheckFactors(number);

            PrintResults(result);
            Console.ReadLine();
        }

        private static void PrintResults(FactorResult result)
        {
            Console.Clear();
            Console.WriteLine("****** Factorizor Results ********");
            Console.WriteLine("\n\nThe factors of {0} are:", result.Number);
            foreach (int num in result.Factors)
            {
                Console.WriteLine("{0}",num);
            }
            Console.WriteLine("\nPerfect: {0}",result.IsPerfect);
            Console.WriteLine("\nPrime: {0}", result.IsPrime);
        }
    }
}
