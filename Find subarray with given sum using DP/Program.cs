

List<int> arr = new List<int> { 1, 4, 0, 0, 3, 10, 5 };
int sum = 7;
solution(arr, sum);
Console.ReadKey();

void solution(List<int> arr, int sum)
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    List<int> subArray = new List<int>();
    int currSum = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        currSum += arr[i];
        int val = currSum - sum;
        if(map.ContainsKey(val))
        {
            subArray = arr.GetRange(map[val] + 1, i - map[val]);
        }
        map[currSum] = i;
    }
    foreach (int item in subArray)
    {
        Console.Write(item + " ");
    }
}