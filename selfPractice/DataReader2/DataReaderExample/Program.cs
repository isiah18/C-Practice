using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace DataReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayEmployeeList();
            Console.ReadLine();
        }

        private static void DisplayEmployeeList()
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["Northwind"]
                .ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select * FROM Employees";
                    cmd.Connection = cn;

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine("{0} {1}, {2}",
                                dr["EmployeeID"].ToString(),
                                dr["LastName"].ToString(),
                                dr["FirstName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
               Console.WriteLine(ex.Message);
                Console.WriteLine("Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
