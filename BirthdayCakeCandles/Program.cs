
int[] arr = { 4, 4, 1, 3 ,4};

int result = BirthdayCakeCandles(arr);
Console.Write(result);
Console.ReadKey();


int BirthdayCakeCandles(int[] arr)
{
    int count = 0;
    int max = int.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
            count = 1;
        }
        else if (max == arr[i])
        {
            count++;
        }
    }
    return count;
}