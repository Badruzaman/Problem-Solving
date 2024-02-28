
var list = new List<int> { 2, 4, 1, 4, 3, 3 };
int third = getThirdLargest(list);
Console.Write($"Third element is {third}");

//int[] arr = { 2, 4, 1, 5, 0, 6, 3 };
//int[] result = insertion(arr);
//foreach (int i in result)
//{
//    Console.Write(i + " " );
//}
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


 int getThirdLargest(List<int> list)
{
    int first = int.MinValue;
    int second = int.MinValue;
    int third = int.MinValue;
    for (int i = 0; i < list.Count; i++)
    {
        int currentNum = list[i];
        if (first < currentNum)
        {
            third = second;
            second = first;
            first = currentNum;
        }
        else if (second < currentNum & currentNum > first)
        {
            third = second;
            second = currentNum;
        }
        else if (third < currentNum && second > third)
        {
            third = currentNum;
        }
    }
    return third;
}