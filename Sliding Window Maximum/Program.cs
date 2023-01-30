

int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
int k = 3;
int[] result = solution(nums, k);
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}
Console.ReadKey();
int[] solution(int[] nums, int k)
{
    Queue<int> q = new Queue<int>();
    int[] result = new int[nums.Length - k + 1];
    for (int i = 0; i < nums.Length; i++)
    {
        // remove elements that are out of the window
        while (q.Count > 0 && i - q.Peek() >= k)
        {
            q.Dequeue();
        }
        // remove elements that are smaller than the current element
        while (q.Count > 0 && nums[q.Peek()] <= nums[i])
        {
            q.Dequeue();
        }
        // add the current element to the window
        q.Enqueue(i);
        // add the maximum element to the result array if the window is filled
        if (i >= k - 1)
        {
            result[i - k + 1] = nums[q.Peek()];
        }
    }
    return result;
}

