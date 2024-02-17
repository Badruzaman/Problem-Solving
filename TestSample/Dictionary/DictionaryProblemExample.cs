using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.Dictionary
{
    internal class DictionaryProblemExample
    {
        // time o(n) 
        // space o(n)
        internal (char, int) getMaxOccuringCharacter(string str)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (char ch in str)
            {
                if (!keyValuePairs.ContainsKey(ch))
                {
                    keyValuePairs.Add(ch, 0);
                }
                keyValuePairs[ch]++;
            }
            int max = 0;
            char ch1 = '\0';
            foreach (KeyValuePair<char, int> kv in keyValuePairs)
            {
                if (max <= kv.Value) // last maximum key value
                {
                    max = kv.Value;
                    ch1 = kv.Key;
                }
            }
            //var secondMax = keyValuePairs.OrderByDescending(it => it.Value).ToArray();
            //Console.WriteLine($"second max is {secondMax[1].Key}");
            //var maxKeyValue = keyValuePairs.MaxBy(it => it.Value);
            //Console.WriteLine($"max key {maxKeyValue.Key} value {maxKeyValue.Value}");
            (char, int) res = (ch1, max); // tuple using
            return res;
        }
        // time o(nlogn) + o(n) 
        // space o(1)
        internal (char, int) getMaxOccuringCharacter_01(string str)
        {
            var orderedStr = str.OrderBy(it => it).ToArray();
            int max = 0;
            char ch1 = ' ';
            int count = 1;
            for (int i = 0; i < orderedStr.Length - 1; i++)
            {
                if (orderedStr[i] == orderedStr[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (max <= count) // last maximum key value
                {
                    max = count;
                    ch1 = orderedStr[i];
                }
            }
            (char, int) t1 = (ch1, max); // tuple using
            return t1;
        }
        internal int getMaxOccuringNumber(int number)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            string str = number.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(str[i]))
                {
                    keyValuePairs[str[i]] = 0;
                }
                keyValuePairs[str[i]]++;
            }
            var maxKey = keyValuePairs.MaxBy(kv => kv.Value);
            return int.Parse(maxKey.Key.ToString());
        }
        internal int getMaxOccuringNumber_01(int number)
        {
            int[] countNumbers = new int[10];
            string numStr = number.ToString();
            foreach (char digit in numStr)
            {
                int digitValue = int.Parse(digit.ToString()); //digit - '0';
                countNumbers[digitValue]++;
            }
            int maxCount = 0;
            int maxOccurringDigit = -1;
            for (int i = 0; i < 10; i++)
            {
                if (maxCount < countNumbers[i])
                {
                    maxCount = countNumbers[i];
                    maxOccurringDigit = i;
                }
            }
            return maxOccurringDigit;
        }
        internal int getMaxOccuringNumber_02(int num)
        {
            int[] digitCounts = new int[10];
            while (num > 0)
            {
                int digit = num % 10; // Extract the last digit
                digitCounts[digit]++; // Increment count for the digit
                num = num / 10; // Remove the last digit
            }
            int maxCount = 0;
            int maxOccurringDigit = -1;
            for (int i = 0; i < 10; i++)
            {
                if (maxCount < digitCounts[i])
                {
                    maxCount = digitCounts[i];
                    maxOccurringDigit = i;
                }
            }
            return maxOccurringDigit;
        }
    }
}