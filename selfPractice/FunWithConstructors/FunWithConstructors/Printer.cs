using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructors
{
    public class Printer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Printer()
        {
            ID = 28;
            Name = "Default";
        }

        public Printer(int id)
        {
            ID = id;
            //Name = "Default";
        }

        public Printer(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("{0} : {1}", ID, Name);
        }

    }
}
