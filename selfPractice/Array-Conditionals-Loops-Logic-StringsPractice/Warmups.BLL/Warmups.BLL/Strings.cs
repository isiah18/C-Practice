using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Strings
    {
        //Say Hi
        public string SayHi(string name)
        {
            return String.Format("Hello {0}!", name);
        }

        //Abba
        public string Abba(string a, string b)
        {
            return String.Format("{0}{1}{1}{0}", a, b);
        }

        //Make Tags
        public string MakeTags(string tag, string content)
        {
            return String.Format("<{0}>{1}</{0}>", tag, content);
        }

        //Insert Word
        public string InsertWord(string container, string word)
        {
            //return container.Insert((container.Length/2) - 1, word);
            string front = container.Substring(0, 2);
            string end = container.Substring(2, 2);
            string answer = front + word + end;
            return answer; 
        }

        //Multiple Endings
        public string MultipleEndings(string str)
        {
            if (str.Length == 2)
            {
                return str + str + str;
            }
            string lastTwo = str.Substring(str.Length - 2, 2);
            return String.Concat(lastTwo, lastTwo, lastTwo);
        }

        //First Half
        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length/2); 
        }
         
        //Trim One
        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        //Long In Middle
        public string LongInMiddle(string a, string b)
        {
            string answer;
            if (a.Length > b.Length)
            {
                answer = String.Concat(b, a, b);
            }
            else
            {
                answer = String.Concat(a,b,a);
            }
            return answer;
        }

        //Rotate Left 2
        public string Rotateleft2(string str)
        {
            string end = str.Substring(0, 2);
            string front = str.Substring(2, str.Length - 2);
            string answer = String.Concat(front, end);
            return answer;
        }
        
        //Rotate Right 2
        public string RotateRight2(string str)
        {
            string front = str.Substring(str.Length - 2, 2);
            string end = str.Substring(0, str.Length - 2);
            string answer = String.Concat(front, end);
            return answer;
        }

        //Take One
        public string TakeOne(string str, bool fromFront)
        {
            string answer;
            if(fromFront)
            {
                answer = str.Substring(0, 1);
            }
            else
            {
                answer = str.Substring(str.Length - 1);
            }
            return answer;
        }

        //Middle Two
        public string MiddleTwo(string str)
        {
            string answer = str[(str.Length/2) - 1].ToString() + str[(str.Length/2)].ToString();
            return answer;
        }

        //Ends With Ly
        public bool EndsWithLy(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            //if (str.EndsWith("ly"))
            if(str.Substring(str.Length-2, 2) == "ly")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Front And Back
        public string FrontAndBack(string str, int n)
        {
            string first = str.Substring(0, n);
            string last = str.Substring(str.Length - n);
            string answer = String.Concat(first, last);
            return answer;
        }

        //Take Two From Position
        public string TakeTwoFromPosition(string str, int n)
        {
            string answer;
            if(str.Length - 1 == n)
            {
                answer = str.Substring(0, 2);
            }
            else
            {
                answer = str.Substring(n, 2);
            }
            return answer;
        }

        //Has Bad
        public bool HasBad(string str)
        {
            if (str.Length < 3)
            {
                return false;
            }
            else if (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //At First
        public string AtFirst(string str)
        {
            string answer;
            if (str.Length < 2)
            {
                do
                {
                    str += "@";
                } while (str.Length < 2);
                return str;
            }
            else
            {
                answer = str.Substring(0, 2);
            }
            return answer;
        }

        //Last Chars
        public string LastChars(string a, string b)
        {

            if (a.Length == 0 && b.Length == 0)
            {
                return "@@";
            }
            else if (a.Length == 0)
            {
                a = "@".ToString();
            }
            else if(b.Length == 0)
            {
                b = "@".ToString();
            }
            return a[0].ToString() + b[b.Length - 1].ToString();
        }

        //ConCat
        public string ConCat(string a, string b)
        {
            string answer;
            if (a.Length == 0 || b.Length == 0)
            {
                answer = a + b;
            }
            else if (a[a.Length - 1] == b[0])
            {
                string first = a.Substring(0, a.Length - 1);
                answer = first + b;
            }
            else
            {
                answer = a + b;
            }
            return answer;
        }

        //Swap Last
        public string SwapLast(string str)
        {
            string a;
            string b;
            string answer;
            if (str.Length < 2)
            {
                answer = str;
            }
            else if (str.Length < 3)
            {
                a = str[0].ToString();
                b = str[1].ToString();
                answer = b + a;
            }
            else
            {
                a = str[str.Length - 1].ToString();
                b = str[str.Length - 2].ToString();
                string leftOver = str.Substring(0, str.Length - 2);
                answer = leftOver + a + b;
            }
            return answer;
        }

        //Front Again
        public bool FrontAgain(string str)
        {
            if (str.Length < 3)
            {
                return true;
            }
            string firstpart = str.Substring(0, 2);
            string lastpart = str.Substring(str.Length - 2, 2);
            if (firstpart == lastpart)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //MinCat
        public string MinCat(string a, string b)
        {
            if (a.Length == 0 || b.Length == 0)
            {
                a = "";
                b = "";
            }
            if (a.Length > b.Length)
            {
                a = a.Substring(a.Length - b.Length);
            }
            if (b.Length > a.Length)
            {
                b = b.Substring(b.Length - a.Length);
            }
            return String.Concat(a, b);
        }

        //Tweak Front
        public string TweakFront(string str)
        {
            if (str[0].ToString() == "a" && str[1].ToString() == "b")
            {
                return str;
            }
            else if (str[0].ToString() == "a" && str[1].ToString() != "b")
            {
                return str.Remove(1, 1);
            }
            else if (str[0].ToString() != "a" && str[1].ToString() == "b")
            {
                return str.Remove(0, 1);
            }
            else
            {
                return str.Remove(0, 2);
            }
        }

        //Strip X
        public string StripX(string str)
        {
            if (str[0].ToString() == "x")
            {
                str = str.Remove(0, 1);
            }
            if (str[str.Length - 1].ToString() == "x")
            {
                str = str.Remove(str.Length - 1, 1);
            }
            return str;
        }

    }
}
