using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
          
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers ==null)
            {
                 return false;
            }
            else
            {
                return numbers.Sum() % 2 != 0;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsNumber = false;
            bool containsLower = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    containsUpper = true;
                    
                }
                else if (char.IsDigit(c))
                {
                    containsNumber = true;
                    
                }
                else if (char.IsLower(c))
                {
                    containsLower = true;
                }
            }

            return containsUpper && containsNumber && containsLower;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;  
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int firstIndex = nums[0];
            int total = nums[lastIndex];

            return total - firstIndex;

        }

        public int[] GetOddsBelow100()
        {
            int count = 0;
            for (int i = 1; i < 100; i += 2)
            {
                count++;
            }

            int[] odds = new int[count];
            int index = 0;
            for (int i = 1; i < 100; i += 2)
            {
                odds[index++] = i;
            }

            return odds;
        }    

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
