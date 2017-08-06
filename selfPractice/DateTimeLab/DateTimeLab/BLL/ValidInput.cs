using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab.BLL
{
    public class ValidInput
    {
        DateTime dateInput = new DateTime();
        int numWednesdays;

        public bool checkDate(string input)
        {
            bool isValidDate;

            isValidDate = DateTime.TryParse(input, out dateInput);
            return isValidDate;
        }

        public DateTime getDateInput()
        {
            return dateInput;
        }

        public bool getAValidNumber(string numInput)
        {
            bool isValidNum;
          
            isValidNum = int.TryParse(numInput, out numWednesdays);
            return isValidNum;
        }

        public int getNumWednesdays()
        {
            return numWednesdays;
        }
    }
}
