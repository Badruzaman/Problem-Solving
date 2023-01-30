

int[] arr = { 2, 1, 2, 2, 2, 3, 4, 2 };
int toMove = 2;
int[] result = MoveElementToEnd(arr);
foreach (int item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

int[] MoveElementToEnd(int[] arr)
{
    int left = 0;
    int right = arr.Length - 1;
    while (left < right)
    {
        while (left < right && arr[right] == toMove)
        {
            right--;
        }
        if (arr[left] == toMove)
        {
            swap(left, right, arr);
        }
        left++;
    }
    return arr;
}
void swap(int left, int right, int[] arr)
{
    int temp = arr[left];
    arr[left] = arr[right];
    arr[right] = temp;
}