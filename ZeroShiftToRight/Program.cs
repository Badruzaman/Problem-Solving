
int[] arr = { 1, 0, 3, 0, 0, 2, 4, 0 };
int[] result = solution01(arr);
foreach (int item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

int[] solution(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            arr[count++] = arr[i];
        }
    }
    while (count < arr.Length)
        arr[count++] = 0;
    return arr;
}

int[] solution01(int[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            j++;
        }
    }
    return arr;
}