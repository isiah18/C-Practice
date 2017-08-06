using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoins
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student {LastName = "Wise", StudentID = 1},
                new Student {LastName = "Ward", StudentID = 2}
            };

            List<StudentCourse> courses = new List<StudentCourse>()
            {
                new StudentCourse {StudentID = 1, CourseName = "C# Fundamentals"},
                new StudentCourse {StudentID = 1, CourseName = "Asp.Net Fundamentals"},
                new StudentCourse {StudentID = 2, CourseName = "Java Fundamentals"},
                new StudentCourse {StudentID = 2, CourseName = "CSS Fundamentals"}
            };

            var results = from student in students
                join course in courses
                    on student.StudentID equals course.StudentID
                select new {course, student};

            Console.WriteLine("Student Courses");
            foreach (var result in results)
            {
                Console.WriteLine("{0,-10} {1}",result.student.LastName,result.course.CourseName);
            }

            Console.ReadLine();

        }
    }
}
