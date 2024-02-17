
int[] arr = { 2, 4, 5, 6, 1, 3, 8, 15, 13, 15 };
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
    if (i < arr[minIdx])
    {
        int temp = arr[i];
        arr[i] = arr[minIdx];
        arr[minIdx] = temp;
    }

}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(" " + arr[i]);
}
Console.ReadKey();