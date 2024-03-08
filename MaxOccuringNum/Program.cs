
int res = MaxOccuringNum_01(4555566);
Console.WriteLine(res);
Console.ReadKey();
int MaxOccuringNum(int num)
{
    int[] numbers = new int[10];
    while (num > 0)
    {
        int rem = num % 10;
        numbers[rem]++;
        num /= 10;
    }
    int maxOccuringCount = 0;
    int maxOccuringNum = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (maxOccuringCount < numbers[i])
        {
            maxOccuringCount = numbers[i];
            maxOccuringNum = Array.IndexOf(numbers, numbers[i]);
        }
    }
    return maxOccuringNum;
}
int MaxOccuringNum_01(int num)
{
    Dictionary<int, int> nums = new Dictionary<int, int>();
    while (num > 0)
    {
        int rem = num % 10;
        if (!nums.ContainsKey(rem))
        {
            nums[rem] = 0;
        }
        nums[rem]++;
        num /= 10;
    }
    return nums.MaxBy(it => it.Value).Key;
}