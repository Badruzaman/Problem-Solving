
int[] arr = { 7, 69, 2, 221, 8974 };

int[] result = MiniMaxSum(arr);
Console.Write(result[0] + " " + result[1]);
Console.ReadKey();


int[] MiniMaxSum(int[] arr)
{
    int minNum = int.MaxValue;
    int maxNum = int.MinValue;
    int totalSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(minNum > arr[i])
        {
            minNum = arr[i];
        }
        if(maxNum < arr[i])
        {
            maxNum = arr[i];
        }
        totalSum += arr[i];
    }
    return new int[2] {totalSum - maxNum, totalSum - minNum};
}