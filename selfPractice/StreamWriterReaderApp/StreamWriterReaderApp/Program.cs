using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = File.CreateText("reminders.txt"))
            {
                writer.WriteLine("Don't forget Mothers day this year ... ");
                writer.WriteLine("Don't forget Father's day this year ...");
                writer.Write("Don't forget my sister's birthday this year ... ");
                writer.Write(" or to get her Christmas gift");
                writer.Write(" or she will be really mad.");

                for (int i = 0; i < 10; i++)
                {
                    writer.Write(i + " ");
                }
                writer.Write(writer.NewLine);
            }

            Console.WriteLine(" Created a file and wrote some notes.");

            using (StreamReader sr = File.OpenText("reminders.txt"))
            {
                string input = null;
                while((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }

            Console.ReadLine();

        }
    }
}
