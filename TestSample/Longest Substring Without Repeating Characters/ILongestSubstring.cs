using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.Longest_Substring_Without_Repeating_Characters
{
    internal interface ILongestSubstring
    {
        // abcabcbb
        internal static int getLongestSubstring(string str)
        {
            int count = 0;
            Dictionary<char, int> substrings = new Dictionary<char, int>();
            int left = 0;
            int right = 0;
            while (right < str.Length)
            {
                if (!substrings.ContainsKey(str[right]))
                {
                    substrings[str[right]] = right++;
                    count = Math.Max(count, right - left);
                }
                else
                {
                    substrings.Remove(str[left]);
                    left++;
                }
            }
            return count;
        }
    }
}
