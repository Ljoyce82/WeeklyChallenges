using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c) ? true : false; 
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;  
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
            {  
                return 0; 
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Max() + numbers.Min();

        }   
        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers != null ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        { 
            return  numbers != null && numbers.Any(num => num % 2 == 0) ? numbers.Where(num => num % 2 == 0).Sum() : 0;    
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers != null && numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        }
    }
}
