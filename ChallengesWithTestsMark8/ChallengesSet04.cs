using System;
using System.Diagnostics.CodeAnalysis;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if(number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }
            return result;
            

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = int.MaxValue;

            string[] strings = { str1, str2, str3, str4 };

            foreach (string str in strings)
            {
                if (str.Length < shortestLength)
                {
                    shortestLength = str.Length;
                }
            }

            return shortestLength;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallNumber = int.MaxValue;

            int[] num = { number1, number2, number3, number4 };

            foreach (int number in num)
            {
                if(number  < smallNumber)
                {
                    smallNumber = number;
                }
            }
            return smallNumber;
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
          if(biz == null || string.IsNullOrWhiteSpace(biz.Name))
            {
                biz.Name = "TrueCoders";
                return;
            }

          switch(biz.Name)
            {
                case "true coders":
                case "truecoders":
                case "TRUECODERS":
                case "tRUEcODERS":
                case "test":
                    biz.Name = "TrueCoders";
                    break;

                default:
                    biz.Name = "TrueCoders";
                    break;
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            int sum = 0;
            int count = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }
            if(count == 0)
            {
                return 0;
            }

            return (double)sum / count;
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
