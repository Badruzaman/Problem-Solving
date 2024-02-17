
int[] arr = { 4, 3, 6, 3, 2, 1 };
bool result = solution(arr);
Console.WriteLine(result);
Console.ReadKey();

// nlogn time
// o(1)
bool solution(int[] arr)
{
    Array.Sort(arr);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            return true;
        }
    }
    return false;
}

// time o(n^2)
// space o(1)
bool solution01(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                return true;
            }
        }
    }
    return false;
}