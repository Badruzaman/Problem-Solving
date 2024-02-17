

int[] nums = { 4, 8, 3, 1 };
int result = getSecondMax(nums);
Console.WriteLine($"second largest num is {result}");
Console.ReadKey();
int GetFrequency(int[] nums, int num)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == num)
        {
            count++;
        }
    }
    return count;
}
// 4,3,2,1
int GetSecondLargestElement(int[] nums)
{
    int maxNum = int.MinValue;
    int secondNum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (maxNum < nums[i])
        {
            secondNum = maxNum;
            maxNum = nums[i];
        }
        else if (maxNum != secondNum && secondNum < nums[i])
        {
            secondNum = nums[i];
        }
    }
    return secondNum;
}

int getSecondMax(int[] nums)
{
    int secondMax = int.MinValue;
    int maxNum = nums.Max();
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != maxNum)
        {
            secondMax = Math.Max(secondMax, nums[i]);
        }
    }
    return secondMax;
}
