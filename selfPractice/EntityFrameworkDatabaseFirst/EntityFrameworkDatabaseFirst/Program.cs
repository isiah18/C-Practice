using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetUSACustomers();
            RegionAdder();
            Console.ReadLine();
        }

        private static void RegionAdder()
        {
            Console.WriteLine("Creating region test");

            using (var context = new NorthwindEntities())
            {
                Region r = new Region();
                r.RegionDescription = "Test Region";

                context.Regions.Add(r);
                context.SaveChanges();

                Console.WriteLine("New RegionID: {0}", r.RegionID);
                Console.WriteLine("Check Database");
                Console.ReadLine();

                r.RegionDescription = "Test2";
                context.SaveChanges();

                Console.WriteLine("Check Database");
                Console.ReadLine();

                Console.WriteLine("Delete the new record");
                context.Regions.Remove(r);
                context.SaveChanges();

                Console.WriteLine("Check Database");
                Console.ReadLine();
            }
        }

        private static void GetUSACustomers()
        {
            using (var context = new NorthwindEntities())
            {
                var usaCustomers = context.Customers.Where(c => c.Country == "USA");

                foreach (var customer in usaCustomers)
                {
                    Console.WriteLine("{0,-35} {1} {2}", customer.CompanyName, customer.Phone, customer.Country);
                }
            }
        }
    }
}
