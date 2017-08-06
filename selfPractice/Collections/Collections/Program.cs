using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowArrayList();
            //ShowHashTable();

            //ShowGenericList();
            ShowGenericDictionary();
        }

        private static void ShowGenericDictionary()
        {
            Dictionary<int,Person> dictionary = new Dictionary<int, Person>();

            Person p1 = new Person() { FirstName = "Homer", LastName = "Simpson", PersonId = 1 };
            Person p2 = new Person() { FirstName = "Marge", LastName = "Simpson", PersonId = 2 };
            Person p3 = new Person() { FirstName = "Lisa", LastName = "Simpson", PersonId = 3 };
            Person p4 = new Person() { FirstName = "Bart", LastName = "Simpson", PersonId = 4 };

            dictionary.Add(p1.PersonId, p1);
            dictionary.Add(p2.PersonId, p2);
            dictionary.Add(p3.PersonId, p3);
            dictionary.Add(p4.PersonId, p4);

            foreach (var key in dictionary.Keys)
            {
                PrintPerson(dictionary[key]);
            }
            Console.ReadLine();
        }

        private static void PrintPerson(Person p)
        {
            Console.WriteLine("{0} {1} {2}", p.PersonId, p.FirstName, p.LastName);
        }

        private static void ShowGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "Dave", LastName = "Balzer", Age = 21},
                new Person {FirstName = "Fred", LastName = "Flinstone", Age = 2300}
            };

            foreach (var p in people)
            {
                Console.WriteLine("{0}, {1} is {2} years old.", p.LastName, p.FirstName, p.Age);
            }

            Console.WriteLine("\nEnter a first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("\nEnter a last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("\nEnter a age: ");
            string age = Console.ReadLine();

            Person p1 = new Person();
            p1.FirstName = firstName;
            p1.LastName = lastName;
            p1.Age = int.Parse(age);

            people.Add(p1);

            foreach (var p in people)
            {
                Console.WriteLine("{0}, {1} is {2} years old.", p.LastName, p.FirstName, p.Age);
            }
            Console.ReadLine();
            
        }

        private static void ShowHashTable()
        {
            Hashtable applicationMap = new Hashtable();

            applicationMap.Add("txt", "notepad.exe");
            applicationMap.Add("bmp", "paint.exe");
            applicationMap.Add("jpg", "paint.exe");
            applicationMap.Add("docx", "word.exe");

            Console.WriteLine("Enter a file extension: ");
            string extension = Console.ReadLine();

            Console.WriteLine("We would open extension {0} with {1}", extension, applicationMap[extension]);

            Console.WriteLine("Enter a new extension: ");
            extension = Console.ReadLine();

            Console.WriteLine("Enter a new application: ");
            string application = Console.ReadLine();

            if (applicationMap.ContainsKey(extension))
            {
                Console.WriteLine("That key already exists!");
            }
            else
            {
                applicationMap.Add(extension, application);
            }

            foreach (var key in applicationMap.Values)
            {
                Console.WriteLine("{0} = {1}", key, applicationMap[key]);
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static void ShowArrayList()
        {
            ArrayList intList = new ArrayList();

            intList.Add(1);
            intList.Add(5);
            intList.Add(10);
            intList.Add(8);

            int sum = 0;

            foreach (object o in intList)
            {
                sum += (int)o;
            }

            Console.WriteLine("The sum of the arraylist is {0}", sum);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
