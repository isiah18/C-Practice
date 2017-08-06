using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemonstrateValueType();
            DemonstrateReferenceType();
        }

        static void DemonstrateValueType()
        {
            int x = 5;
            ManipulateInt(x);
            Console.WriteLine("The value of x is {0}", x);
            
            Console.ReadLine();
        }

        static void ManipulateInt(int x)
        {
            x = 10;
        }

        static void DemonstrateReferenceType()
        {
            Person myPerson = new Person();
            myPerson.Name = "Sam";
            ManipulatePerson(myPerson);
            Console.WriteLine("The person's name is: {0}", myPerson.Name);
            Console.ReadLine();
        }

        static void ManipulatePerson(Person myPerson)
        {
            myPerson.Name = "Joe";
        }

    }

    class Person
    {
        public string Name;
    }
}
