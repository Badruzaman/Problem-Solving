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
            Dictionary<char, int> substring = new Dictionary<char, int>();
            int right = 0;
            int left = 0;
            while (right < str.Length)
            {
                if (!substring.ContainsKey(str[right]))
                {
                    substring[str[right]] = right++;
                    count = Math.Max(count, right - left);
                }
                else
                {
                    substring.Remove(str[left]);
                    left++;
                }
            }
            return count;
        }
    }
}
