﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalADOExamples.DATA.Config;
using AdditionalADOExamples.DATA.Models;

namespace AdditionalADOExamples.DATA.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT e1.EmployeeID, e1.FirstName, e1.LastName, " +
                                  "e1.Title, e1.BirthDate, e2.FirstName as ManagerFirstName, " +
                                  "e2.LastName as ManagerLastName, e1.ReportsTo " +
                                  "FROM Employees e1 " +
                                  "LEFT JOIN Employees e2 " +
                                  "ON e1.ReportsTo = e2.EmployeeID; ";
                cmd.Connection = cn;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        employees.Add(PopulateFromDataReader(dr));
                    }
                }
            }

            return employees;
        }

        public Employee GetByIdStoredProc(int empId)
        {
            Employee employee = new Employee();

            using (var cn = new SqlConnection(Settings.ConnectionString))
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "EmployeesGetByID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@EmployeeID", empId);

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        employee = PopulateFromDataReader(dr);
                    }
                }
            }
            return employee;
        }

        public Employee GetById(int empId)
        {
            Employee employee = new Employee();

            using (var cn = new SqlConnection(Settings.ConnectionString))
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "SELECT e1.EmployeeID, e1.FirstName, e1.LastName, " +
                                  "e1.Title, e1.BirthDate, e2.FirstName as ManagerFirstName, " +
                                  "e2.LastName as ManagerLastName, e1.ReportsTo " +
                                  "FROM Employees e1 " +
                                  "LEFT JOIN Employees e2 " +
                                  "ON e1.ReportsTo = e2.EmployeeID  " +
                                  "WHERE e1.EmployeeID = @EmployeeID";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@EmployeeID", empId);

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        employee = PopulateFromDataReader(dr);
                    }
                }
            }
            return employee;
        }

        private Employee PopulateFromDataReader(SqlDataReader dr)
        {
            Employee employee = new Employee();

            employee.EmployeeId = (int) dr["EmployeeID"];
            employee.LastName = dr["LastName"].ToString();
            employee.FirstName = dr["FirstName"].ToString();
            employee.Title = dr["Title"].ToString();
            if (dr["BirthDate"] != DBNull.Value)
                employee.BirthDate = (DateTime) dr["Birthdate"];

            if (dr["ReportsTo"] != DBNull.Value)
            {
                employee.ReportsTo = (int) dr["ReportsTo"];
                employee.ManagerName = string.Format("{0} {1}",
                    dr["ManagerFirstName"].ToString(),
                    dr["ManagerLastName"].ToString());
            }
             
            return employee;
        }
    }
}
