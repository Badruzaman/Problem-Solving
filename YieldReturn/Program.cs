
//var numbers = GetOneTwoThree();
//foreach (var number in numbers)
//{
//    Console.Write(number + " ");
//}

//IEnumerable<int> GetOneTwoThree()
//{
//    yield return 1;
//    yield return 2;
//    yield return 3;
//}

int[] arr = { 1, 2, 3, 5, 6, 2, 3 };
int result = solution_02(arr);
Console.WriteLine(result);
Console.ReadKey();
int solution(int[] arr)
{
    int minSecondIndex = arr.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                minSecondIndex = Math.Min(minSecondIndex, j);
            }
        }
    }
    if (minSecondIndex == arr.Length)
    {
        return -1;
    }
    return arr[minSecondIndex];
}
// time O(N) space O(N)
int solution_01(int[] arr)
{
    HashSet<int> seen = new HashSet<int>();
    foreach (int num in arr)
    {
        if (seen.Contains(num))
        {
            return num;
        }
        seen.Add(num);
    }
    return -1;
}

// time O(N) Space O(1)
int solution_02(int[] array)
{
    // { 1, 2, 3, 5, 6, 2, 3 };
    foreach (var value in array)
    {
        int absValue = Math.Abs(value);
        if (array[absValue - 1] < 0)
        {
            return absValue;
        }
        array[absValue - 1] *= -1;
        int val = array[absValue - 1];
    }
    return -1;
}
