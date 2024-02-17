

int[] arr = { 3, 2, 4, 8, 1 };
int[] result = solution(arr);
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}
Console.ReadKey();

int[] solution(int[] arr)
{
    int start = 0;
    int end = arr.Length - 1;
    while (start < end)
    {
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
    return arr;
}

string solution01(string str)
{
    int start = 0;
    int end = arr.Length - 1;
    while (start < end)
    {
        char temp = str[start];
        //str[start] = temp.ToString();
        //str[start] = str[end];
        //str[end] = temp;
        start++;
        end--;
    }
    return str;
}