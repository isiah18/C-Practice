using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,2);

            Console.WriteLine(p1.ToString());

            Point p2 = new Point(1,2);

            Console.WriteLine(p2.ToString());

            Console.WriteLine(Object.Equals(p1,p2));

            Console.ReadLine();
        }
    }
}
