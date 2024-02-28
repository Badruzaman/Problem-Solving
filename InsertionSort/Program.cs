
int[] arr = { 2, 4, 5, 6, 1, 3, 8, 15, 13, 15 };
for (int i = 1; i < arr.Length; i++)
{
    int j = i;
    while (j > 0 && arr[j] < arr[j - 1])
    {
        int temp = arr[j];
        arr[j] = arr[j - 1];
        arr[j - 1] = temp;
        j--;
    }
}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(" " + arr[i]);
//}

//var list = new List<int> { -2, -4, -1, -4, -3, -3, -2, -5, -8 };
// -1,-2,-3,-4,-5,-8
// O(n) // space 
// o(nlogn) time
//var unique_nums = new HashSet<int>(list).ToList();
//var sorted_nums = unique_nums.OrderBy(it => it).ToList();
//var thirdlargest = sorted_nums[sorted_nums.Count - 2];
//int third = getThirdLargest(list);
//Console.Write(third);

Console.ReadKey();

// O(n)
// O(1)
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
        else if (second < currentNum && currentNum < first)
        {
            third = second;
            second = currentNum;
        }
        else if (third < currentNum && currentNum < second)
        {
            third = currentNum;
        }
    }
    return third;
}