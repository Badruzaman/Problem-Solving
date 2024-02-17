using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.RomanProblems
{
    internal class IRoman
    {
        // XVI
        internal static int GetRomanToInteger(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>();
            romanValues.Add('I', 1);
            romanValues.Add('V', 5);
            romanValues.Add('X', 10);
            romanValues.Add('L', 50);
            romanValues.Add('C', 100);
            romanValues.Add('D', 500);
            romanValues.Add('M', 1000);
            char FirstChar = s[s.Length - 1];
            int result = romanValues[FirstChar];
            for(int i = s.Length -2; i >= 0; i--)
            {
                if (romanValues[s[i]] < romanValues[s[i + 1]])
                {
                    result -= romanValues[s[i]];
                }
                else
                {
                    result += romanValues[s[i]];
                }
            }
            return result;
        }
    }
}
