using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacePractice.Interface;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun g = new Gun();
            g.Shoot();
            Console.ReadLine();
        }
    }
}
