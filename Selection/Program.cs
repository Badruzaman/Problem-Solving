

int[] arr = { 2, 4, 1, 5, 0, 6, 3 };
int[] result = selection(arr);
foreach (int i in result)
{
    Console.Write(i + " ");
}
Console.ReadKey();

int[] selection(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int minIdx = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[minIdx] > arr[j])
            {
                minIdx = j;
            }
        }
        swap(arr, i, minIdx);
    }
    return arr;
}
int[] swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
    return arr;
}