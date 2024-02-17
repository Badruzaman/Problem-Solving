
int[] nums = { 12, 3, 4, 1, 6, 9 };
int x = 24;
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
    Array.Sort(arr);
    for (int i = 0; i < arr.Length; i++)
    {
        int left = i + 1;
        int right = arr.Length - 1;
        while (left < right)
        {
            int currentSum = arr[i] + arr[left] + arr[right];
            if (currentSum == x)
            {
                return new int[] { i, left, right };
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
    }
    return new int[] { -1, -1, -1 };
}
