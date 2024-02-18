

int[] arr = { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
bool result = IsMonotonicArray(arr);
Console.WriteLine(result);
Console.ReadKey();
bool IsMonotonicArray(int[] arr)
{   
    bool isNonDecreasing = true;
    bool isNonIncreasing = true;
   
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[i - 1])
        {
            isNonDecreasing = false;
        }
        if (arr[i] > arr[i - 1])
        {
            isNonIncreasing = false;
        }
    }
    return  isNonIncreasing || isNonDecreasing;
}