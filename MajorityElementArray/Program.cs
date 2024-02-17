

int[] arr = { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
int result = solution01(arr);
Console.WriteLine(result);
Console.ReadKey();



int solution(int[] arr)
{
    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
    foreach (int item in arr)
    {
        if (keyValuePairs.ContainsKey(item))
        {
            int count = keyValuePairs[item] + 1;
            if(count > arr.Length / 2)
            {
                return item;
            }
            else
            {
                keyValuePairs[item] = count;
            }
        }
        else
        {
            keyValuePairs[item] = 1;
        }
    }
    //foreach (var item in keyValuePairs)
    //{
    //    if(item.Value > arr.Length / 2)
    //    {
    //        return item.Key;
    //    }
    //}
    return -1;
}
int solution01(int[] arr)
{
    int count = 0, max_ele = -1,
            temp = arr[0], ele = 0,
               f = 0;
    Array.Sort(arr);
    for (int i = 1; i < arr.Length; i++)
    {
        if(temp == arr[i])
        {
            count++;
        }
        else
        {
            count = 1;
            temp = arr[i];
        }
        if(max_ele < count)
        {
            max_ele = count;
            ele = arr[i];
            if (max_ele > (arr.Length / 2))
            {
                f = 1;
                break;
            }

        }
    }
    return (f == 1 ? ele : -1);
}