using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() {LastName = "Sandler", Major = "Computer Science"},
                new Student() {LastName = "Martin", Major = "History"},
                new Student() {LastName = "Chase", Major = "English"},
                new Student() {LastName = "Murphy", Major = "Computer Science"},
                new Student() {LastName = "Pacino", Major = "History"}
            };

            var result = from student in students
                    group student by student.Major;

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t{0}", student.LastName);
                }
            }

            Console.ReadLine();
        }
    }
}
