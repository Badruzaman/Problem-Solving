using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.LongestConsecutiveSubsequence
{
    internal class LongestConsecutiveSubsequenceSolution
    {
        internal int getLongestConsecutiveSubsequence(int[] arr)
        {
            Array.Sort(arr);
            List<int> v = new List<int>();
            v.Add(10);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                    v.Add(arr[i]);
            }
            return 0;
        }
    }
}
