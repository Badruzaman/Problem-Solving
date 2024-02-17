
int[] arr = { 3, 5, 2, 4, 5, 3, 4 };
int result = solution(arr);
Console.WriteLine(result);
Console.ReadKey();


int solution(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        var count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                count++;
            }
        }
        if (count == 1)
        {
            return arr[i];
        }
    }
    return -1;
}
