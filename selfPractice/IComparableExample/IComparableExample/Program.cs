using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new int[] {5, 3, 17, 4};

            Array.Sort(ints);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            var temps = new Temperature[]
            {
                new Temperature() {Fahrenheit = 32},
                new Temperature() {Fahrenheit = 212},
                new Temperature() {Fahrenheit = 100},
                new Temperature() {Fahrenheit = 50}
            };

            Array.Sort(temps);

            foreach (var temp in temps)
            {
                Console.WriteLine(temp.Fahrenheit);
            }


            Console.ReadLine();

        }
    }
}
