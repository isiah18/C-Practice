using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //Console.WriteLine(s.Draw());

            Shape[] myShapes = new Shape[6];
            myShapes[0] = new Shape();
            myShapes[1] = new Square();
            myShapes[2] = new Trangle();
            myShapes[3] = new Diamond();
            myShapes[4] = new Circle() {Radius = 10};
            myShapes[5] = new MySquare();
            foreach (Shape s in myShapes)
            {
                Console.WriteLine("-----");
                if (s is Circle)
                {
                    Console.WriteLine("The radius is {0}", ((Circle)s).Radius);
                }
                if (s is Square)
                {
                    Console.WriteLine("{0}", ((Square)s).SaySomething());
                }
                if (s is MySquare)
                {
                    Console.WriteLine("{0}", ((MySquare)s).SaySomething());
                }
                Console.WriteLine(s.Draw());
            }

            Console.ReadLine();

        }
    }
}
