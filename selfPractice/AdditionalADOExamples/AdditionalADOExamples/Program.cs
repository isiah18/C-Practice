using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalADOExamples.DATA.Models;
using AdditionalADOExamples.DATA.Repositories;

namespace AdditionalADOExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowAllEmployees();
            //LoadSingleEmployee();
            LoadSingleEmployeeStoredProc();
            Console.ReadLine();
        }

        private static void LoadSingleEmployeeStoredProc()
        {
            EmployeeRepository repo = new EmployeeRepository();
            Employee e = repo.GetByIdStoredProc(5);

            Console.WriteLine("{0} {1, -20} {2} {3:d}",
                    e.EmployeeId, e.LastName + ", " + e.FirstName,
                    e.Title, e.BirthDate);
            if (e.ReportsTo.HasValue)
                Console.WriteLine("\tReports to: {0}", e.ManagerName);
            Console.WriteLine();
        }

        private static void LoadSingleEmployee()
        {
            EmployeeRepository repo = new EmployeeRepository();
            Employee e = repo.GetById(5);

            Console.WriteLine("{0} {1, -20} {2} {3:d}",
                    e.EmployeeId, e.LastName + ", " + e.FirstName,
                    e.Title, e.BirthDate);
            if (e.ReportsTo.HasValue)
                Console.WriteLine("\tReports to: {0}", e.ManagerName);
            Console.WriteLine();
        }

        private static void ShowAllEmployees()
        {
            EmployeeRepository repo = new EmployeeRepository();

            foreach (Employee e in repo.GetAll())
            {
                Console.WriteLine("{0} {1, -20} {2} {3:d}",
                    e.EmployeeId, e.LastName + ", " + e.FirstName,
                    e.Title, e.BirthDate);
                if (e.ReportsTo.HasValue)
                    Console.WriteLine("\tReports to: {0}", e.ManagerName);
                Console.WriteLine();
            }
        }
    }
}
