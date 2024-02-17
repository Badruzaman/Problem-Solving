

int[] arr = { -1, 2, -1 };
int res = solution(arr, arr.Length);
Console.WriteLine(res);
Console.ReadKey();
int solution(int[] arr, int n)
{
    int i, j;
    int leftsum, rightsum;
    for (i = 0; i < n; ++i)
    {
        leftsum = 0;
        rightsum = 0;
        for (j = 0; j < i; j++)
            leftsum += arr[j]; 
        for (j = i + 1; j < n; j++)
            rightsum += arr[j];
        if (leftsum == rightsum)
            return i;
    }
    return -1;
}

// O(n)
// O(1)
int solution01(int[] arr, int n)
{
    int leftSum = 0;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        sum -= arr[i];
        if (sum == leftSum)
            return i;
        leftSum += arr[i];
    }
    return -1;
}
// O(n)
// O(1)
int solution02(int[] nums, int n)
{
    int left = 0, pivot = 0, right = nums.Skip(1).Sum();
    while (pivot < nums.Length - 1 && right != left)
    {
        pivot++;
        right -= nums[pivot];
        left += nums[pivot - 1];
    }
    return (left == right) ? pivot : -1;
}