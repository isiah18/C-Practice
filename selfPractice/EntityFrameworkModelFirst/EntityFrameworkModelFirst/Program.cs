using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadSampleData();
            DisplayContacts();
            Console.ReadLine();
        }

        private static void LoadSampleData()
        {
            using (var context = new MyContactsContainer())
            {
                if(context.People.Count() == 0)
            }
        }
    }
}
