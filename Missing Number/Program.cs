
int[] arr = { 1, 3, 4 };
int res = solution_01(arr);
Console.WriteLine(res);
Console.ReadKey();

// time O(N)
// space O(1)
int solution(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    int n = arr.Length + 1;
    int totalSum = n * (n + 1) / 2;
    return totalSum - sum;
}

// time O(N)
// space O(N)
int solution_01(int[] nums)
{
    HashSet<int> visited = new HashSet<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        visited.Add(arr[i]);
    }
    for (int i = 1; i < nums.Length + 1; i++)
    {
        if (!visited.Contains(i))
        {
            return i;
        }
    }
    return -1;
}

