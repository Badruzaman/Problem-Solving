
int[] nums = new int[] { 1,2,3,4,5,6 };
int target = 9;

//int[] result = getTwoSum(nums);
//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}
int num = 10;
ModifyValue(ref num);
Console.WriteLine(num);
Console.ReadKey();

int[] GetTwoSums(int[] nums)
{
    HashSet<int> set = new HashSet<int>();
    foreach (int num in nums)
    {
        int potentialNum = target - num;
        if (set.Contains(potentialNum))
        {
            return new int[] { potentialNum , num };
        }
        else
        {
            set.Add(num);
        }
    }
    return new int[0];
}


int[] getTwoSum(int[] nums)
{
    Array.Sort(nums);
    int left = 0;
    int right = nums.Length - 1;
    while (left < right)
    {
        int currentSum = nums[left] + nums[right];
        if (currentSum == target)
        {
            return new int[] { left, right };
        }
        if(currentSum < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return new int[0];
}

void ModifyValue(ref int x)
{
    x = x * 2;
}

