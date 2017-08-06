using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer1 = new Printer();
            printer1.Print();
            printer1.Name = "NotDefaultAnymore";
            printer1.Print();
            var printer2 = new Printer(10);
            printer2.Name = "Dave";
            var printer3 = new Printer(100, "Epson");

            printer1.Print();
            printer2.Print();
            printer3.Print();

            Console.ReadLine();
        }
    }
}
