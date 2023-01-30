
int[] arr = { 2, 4, 5, 6, 1, 3, 8, 15, 13 ,15};
int first = int.MinValue;
int second = int.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > first)
    {
        second = first;
        first = arr[i];
    }
    else if (arr[i] > second && first != arr[i])
    {
        second = arr[i];
    }
}
Console.Write(second);
Console.ReadKey();
