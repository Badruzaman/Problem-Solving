

int[] arr = { 1, 2, 3, 4, 5 };
int[] result = solution(arr);
foreach (int item in result)
{
    Console.Write(result + " ");
}
Console.ReadKey();

int[] solution(int[] arr)
{
    int p = 1;
    while (p <= 2)
    {
        int last = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[arr.Length  - 1] = last;
        p++;
    }
    return arr;
}