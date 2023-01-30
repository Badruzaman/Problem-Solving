

int[] arr = { 2, 4, 5, 6, 1, 3, 8, 15, 15 };
int first = int.MinValue;
int second = int.MinValue;
int third = int.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > first)
    {
        third = second;
        second = first;
        first = arr[i];
    }
    else if (arr[i] > second)
    {
        third = second;
        second = arr[i];
    }
    else if (arr[i] > third)
    {
        third = arr[i];
    }
}
Console.Write(first + " " + second + " " + third);
Console.ReadKey();
