using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */
        static void Main()
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            //Exercise05();
            //Exercise06();
            //Exercise07();
            //Exercise08();
            //Exercise09();
            //Exercise10();
            //Exercise11();
            //Exercise12();
            //Exercise13();
            //Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise21();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            //Exercise26();
            //Exercise27();
            //Exercise28();
            //Exercise29();
            //Exercise30();
            //Exercise31();
            //Exercise32();
            //Exercise33();
            //Exercise34();
            //Exercise35();
            //Exercise36();
            //Exercise37();
            //Exercise38();
            //Exercise39();
            //Exercise40();

            Console.ReadLine();
        }

        // 1. Find all products that are out of stock.
        private static void Exercise01()
        {
            List<Product> products = DataLoader.LoadProducts();

            var results = products.Where(p => p.UnitsInStock == 0);

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //2. Find all products that are in stock and cost more than 3.00 per unit.
        public static void Exercise02()
        {
            List<Product> products = DataLoader.LoadProducts();

            var results = products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00M);

            foreach (var r in results)
            {
                Console.WriteLine(r.ProductName);
            }
        }

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        public static void Exercise03()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            var results = customers.Where(c => c.Region == "WA");
            foreach (var r in results)
            {
                Console.WriteLine("Company Name : {0}", r.CompanyName);
                var orders = r.Orders;
                foreach (var o in orders)
                {
                    Console.WriteLine("\tOrder Date : {0}", o.OrderDate);
                    Console.WriteLine("\tOrder ID : {0}", o.OrderID);
                    Console.WriteLine("\tOrder Total : {0}", o.Total);
                }
                Console.WriteLine();
            }
        }

        //4. Create a new sequence with just the names of the products.
        public static void Exercise04()
        {
            List<Product> products = DataLoader.LoadProducts();
            var results = from p in products
                          select p.ProductName;
            
            Console.WriteLine("The Product Names Are : \n");
            foreach (var r in results)
            {
                Console.WriteLine(r);
            }
        }

        //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
        public static void Exercise05()
        {
            List<Product> products = DataLoader.LoadProducts();
            var results = from p in products
                          let UnitPrice = p.UnitPrice + p.UnitPrice * .25M
                          select new {p.ProductName, UnitPrice};

            foreach (var r in results)
            {
                Console.WriteLine("The product is : {0}. \n The increased unit price is : {1}", r.ProductName, r.UnitPrice);
                Console.WriteLine();
            }
        }

        //6. Create a new sequence of just product names in all upper case.
        public static void Exercise06()
        {
            List<Product> products = DataLoader.LoadProducts();
            var results = from p in products
                let PName = p.ProductName.ToUpper()
                select new {PName};
            Console.WriteLine("Product Names in Upper Case : \n\n");
            foreach (var r in results)
            {
                Console.WriteLine(r.PName);
            }
        }

        //7. Create a new sequence with products with even numbers of units in stock.
        public static void Exercise07()
        {
            List<Product> products = DataLoader.LoadProducts();
            var results = products.Where(p => p.UnitsInStock%2 == 0);
            foreach (var r in results)
            {
                Console.WriteLine("Product : {0}\n Units in stock : {1}", r.ProductName, r.UnitsInStock);
                Console.WriteLine();
            }
        }

        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
        public static void Exercise08()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                let Price = p.UnitPrice
                select new {p.ProductName, p.Category, Price};

            foreach (var r in results)
            {
                Console.WriteLine("Product : {0}", r.ProductName);
                Console.WriteLine("Category : {0}", r.Category);
                Console.WriteLine("Price : {0}", r.Price);
            }
        }

        //9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersB
        public static void Exercise09()
        {
            var numbersB = DataLoader.NumbersB;
            var numbersC = DataLoader.NumbersC;

            var resultsB = numbersB.Select((numB, index) =>
                      new { indB = index, numberB = numB });

            var resultsC = numbersC.Select((numC, index) =>
                new {indC = index, numberC = numC});

            var finalResult = from b in resultsB
                from c in resultsC
                where b.indB == c.indC && b.numberB < c.numberC
                select new {b, c};

            Console.WriteLine("Pair where B < C : ");

            foreach (var result in finalResult)
            {
                Console.WriteLine("{0}, {1}", result.b.numberB, result.c.numberC);
            }
        }

        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        public static void Exercise10()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                           from o in c.Orders
                           where o.Total < 500
                           select new {c.CustomerID, o.OrderID, o.Total};

            foreach (var r in results)
            {
                Console.WriteLine("Customer ID : {0}", r.CustomerID);
                Console.WriteLine("Order ID : {0}", r.OrderID);
                Console.WriteLine("Total : {0}\n", r.Total);
            }
        }

        //11. Write a query to take only the first 3 elements from NumbersA.
        public static void Exercise11()
        {
            var numbersA = DataLoader.NumbersA;

            var results = (from num in numbersA
                          select num).Take(3);

            Console.WriteLine("The elements are : ");
            foreach (var r in results)
            {
                Console.WriteLine(r);
            }
        }

        //12. Get only the first 3 orders from customers in Washington.
        public static void Exercise12()
        {
            var customers = DataLoader.LoadCustomers();
            var results = from c in customers
                from order in c.Orders.Take(3)
                where c.Region == "WA"
                select new {c.CompanyName, order};

            foreach (var r in results)
            {
                Console.WriteLine("Customer Name : {0}", r.CompanyName);
                Console.WriteLine("\tOrder ID : {0}", r.order.OrderID);
                Console.WriteLine("\tOrder Date : {0}", r.order.OrderDate);
                Console.WriteLine("\tOrder Total : {0}", r.order.Total);   
            }
        }

        //13. Skip the first 3 elements of NumbersA.
        public static void Exercise13()
        {
            var numbersA = DataLoader.NumbersA;
            var results = numbersA.Skip(3).Select(num => num);
            Console.WriteLine("Skipping the first three numbers ... the rest of NumbersA is : ");
            foreach (var r in results)
            {
                Console.Write(r + ", ");
            }
        }

        //14. Get all except the first two orders from customers in Washington.
        public static void Exercise14()
        {
            var customers = DataLoader.LoadCustomers();
            var results = from cust in customers 
                          where cust.Region == "WA"
                          select new
                          {
                              cust,
                              order = from order in cust.Orders.Skip(2)
                                      select new {order}
                          };
            foreach (var r in results)
            {
                Console.WriteLine(r.cust.CompanyName);
                foreach (var o in r.order)
                {
                    Console.WriteLine("Order ID : {0}", o.order.OrderID);
                    Console.WriteLine("Order Date : {0}", o.order.OrderDate);
                    Console.WriteLine("Order Total : {0}", o.order.Total);
                }
            }
        }

        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        public static void Exercise15()
        {
            var numbersC = DataLoader.NumbersC;
            var results = numbersC.TakeWhile(n => n <= 6);
            foreach (var r in results)
            {
                Console.Write(r + ", ");
            }
        }

        //16. Return elements starting from the beginning of NumbersC 
        //    until a number is hit that is less than its position in the array.
        public static void Exercise16()
        {
            var numbersC = DataLoader.NumbersC;
            var numCIndexes = numbersC.Select(
                (num, index) =>
                new {i = index, number = num}
                );

            var results = numCIndexes.TakeWhile(n => n.number > n.i);
            foreach (var r in results)
            {
                Console.Write(r.number + ", ");
            }
        }

        //17. Return elements from NumbersC starting from the first element divisible by 3.
        public static void Exercise17()
        {
            var numbersCArray = DataLoader.NumbersC;
            var results = numbersCArray.Where(n => n%3 == 0 && n!= 0);
            foreach (var r in results)
            {
                Console.Write(r + ", ");
            }
        }

        //18. Order products alphabetically by name.
        public static void Exercise18()
        {
            var products = DataLoader.LoadProducts();
            var results = products.OrderBy(p => p.ProductName);
            foreach (var r in results)
            {
                Console.WriteLine("Name : {0}", r.ProductName);
                Console.WriteLine("\tID : {0}", r.ProductID);
                Console.WriteLine("\tUnits: {0}", r.UnitsInStock);
            }
        }

        //19. Order products by UnitsInStock descending.
        public static void Exercise19()
        {
            var products = DataLoader.LoadProducts();
            var results = products.OrderByDescending(n => n.UnitsInStock);
            Console.WriteLine(String.Format("{0, -35} {1, 15}", "Name", "Units In Stock"));
            foreach (var r in results)
            {
                Console.WriteLine(String.Format("{0, -35} {1, 7}", r.ProductName, r.UnitsInStock));
            }
        }

        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
        public static void Exercise20()
        {
            var products = DataLoader.LoadProducts();
            var results = products.OrderBy(n => n.UnitPrice).GroupBy(prod => prod.Category);

            foreach (var r in results)
            {
                Console.WriteLine("Category : {0}", r.Key);
                foreach (var cat in r)
                {
                    Console.WriteLine("\tName : {0}", cat.ProductName);
                    Console.WriteLine("\t\tPrice : {0}", cat.UnitPrice);
                }
            }
        }

        //21. Reverse NumbersC.
        public static void Exercise21()
        {
            var numberCArray = DataLoader.NumbersC;
            var results = numberCArray.Reverse();
            Console.Write("[");
            foreach (var r in results)
            { 
                Console.Write(" {0} ", r);
            }
            Console.Write("]");
        }

        //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
        public static void Exercise22()
        {
            var numberCArray = DataLoader.NumbersC;
            var results = numberCArray.Select(n => n).GroupBy(n => n%5);

            foreach (var r in results)
            {
                Console.WriteLine("\nThe amount of {0} remainders : ",r.Key);
                foreach (var remainders in r)
                {
                    Console.Write("{0}, ",remainders);
                }
            }
        }

        //23. Display products by Category.
        public static void Exercise23()
        {
            var products = DataLoader.LoadProducts();
            var results = products.GroupBy(prod => prod.Category);//.Select(prod => prod);

            foreach (var r in results)
            {
                Console.WriteLine(r.Key);
                foreach (var product in r)
                {
                    Console.WriteLine("Product Name : {0}", product.ProductName);
                }
            }
        }

        //24. Group customer orders by year, then by month.
        public static void Exercise24()
        {
            var customers = DataLoader.LoadCustomers();
            var results = from c in customers
                from o in c.Orders
                group o by new {o.OrderDate.Year, o.OrderDate.Month}
                into groupedOrders
                select new {groupedOrders};

            foreach (var r in results)
            {
                foreach (var g in r.groupedOrders)
                {
                    Console.WriteLine(g.OrderDate);
                }
                
            }
        }

        //25. Create a list of unique product category names.
        public static void Exercise25()
        {
            var products = DataLoader.LoadProducts();
            var results = (products.GroupBy(prod => prod.Category)).ToList();

            foreach (var r in results)
            {
                Console.WriteLine("{0} ", r.Key);
            }
        }

        //26. Get a list of unique values from NumbersA and NumbersB.
        public static void Exercise26()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;
            var results = (numbersA.Concat(numbersB).Distinct()).ToList();

            foreach (var r in results)
            {
                Console.Write("{0} ", r);
            }
        }

        //27. Get a list of the shared values from NumbersA and NumbersB.
        public static void Exercise27()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;
            var results = (numbersA.Intersect(numbersB)).ToList();
            foreach (var r in results)
            {
                Console.Write("{0} ", r);
            }
        }

        //28. Get a list of values in NumbersA that are not also in NumbersB.
        public static void Exercise28()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;
            var results = (numbersA.Where(n => !numbersB.Contains(n))).ToList();

            foreach (var r in results)
            {
                Console.Write("{0} ", r);   
            }
        }

        //29. Select only the first product with ProductID = 12 (not a list).
        public static void Exercise29()
        {
            var products = DataLoader.LoadProducts();
            var results = products.Where(n => n.ProductID == 12);

            foreach (var r in results)
            {
                Console.WriteLine("Name : {0} \n ID : {1}", r.ProductName, r.ProductID);
            }
        }

        //30. Write code to check if ProductID 789 exists.
        public static void Exercise30()
        {
            var products = DataLoader.LoadProducts();
            var results = products.Select(p => p.ProductID).Contains(789);

            Console.WriteLine(results);
        }

        //31. Get a list of categories that have at least one product out of stock.
        public static void Exercise31()
        {
            var products = DataLoader.LoadProducts();
            var results = (products.Where(p => p.UnitsInStock == 0).GroupBy(pro => pro.Category)).ToList();
            foreach (var r in results)
            {
                Console.WriteLine("{0}  ", r.Key);
            }
        }

        //32. Determine if NumbersB contains only numbers less than 9.
        public static void Exercise32()
        {
            var numbersB = DataLoader.NumbersB;
            var results = numbersB.Any(n => n > 9);
            Console.WriteLine(!results);
        }

        //33. Get a grouped list of products only for categories that have all of their products in stock.
        public static void Exercise33()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                group p by p.Category
                into g
                where g.All(x => x.UnitsInStock > 0)
                select g;

            foreach (var r in results)
            {
                Console.WriteLine(r.Key);
                foreach (var p in r)
                {
                    Console.WriteLine(p.UnitsInStock);
                }
            }
        }


        //34. Count the number of odds in NumbersA.
        public static void Exercise34()
        {
            var numbersA = DataLoader.NumbersA;
            var results = numbersA.Where(n => n%2 != 0).Count();
            Console.WriteLine(results);
        }

        //35. Display a list of CustomerIDs and only the count of their orders.
        public static void Exercise35()
        {
            var customers= DataLoader.LoadCustomers();
            var results = from c in customers
                          select new
                          {
                              Id = c.CustomerID,
                              Name = c.CompanyName,
                              countOrders = c.Orders.Count()
                          };

            foreach (var r in results)
            {
                Console.WriteLine(r.Name);
                Console.WriteLine(r.Id);
                Console.WriteLine(r.countOrders);
            }
        }


        //36. Display a list of categories and the count of their products.
        public static void Exercise36()
        {
            var products = DataLoader.LoadProducts();
            var results = products.GroupBy(p => p.Category);

            foreach (var r in results)
            {
                Console.WriteLine("{0, -20} -- {1, 10}", r.Key, r.Key.Count());
            }
        }


        //37. Display the total units in stock for each category.
        public static void Exercise37()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          group p by p.Category into cat
                          select new
                          {
                              category = cat.Key,
                              totalUnits = cat.Sum(product => product.UnitsInStock)
                          };

            foreach (var r in results)
            {
                Console.WriteLine(r.category);
                Console.WriteLine(r.totalUnits);
            }

        }


        //38. Display the lowest priced product in each category.
        public static void Exercise38()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          group p by p.Category into cat
                          select new
                          {
                              category = cat.Key,
                              lowestPrice = cat.Min(product => product.UnitPrice)
                          };

            foreach (var r in results)
            {
                Console.WriteLine(r.category);
                Console.WriteLine(r.lowestPrice);
            }
        }

        //39. Display the highest priced product in each category.
        public static void Exercise39()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          group p by p.Category into cat
                          select new
                          {
                              category = cat.Key,
                              highestPrice = cat.Max(product => product.UnitPrice)
                          };

            foreach (var r in results)
            {
                Console.WriteLine(r.category);
                Console.WriteLine(r.highestPrice);
            }
        }


        //40. Show the average price of product for each category.
        public static void Exercise40()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          group p by p.Category into cat
                          select new
                          {
                              category = cat.Key,
                              averagePrice = cat.Average(product => product.UnitPrice)
                          };

            foreach (var r in results)
            {
               Console.WriteLine(r.category);
               Console.WriteLine(r.averagePrice);
            }
        }

    }
}
