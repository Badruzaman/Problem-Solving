
int[] array = new int[] { 3, 2, 4, -4 };
//Array.Sort(array);
//Console.WriteLine(array[array.Length-2]);
int result = SecondLargest(array);
Console.WriteLine(result);
Console.ReadKey();

int SecondLargest(int[] array)
{
    int second = int.MinValue;
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            second = max;
            max = array[i];
        }
        else if (second < array[i])
        {
            second = array[i];
        }
    }
    return second;
}
