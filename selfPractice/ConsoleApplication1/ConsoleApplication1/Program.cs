using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUSACustomers();
            Console.ReadLine();
        }

        private static void GetUSACustomers()
        {
            using (var context = new NorthwindEntities())
            {
                var usaCustomemrs = context.Customers.Where(c => c.Country == "USA");

                foreach (var customer in usaCustomemrs)
                {
                    Console.WriteLine("{0, -35} {1} {2}", customer.CompanyName, customer.Phone, customer.Country);
                }
            }
        }
    }
}
