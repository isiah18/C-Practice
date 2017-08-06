using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Loops
    {
        public string StringTimes(string str, int n)
        {
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                answer.Append(str);
            }
            return answer.ToString();
        }

        public string FrontTimes(string str, int n)
        {
            StringBuilder answer = new StringBuilder();
            string front3 = (str.Length < 3) ? str : str.Substring(0, 3);
            for (int i = 0; i < n; i++)
            {
                answer.Append(front3);
            }
            return answer.ToString();
        }

        public int CountXX(string str)
        {
            int count = 0;
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].ToString() == "x")
                    count ++;
            }
            return count - 1;
        }

        public bool DoubleX(string str)
        {
            //int firstXIndex = str.IndexOf("x");
            //return (str[firstXIndex + 1].ToString() == "x") ? true : false;
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].ToString() == "x")
                {
                    if (charArray[i + 1].ToString() == "x")
                    {
                        return true;
                    }
                    return false;
                    break;
                }
            }
            return false;
        }

        public string EveryOther(string str)
        {
            StringBuilder answer = new StringBuilder();
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i%2 == 0)
                {
                    answer.Append(charArray[i]);
                }
            }
            return answer.ToString();
        }

        public string StringSplosion(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < str.Length + 1; i++)
            {
                sb.Append(str.Substring(0, i));
            }
            return sb.ToString();
        }

        public int CountLast2(string str)
        {
            int count = 0;
            string lookFor = str.Substring(str.Length - 2, 2);
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length - 1; i ++ )
            {
                if (charArray[i] == lookFor[0] && charArray[i+1] == lookFor[1])
                {
                    count++;
                }
            }
            return count - 1;
        }

        public int Count9(int[] numbers)
        {
            int count = 0;
            foreach (int element in numbers)
            {
                if (element == 9)
                {
                    count++;
                }
            }
            return count;
        }

        public bool ArrayFront9(int[] numbers)
        {
            if (numbers.Length < 4)
            {
                foreach (int element in numbers)
                {
                    if (element == 9)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (numbers[i] == 9)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool Array123(int[] numbers)
        {
            for(int i = 0; i<numbers.Length - 1; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            string shorter = (a.Length <= b.Length) ? a : b;
            if (shorter.Length < 2)
            {
                if (a[0] == b[0])
                    count++;
            }
            for (int i = 0; i < shorter.Length - 1; i++)
            {
                if (a.Substring(i, 2) == (b.Substring(i, 2)))
                {
                    count ++;
                }
            }
            return count;
        }

        public string StringX(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == str.Length - 1)
                {
                    sb.Append(str[i]);
                }
                else if (str[i].ToString() != "x")
                {
                    sb.Append(str[i]);
                }
                else
                {
                    continue;
                }
            }
            return sb.ToString();
        }

        public string AltPairs(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i += 4)
            {
                sb.Append(str[i]);
                if (i == str.Length - 1)
                {
                    continue;
                }
                sb.Append(str[i + 1]);
            }
            return sb.ToString();
        }

        public string DoNotYak(string str)
        {
            string temp;
            string answer ="";
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 1) == "y" && str.Substring(i + 2, 1) == "k")
                {
                    temp = str.Substring(i, 3);
                    answer = str.Replace(temp, "");
                }
            }
            return answer;
        }

        public int Array667(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if ((numbers[i] == 6) && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                {
                    count ++;
                }
            }
            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] + 5 == numbers[i + 1] && numbers[i] - 1 == numbers[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
