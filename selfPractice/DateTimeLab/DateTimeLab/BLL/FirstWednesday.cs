using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab.BLL
{
    public class FirstWednesday
    {
        public DateTime getFirstWednesday(DateTime dateInput)
        {
            //Set up variable to store the firstWednesday from inputed date
            DateTime firstWednesday = new DateTime();
            //Get the day of week for the inputed date
            DayOfWeek day = dateInput.DayOfWeek;

            switch (day)
            {
                case DayOfWeek.Thursday:
                    firstWednesday = dateInput.AddDays(6);
                    break;
                case DayOfWeek.Friday:
                    firstWednesday = dateInput.AddDays(5);
                    break;
                case DayOfWeek.Saturday:
                    firstWednesday = dateInput.AddDays(4);
                    break;
                case DayOfWeek.Sunday:
                    firstWednesday = dateInput.AddDays(3);
                    break;
                case DayOfWeek.Monday:
                    firstWednesday = dateInput.AddDays(2);
                    break;
                case DayOfWeek.Tuesday:
                    firstWednesday = dateInput.AddDays(1);
                    break;
                default:
                    firstWednesday = dateInput;
                    break;
            }
            return firstWednesday;
        }
    }
}
