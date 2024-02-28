using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LargestElements
{
    internal interface ILargest
    {
        internal static int getThirdLargest(List<int> list)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;
            for (int i = 0; i < list.Count; i++)
            {
                int currentNum = list[i];
                if(first < currentNum)
                {
                    third = second;
                    second = first;
                    first = currentNum;
                }
                else if(second < currentNum & currentNum > first)
                {
                     third = second;
                     second = currentNum;
                }
                else if (third < currentNum && second > third)
                {
                    third = currentNum;
                }
            }
            return third;
        }
    }
}
