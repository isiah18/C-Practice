using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Arrays
    {
        //First Last 6
        public bool FirstLast6(int[] numbers)
        {
            //return (numbers.First() == 6 || numbers.Last() == 6) ? true : false;
            return (numbers[0] == 6 || numbers[numbers.Length - 1] == 6) ? true : false;
        }

        //Same First Last
        public bool SameFirstLast(int[] numbers)
        {
            return (numbers.Length >= 1 && numbers[0] == numbers[numbers.Length - 1]) ? true : false;
        }

        //Make Pi
        public int[] MakePi(int n)
        {
            int[] numberArray = new int[n];
            double pi = Math.PI;
            string numberPi = pi.ToString();
            numberPi = numberPi.Remove(1, 1);
            for (int i = 0; i < n; i++)
            {
                numberArray[i] = int.Parse(numberPi.Substring(i, 1));
            }
            return numberArray;
        }

        //Common End
        public bool commonEnd(int[] a, int[] b)
        {
            return (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1]) ? true : false;
        }

        //Sum
        public int Sum(int[] numbers)
        {
            int answer = 0;
            foreach (int element in numbers)
            {
                answer += element;
            }
            return answer;
        }

        //Rotate Left
        public int[] RotateLeft(int[] numbers)
        {
            int[] answerArray = new int[numbers.Length];
            answerArray[numbers.Length - 1] = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            { 
                answerArray[i] = numbers[i + 1];
            }
            return answerArray;
        }

        //Reverse
        public int[] Reverse(int[] numbers)
        {
            int temp;
            temp = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = numbers[0];
            numbers[0] = temp;
            return numbers;
        }

        //Higher Wins
        public int[] HigherWins(int[] numbers)
        {
            int highest;
            if (numbers[0] >= numbers[numbers.Length - 1])
            {
                highest = numbers[0];
            }
            else
            {
                highest = numbers[numbers.Length - 1];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = highest;
            }
            return numbers;
        }

        //Get Middle
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] answerArray = new int[2];
            answerArray[0] = a[1];
            answerArray[1] = b[1];
            return answerArray;
        }

        //Has Even
        public bool HasEven(int[] numbers)
        {
            foreach (int element in numbers)
            {
                if (element%2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //Keep Last
        public int[] KeepLast(int[] numbers)
        {
            int[] answerArray = new int[numbers.Length * 2];
            answerArray[answerArray.Length - 1] = numbers[numbers.Length - 1];
            return answerArray;
        }

        //Double23
        public bool Double23(int[] numbers)
        {
            int twoCounter = 0;
            int threeCounter = 0;
            foreach (int element in numbers)
            {
                if (element == 2)
                {
                    twoCounter++;
                }
                else if (element == 3)
                {
                    threeCounter++;
                }
                else
                {
                    continue;
                }
            }
            return (twoCounter == 2 || threeCounter == 2) ? true : false;
        }

        //Fix 23
        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return numbers;
        }

        //Unlucky 1
        public bool Unlucky1(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length < 5)
                {
                    if ((numbers[0] == 1 && numbers[1] == 3) ||
                        numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3)
                    {
                        return true;
                    }
                }
                else if ((i < 2) || i > numbers.Length - 3)
                {
                    if (numbers[i] == 1 && numbers[i + 1] == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //Make Two
        public int[] make2(int[] a, int[] b)
        {
            int[] answerArray = new int[2];
            if (a.Length == 0)
            {
                answerArray[0] = b[0];
                answerArray[1] = b[1];
            }
            else if (a.Length == 1)
            {
                answerArray[0] = a[0];
                answerArray[1] = b[0];
            }
            else
            {
                answerArray[0] = a[0];
                answerArray[1] = a[1];
            }
            return answerArray;
        }
    }
}
