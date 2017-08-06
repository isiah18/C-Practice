using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
            {
                return (cigars >= 40) ? true : false;
            }
            else
            {
                return (cigars >= 40 && cigars <= 60) ? true : false;
            }
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if ((yourStyle >= 8 && dateStyle > 2) || (yourStyle > 2 && dateStyle >= 8))
            {
                return 2;
            }
            else if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer)
            {
                return (temp >= 60 && temp <= 100) ? true : false;
            }
            else
            {
                return (temp >= 60 && temp <= 90) ? true : false;
            }
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int noTicket = 60;
            int[] smallTicket = new[] {61, 80};
            int bigTicket = 81;
            int answer = 0;
            if (isBirthday)
            {
                if (speed < noTicket + 5)
                {
                    answer = 0;
                }
                else if (speed >= smallTicket[0] + 5 && speed <= smallTicket[1] + 5)
                {
                    answer = 1;
                }
                else if (speed > bigTicket +5)
                {
                    answer = 2;
                }
            }
            else
            {
                if (speed < noTicket)
                {
                    answer = 0;
                }
                else if (speed >= smallTicket[0] && speed <= smallTicket[1])
                {
                    answer = 1;
                }
                else if (speed > bigTicket)
                {
                    answer = 2;
                }
            }
            return answer;
        }

        public int SkipSum(int a, int b)
        {
            if (a+b >= 10 && a+b <= 19)
            {
                return 20;
            }
            else
            {
                return a + b;
            }
        }

        public string AlarmClock(int day, bool vacation)
        {
            int[] weekdays = new[] {1, 2, 3, 4, 5};
            int[] weekends = new[] {6, 0};
            if ((vacation && (weekdays.Contains(day))) || (!vacation && weekends.Contains(day)))
            {
                return "10:00";
            }
            else if (vacation && (weekends.Contains(day)))
            {
                return "off";
            }
            else if (!vacation && weekdays.Contains(day))
            {
                return "7:00";
            }
            else
            {
                return "invalid.";
            }
        }

        public bool LoveSix(int a, int b)
        {
            return (a == 6 || b == 6 || a+b == 6 || a-b == 6) ? true :false;
        }

        public bool InRange(int n, bool outsideMode)
        {
            if ((outsideMode && (n<=1 || n>=10)) || (!outsideMode && (n >= 1 && n <= 10)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SpecialEleven(int n)
        {
            return (n%11 == 0 || n%11 == 1) ? true : false;
        }

        public bool Mod20(int n)
        {
            return (n%20 == 1 || n%20 == 2) ? true : false;
        }

        public bool Mod35(int n)
        {
            return (n%3 == 0 ^ n%5 == 0) ? true : false;
        }

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isMorning && isMom)
            {
                return true;
            }
            else if (isMorning || isAsleep)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool TwoIsOne(int a, int b, int c)
        {
            return (a + b == c || a + c == b || b + c == a) ? true : false;
        }

        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            return ((bOk && c > b) || (!bOk && c > b && b > a)) ? true : false;
        }

        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            return ((equalOk && a <= b && b <= c) || (a < b && b < c)) ? true : false;
        }

        //Fix to do the harder way without .last()
        public bool LastDigit(int a, int b, int c)
        {
            string sa = a.ToString();
            string sb = b.ToString();
            string sc = c.ToString();

            if (sa.Last() == sb.Last() || sa.Last() == sc.Last() || sb.Last() == sc.Last())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int RollDice(int die1, int die2, bool noDoubles)
        {
            int newDice;
            int answer = 0;
            if (noDoubles && die1 == die2)
            {
                if (die1 == 6)
                {
                    newDice = 1;
                    answer = newDice + die2;
                }
                newDice = die1 + 1;
                answer = die2 + newDice;
            }
            else
            {
                answer = die1 + die2;
            }
            return answer;
        }
    }
}
