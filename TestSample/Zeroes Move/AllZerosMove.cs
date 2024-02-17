using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.Zeroes_Move
{
    internal class AllZerosMove
    {

        // time O(n)
        // space O(1)
        internal int[] MoveAllZerosToRight(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                while (numbers[right] == 0 && left < right)
                {
                    right--;
                }
                if (numbers[left] == 0)
                {
                    int temp = numbers[left];
                    numbers[left] = numbers[right];
                    numbers[right] = temp;
                }
                left++;
            }
            return numbers;
        }

        // time O(n)
        // space O(1)
        internal int[] MoveAllZerosToRight_01(int[] numbers)
        {
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                    j++;
                }
            }
            return numbers;
        }

        internal bool CheckAnagram(string s, string t)
        {
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic1.ContainsKey(s[i]))
                {
                    dic1[s[i]] = 0;
                }
                dic1[s[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!dic2.ContainsKey(t[i]))
                {
                    dic2[t[i]] = 0;
                }
                dic2[t[i]]++;
            }
            foreach (var keyval in dic1)
            {
                if (dic1[keyval.Key] != dic2[keyval.Key])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
