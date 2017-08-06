using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = MakePeople();

            var ladies = from p in people
                where p.Gender == 'F'
                //select p;
                select new {Name = p.LastName + ", " + p.FirstName, p.Age};

                     Console.WriteLine("The type of ladies is {0}", ladies.ToString());

            foreach (var l in ladies)
            {
                Console.WriteLine("{0,-15} {1:D2}", l.Name, l.Age);
            }

            Console.ReadLine();
        }

        static List<Person> MakePeople()
        {
            return new List<Person>()
            {
                new Person() {FirstName = "Homer", LastName = "Simpson", Age = 40, Gender = 'M'},
                new Person() {FirstName = "Marge", LastName = "Simpson", Age = 36, Gender = 'F'},
                new Person() {FirstName = "Lisa", LastName = "Simpson", Age = 10, Gender = 'F'},
                new Person() {FirstName = "Bart", LastName = "Simpson", Age = 12, Gender = 'M'},
                new Person() {FirstName = "Maggie", LastName = "Simpson", Age = 1, Gender = 'F'}
            };
        } 
    }
}
