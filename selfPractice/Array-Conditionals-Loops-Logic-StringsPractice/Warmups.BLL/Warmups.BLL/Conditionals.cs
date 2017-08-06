using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Conditionals
    {
        //Are We In Trouble
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return (aSmile.Equals(bSmile)) ? true : false; 
        }

        //Can Sleep In 
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            return (!isWeekday || isVacation) ? true : false;
        }

        public int SumDouble(int a, int b)
        {
            return (a.Equals(b)) ? 2*(a + b) : a + b;
        }

        public int Diff21(int n)
        {
            return (n > 21) ? Math.Abs(2*(21 - n)) : Math.Abs(21 - n);
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            return (isTalking && (hour < 7 || hour > 20)) ? true : false;
        }

        public bool Makes10(int a, int b)
        {
            return (a == 10 || b == 10 || a + b == 10) ? true : false;
        }

        public bool NearHundred(int n)
        {
            return ((Math.Abs(n - 100) <= 10) || (Math.Abs(n-200) <=10)) ? true : false;
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            return ((a > 0 && b < 0 || a < 0 && b > 0) || (negative == true && a < 0 && b < 0)) ? true : false; 
        }

        public string NotString(string s)
        {
            return (s.StartsWith("not")) ? s : String.Concat("not ", s);
        }

        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        //Refactor using char array -- String s = new String(chararray)
        public string FrontBack(string str)
        {
            if (str.Length < 2)
                return str;
            else
            {
                string holder = str.Substring(0, 1);
                string backholder = str.Substring(str.Length - 1, 1);
                string removedFront = str.Remove(0, 1);
                string removedBack = removedFront.Remove(removedFront.Length - 1, 1);
                string addedFront = removedBack.Insert(0, backholder);
                string addedBack = addedFront.Insert(addedFront.Length, holder);
                return addedBack;
            }
        }

        public string Front3(string str)
        {
            return (str.Length < 3) ? String.Concat(str, str, str) : String.Format("{0}{0}{0}", str.Substring(0, 3));
        }

        public string BackAround(string str)
        {
            string last = str.Substring(str.Length - 1, 1);
            string answer = str.Insert(0, last);
            return answer.Insert(answer.Length - 1, last);
        }

        public bool Multiple3or5(int number)
        {
            return (number%5 == 0 || number%3 == 0);
        }

        public bool StartHi(string str)
        {
            return ((str.Length < 3 && str.StartsWith("hi")) || str.StartsWith("hi ")) ? true : false;
        }

        public bool IcyHot(int temp1, int temp2)
        {
            return ((temp1 < 0 && temp2 > 100) || temp1 > 100 && temp2 < 0) ? true : false;
        }

        public bool Between10and20(int a, int b)
        {
            return ((a >= 10 && a <= 20) || (b >= 10 && b <= 20));
        }

        public bool HasTeen(int a, int b, int c)
        {
            return (a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19);
        }

        public bool SoAlone(int a, int b)
        {
            return ((a >= 13 && a <= 19) ^ (b >= 13 && b <= 19));
        }

        public string RemoveDel(string str)
        {
            return (str.Substring(1, 3) == "del") ? str.Remove(1, 3) : str;
        }

        public bool IxStart(string str)
        {
            return (str.Substring(1, 2) == "ix");
        }

        public string StartOz(string str)
        {
            if (str.StartsWith("oz"))
            {
                return "oz";
            }
            else if (str[0].ToString() == "o" && str[1].ToString() != "z")
            {
                return "o";
            }
            else if (str[0].ToString() != "o" && str[1].ToString() == "z")
            {
                return "z";
            }
            else
            {
                return str.Substring(0, 2);
            }
        }

        public int Max(int a, int b, int c)
        {
            int higher = Math.Max(a, b);
            return Math.Max(higher, c);
        }

        public int Closer(int a, int b)
        {
            if ((Math.Abs(10 - a)) == (Math.Abs(10 - b)))
            {
                return 0; 
            }
            else if ((Math.Abs(10 - a)) < (Math.Abs(10 - b)))
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public bool GotE(string str)
        {
            int count = 0;
            char[] charArray = str.ToCharArray();
            foreach (char element in charArray)
            {
                if (element.ToString() == "e")
                {
                    count ++;
                }
                else
                {
                    continue;
                }
            }
            return (count >= 1 && count <= 3) ? true : false;
        }

        public string EndUp(string str)
        {
            if (str.Length < 3)
            {
                return str.ToUpper();
            }
            else
            {
                string last3Upper = str.Substring(str.Length - 3, 3).ToUpper();
                string removeLast3 = str.Remove(str.Length - 3, 3);
                return removeLast3.Insert(removeLast3.Length, last3Upper);
            }
        }

        public string EveryNth(string str, int n)
        {
            StringBuilder answer = new StringBuilder();
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i%n == 0)
                {
                    answer.Append(charArray[i]);
                }
            }
            return answer.ToString();
        }
    }
}
