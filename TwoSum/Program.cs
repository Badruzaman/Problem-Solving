
int[] nums = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
int target = 10;

int[] result = GetTwoSums(nums);
foreach (var item in result)
{
    Console.Write(item + " ");
}
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
