
int[] arr = { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6 };
int result = getResult(arr);
//foreach (var item in result)
//{
//Console.Write(item + " ");
//}
Console.Write(result);
Console.ReadKey();

int getResult(int[] arr)
{
    Array.Sort(arr);
    //[0,1,2,3,4,5,6,7,10,11,12,15]
    int counter = 0;
    int max = int.MinValue;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] + 1 == arr[i + 1])
        {
            counter++;

        }
        else
        {
            counter = 1;
            if (counter > max)
            {
                max = counter;
            }
        }
    }
    return max;
}