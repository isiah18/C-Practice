using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.StringInReverse();
            Console.WriteLine("\nPress Enter to play the next game.");
            Console.ReadLine();
            p.CountDieRolls();
        }

        public void CountDieRolls()
        {
            int rollNumbers;
            bool isValid;
            do
            {
                Console.Write("Enter how many times you would like to roll the dice : ");
                string input = Console.ReadLine();

                isValid = int.TryParse(input, out rollNumbers);

                if (isValid == false)
                {
                    Console.WriteLine("You entered invalid input. Press ENTER to try again.");
                    Console.ReadLine();
                }
            } while (isValid == false);

            int[] dieNumbers = new int[6];
            Random r = new Random();

            for (int i = 0; i < rollNumbers; i++)
            {
                int num;
                num = r.Next(1, 7);
                dieNumbers[num - 1] += 1;
            }

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("{0} was rolled {1} times.", i, dieNumbers[i - 1]);
            }
            Console.ReadLine();
        }

        public void StringInReverse()
        {
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("The string in reverse order : {0}",new string(charArray));
        }
    }
}
