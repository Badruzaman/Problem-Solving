using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.Public_Bank_Malaysia
{
    internal interface IPublicBank
    {
       internal static int CountPairsDivisibleByK(List<int> arr, int k)
        {
            // Create an array to count the remainders
            int[] remainderFreq = new int[k];

            // Count the frequency of remainders
            foreach (int num in arr)
            {
                remainderFreq[num % k]++;
            }
            // Initialize count of pairs to 0
            int countPairs = 0;

            // Count pairs with remainder 0
            countPairs += (remainderFreq[0] * (remainderFreq[0] - 1)) / 2;

            // Count pairs for which remainder + complement == k
            for (int i = 1; i <= k / 2 && i != (k - i); i++)
            {
                countPairs += remainderFreq[i] * remainderFreq[k - i];
            }
            // If k is even, count pairs with remainder k/2
            if (k % 2 == 0)
            {
                countPairs += (remainderFreq[k / 2] * (remainderFreq[k / 2] - 1)) / 2;
            }
            return countPairs;
        }
    }
}
