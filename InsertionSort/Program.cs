int[] arr = { 2, 4, 5, 6, 1, 3, 8, 15, 13, 15 };
for (int i = 1; i < arr.Length; i++)
{
    int j = i;
    while (j > 0 && arr[j] < arr[j - 1])
    {
        int temp = arr[j];
        arr[j] = arr[j - 1];
        arr[j-1] = temp;
        j--;
    }
}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(" " + arr[i]);
}
Console.ReadKey();