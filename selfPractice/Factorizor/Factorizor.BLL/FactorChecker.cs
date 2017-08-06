using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.Models;

namespace Factorizor.BLL
{
    public class FactorChecker
    {
        public FactorResult CheckFactors(int number)
        {
            FactorResult result = new FactorResult();

            result.Number = number;
            result.Factors = GetFactors(number);
            result.IsPerfect = CheckPerfect(result);
            result.IsPrime = result.Factors.Count == 1;

            return result;
        }

        public bool CheckPerfect(FactorResult result)
        {
            int sum = 0;
            foreach (int num in result.Factors)
            {
                sum += num;
            }
            return sum == result.Number;
        }

        public List<int> GetFactors(int number)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < number; i++)
            {
                if (number%i == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
