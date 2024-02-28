
int[] nums = { -1, -3, -4, -3, -4, -2 };
int result = getSecondLargestNum(nums);
Console.WriteLine(result);
Console.ReadKey();


int getSecondLargestNum(int[] arr)
{
    int first = arr[0];
    for (int i = 1;i < arr.Length; i++)
        if (arr[i] > first)
            first = arr[i];
    // Find second 
    // largest element
    int second = int.MinValue;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > second && arr[i] < first)
            second = arr[i];

    // Find third
    // largest element
    int third = int.MinValue;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > third && arr[i] < second)
            third = arr[i];

    return third;
}