using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessingAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {0, "Hey"},
                {1, "Isiah"},
                {2, "What"},
                {3, "You"},
                {4, "Doing?"}
            };

            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine(dict[i]);
            }
            Console.ReadLine();
        }
    }
}
