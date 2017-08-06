using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeLab.BLL;

namespace DateTimeLab.UI
{
    public class Game
    {
        ValidInput validInfo = new ValidInput();
        FirstWednesday getWed = new FirstWednesday();
        Adder addSevenToDate = new Adder();
        DateTime date = new DateTime();
        DateTime firstWed = new DateTime();
        int NumberOfWednesdays;


        public void StartGame()
        {
            GetDateFromUser();

            date = validInfo.getDateInput();

            firstWed = getWed.getFirstWednesday(date);

            GetNumberFromUser();

            NumberOfWednesdays = validInfo.getNumWednesdays();

            PrintWednesdays();

        }

        public void GetDateFromUser()
        {
            bool isValidDate;
            do
            {
                Console.Write("Please enter a date : ");
                string input = Console.ReadLine();

                isValidDate = validInfo.checkDate(input);

                if (isValidDate == false)
                {
                    Console.WriteLine("You entered an invalid input. Press Enter to try again.");
                    Console.ReadLine();
                }
            } while (isValidDate == false);
        }

        public void GetNumberFromUser()
        {
            bool isValidNum;
            do
            {
                Console.Write("Enter number of Wednesdays starting from {0} : ", date.ToString("d"));
                string numInput = Console.ReadLine();

                isValidNum = validInfo.getAValidNumber(numInput);

                if (isValidNum == false)
                {
                    Console.WriteLine("Sorry, that is an invalid input. Press Enter to try again.");
                    Console.ReadLine();
                }
            } while (isValidNum == false);
        }

        public void PrintWednesdays()
        {
            Console.WriteLine("The date you entered is : {0}, this is a {1}", date.ToString("d"), date.DayOfWeek);
            Console.WriteLine("The number you picked was {0}\n", NumberOfWednesdays);

            for (int i = 0; i < NumberOfWednesdays; i++)
            {
                Console.WriteLine("Wednesday - Date is - {0}", firstWed.ToString("d"));
                firstWed = addSevenToDate.addSeven(firstWed);
            }
            Console.ReadLine();
        }
    }
}
