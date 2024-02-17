

int[] arr = { 3, 5, 6, 2, 1 };
int[] result = solution(arr);
foreach (int item in result)
{
    Console.Write(result + " ");
}
Console.ReadKey();

int[] solution(int[] arr)
{
    int left = 0;
    int right = arr.Length - 1;
    while (left < right)
    {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
    }
    return arr;
}