
int[] arr = { 1, 1, 1, 2, 1, 4 };
int result = getResult(arr);
Console.WriteLine(result);
Console.ReadKey();

int getResult(int[] arr)
{
    int max = int.MinValue;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int currentSum = arr[i] + arr[i + 1];
        if (currentSum > max)
        {
            max = currentSum;
        }
    }
    return max;
}

