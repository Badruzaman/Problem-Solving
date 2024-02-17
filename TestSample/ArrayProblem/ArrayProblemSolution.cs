using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.ArrayProblem
{
    internal class ArrayProblemSolution
    {

        internal bool CheckPalindrome(int num)
        {
            int input = num;
            int result = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                result = result * 10 + remainder;
                num = num / 10;
            }
            return input == result;
        }

        internal bool CheckPalindrome(string str)
        {
            string AlpNumString = string.Empty;
            foreach (char ch in str)
            {
                if (char.IsAsciiLetterOrDigit(ch))
                {
                    AlpNumString += ch;
                }
            }
            int j = 0;
            for (int i = AlpNumString.Length - 1; i >= 0; i--)
            {
                if (char.ToLower(AlpNumString[i]) != char.ToLower(AlpNumString[j]))
                {
                    return false;
                }
                j++;
            }
            return true;
        }
    }
}
