using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Length < 1)
            {
                return 0;
            }

            string[] array = numbers.Split(',');

            return SumNumberStrings(array);

        }

        private static int SumNumberStrings(string[] array)
        {
            int result = 0;
            foreach (string element in array)
            {
                result += int.Parse(element);
            }
            return result;
        }
    }
}
