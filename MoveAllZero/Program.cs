

int[] arr = { 5, 6, 0, 4, 6, 0, 9, 0, 8 };
int[] result = solution(arr);
foreach (int i in result)
{
    Console.Write(i + " ");
}
Console.ReadKey();
int[] solution(int[] A)
{
    int n = arr.Length;
    int j = 0;
    for (int i = 0; i < n; i++)
	{
        if (A[i] != 0)
        {
            int temp = A[j];
            A[j] = A[i];
            A[i] = temp;
            j++;
        }
    }
    return A;
}

int[] solution01(int[] nums)
{
    int left = 0;
    int right = nums.Length - 1;    
    while (left < right)
    {
        while(left < right && nums[right] == 0)
        {
            right--;
        }
        if (arr[left] == 0)
        {
           int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
        left++;
    }
    return nums;
}