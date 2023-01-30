


int[] arr = new int[] { 1, 2, 3, 7, 5 };
int s = 15;
List<int> result = solution(arr, s);
for (int i = 0; i < result.Count; i++)
{
    Console.Write(result[i] + " ");
}
Console.ReadKey();

List<int> solution(int[] arr, int s)
{
    int left = 0;
    int right = 0;
    int current_sum = arr[0];
    while (right < arr.Length)
    {
        if (current_sum == s)
        {
            return new List<int> { left + 1, right + 1 };
        }
        else if (current_sum < s)
        {
            right += 1;
            if (right == arr.Length)
            {
                break;
            }
            current_sum += arr[right];
        }
        else
        {
            current_sum -= arr[left];
            left += 1;
        }
    }
    return new List<int> { -1, -1 };
}