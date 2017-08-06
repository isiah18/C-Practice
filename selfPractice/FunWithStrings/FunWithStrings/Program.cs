using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Fun With Strings ***************");
            //BasicStringFunctionality();
            //StringConcatenation();
            //EscapeChars();
            //VerbatimStrings();
            StringBuilderDemo();

            Console.ReadLine();
        }

        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder("Some Harrison Ford Movies are ");
            sb.Append("\nStar Wars");
            sb.Append("\nRaiders of the Lost Ark");
            sb.Append("\nAir Force One");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
            Console.Clear();
        }

        static void VerbatimStrings()
        {
            Console.WriteLine(@"C:\MyApp\bin\Debug\");

            string myLongString = @"This is a very
                very
                    very
                        very
                            long string!";

            Console.WriteLine(myLongString);

            Console.WriteLine(@"I said ""I don't like double quotes""");

            Console.ReadLine();
            Console.Clear();
        }

        static void EscapeChars()
        {
            string strWithTabs = "Model\tColor\tSpeed\tPet Name";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\\");

            Console.WriteLine("All Finished\n\n\n\aHa!");

            Console.ReadLine();
            Console.Clear();
        }

        static void StringConcatenation()
        {
            string s1 = "This is ";
            string s2 = "really fun!";
            string s3 = String.Concat(s1, s2);
            //string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.ReadLine();
            Console.Clear();
        }

        static void BasicStringFunctionality()
        {
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y? {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.ReadLine();
            Console.Clear();

        }
    }
}
