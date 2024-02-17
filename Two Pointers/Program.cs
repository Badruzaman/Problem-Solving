
int[] nums = { 10, 20, 35, 50, 75, 80 };
int x = 70;
int[] result = solution(nums, x);
foreach (int item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

// O(n)
// O(1)
int[] solution(int[] arr, int x)
{
    int left = 0;
    int right = arr.Length - 1;
    while (left < right)
    {
        int currentSum = arr[left] + arr[right];
        if (currentSum == x)
        {
            return new int[] { left, right };
        }
        else if (x < currentSum)
        {
            right--;
        }
        else
        {
            left++;
        }
    }
    return new int[] { -1, -1 };
}
