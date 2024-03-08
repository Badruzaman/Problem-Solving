

int[] arr = { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
int result = solution(arr);
Console.WriteLine(result);
Console.ReadKey();
int solution(int[] arr)
{
    int res = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        res = Math.Max(res, arr[i]);
    }
   return res;
}