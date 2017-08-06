using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NUnit.Framework;

namespace DapperSample
{
    [TestFixture]
    public class Queries
    {
        [Test]
        public void RunsSelectQuery()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var employees = cn.Query<Employee>("SELECT * FROM Employees").ToList();

                Assert.AreEqual(9, employees.Count);
            }
        }

        [Test]
        public void RunQueryWithInlineParameters()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var employees = cn.Query<Employee>("Select * from employees where EmployeeId > @EmployeeId",
                    new {EmployeeId = 5}).ToList();
        
                Assert.AreEqual(4, employees.Count);
            }
        }

        [Test]
        public void RunQueryWithParameters()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("EmployeeId", 5);
                var employees = cn.Query<Employee>("Select * from employees where employeeid > @EmployeeId",
                    p);

                Assert.AreEqual(4, employees.Count());
            }
        }

        [Test]
        public void GetJustOneRecord()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("EmployeeId", 5);
                var employee =
                    cn.Query<Employee>("select * from employees where employeeid = @EmployeeId", p).FirstOrDefault();

                Assert.IsNotNull(employee);
            }
        }

        [Test]
        public void NotFoundReturnsNull()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("EmployeeId", 25);
                var employee =
                    cn.Query<Employee>("select * from employees where employeeid = @EmployeeId", p).FirstOrDefault();

                Assert.IsNull(employee);
            }
        }

        [Test]
        public void CanExecuteStoredProcedure()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var employees = cn.Query<Employee>("EmployeeGetAll", commandType: CommandType.StoredProcedure).ToList();

                Assert.AreEqual(9, employees.Count);
            }
        }

        [Test]
        public void CanRetrieveOutputParameter()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("RegionDescription", "Midwest Region");
                p.Add("RegionId", DbType.Int32, direction: ParameterDirection.Output);

                cn.Execute("RegionInsert", p, commandType: CommandType.StoredProcedure);

                int regionId = p.Get<int>("RegionId");

                Assert.AreNotEqual(0, regionId);
            }
        }

        [Test]
        public void CanBindComplexObjects()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var customers = cn.Query<Customer>("Select * from Customers").ToList();

                foreach (var cust in customers)
                {
                    var p = new DynamicParameters();
                    p.Add("CustomerId", cust.CustomerID);
                    cust.Orders = cn.Query<Order>("Select * from Orders where CustomerID = @CustomerId", p).ToList();
                }

                Assert.AreEqual(91, customers.Count);
                Assert.AreEqual(6, customers[0].Orders.Count);
            }
        }
    }
}
