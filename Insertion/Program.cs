


int[] arr = { 2, 4, 1, 5, 0, 6, 3 };
int[] result = insertion(arr);
foreach (int i in result)
{
    Console.Write(i + " " );
}
Console.ReadKey();
int[] insertion(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int j = i;
        while (j > 0 && arr[j] < arr[j - 1])
        {
            swap(arr, j - 1, j);
            j--;
        }
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