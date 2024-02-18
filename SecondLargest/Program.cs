
int[] array = new int[] { -4, -2, -4, -3 };
//Array.Sort(array);
//Console.WriteLine(array[array.Length-2]);
int result = SecondLargest_01(array);
Console.WriteLine(result);
Console.ReadKey();
int SecondLargest(int[] array)
{
    int second = 0;
    int max = int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            second = max;
            max = array[i];
        }
        else if (second < array[i] && array[i] != max)
        {
            second = array[i];
        }
    }
    return second;
}
int SecondLargest_01(int[] array)
{
    int max = int.MinValue;
    int secondLargest = int.MinValue; 
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    foreach (int item in array)
    {
        if(max != item)
        {
            secondLargest = Math.Max(secondLargest, item);
        }
    }
    return secondLargest;
}