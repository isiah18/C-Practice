using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsV1.Models;

namespace ContactsV1.Operations
{
    public class ContactPrinter
    {
        public void PrintList(List<Contact> contacts)
        {
            Console.Clear();
            Console.WriteLine("Contacts List");
            Console.WriteLine("-----------------------------------");
            if (contacts.Count == 0)
            {
                Console.WriteLine("You have no fiends...  so sad!");
            }
            else
            {
                foreach (var c in contacts)
                {
                    Console.WriteLine("{0}, {1} {2}", c.LastName, c.FirstName, c.PhoneNumber);
                }
            }


            Console.WriteLine("\n\nPress any key to continue... ");
            Console.ReadKey();
        }

    }
}
