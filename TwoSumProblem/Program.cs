

using System.ComponentModel;
using System.Security.AccessControl;

int[] arr = { 2, 3, 4, 5, 7 };
int target = 16;
int[] res = solution01(arr, target);
foreach (int i in res)
{
    Console.Write(i + " ");
}
Console.ReadKey();
// o(n)
// o(n)
int[] solution(int[] nums, int target)
{
    HashSet<int> set = new HashSet<int>();
    foreach (int x in nums)
    {
        int y = target - x;
        if (set.Contains(y))
        {
            return new int[] { y, x };
        }
        set.Add(x);
    }
    return new int[] { -1, -1 };
}
// o(nlogn)
// o(1)
int[] solution01(int[] nums, int target)
{
    Array.Sort(nums);
    int left = 0;
    int right = nums.Length - 1;
    while(left < right)
    {
        if(target == nums[left] + nums[right])
        {
            return new int[] { nums[left] , nums[right] };
        }
        if (nums[left] + nums[right] < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return new int[] { -1, -1 };
}