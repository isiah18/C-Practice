using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] myTasks =
                {
                    "Fix Sink", "Call Wife", "Play Games", "Sleep"
                };

                File.WriteAllLines(@".\tasks.txt", myTasks);

                foreach (string task in File.ReadAllLines(@".\tasks.txt"))
                {
                    Console.WriteLine("TODO: {0}", task);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
