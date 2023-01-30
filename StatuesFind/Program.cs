

int[] arr = new int[] { 25, 2, 3, 57, 38, 41 };

int[] result = solution(arr);
foreach (var item in result)
{
    Console.Write(item + " ");
}

Console.ReadKey();


int[] solution(int[] a)
{
    Dictionary<string, int> dic = new Dictionary<string, int>();
    int[] output = new int[arr.Length];
    for (int i = 0; i < a.Length; i++)
    {
        string currentValues = a[i].ToString();
        foreach (var num in currentValues)
        {
            if (!dic.ContainsKey(num.ToString()))
            {
                dic.Add(num.ToString(), 1);
            }
            else
            {
                dic[num.ToString()] += 1;
            }
        }
    }
    int j = 0;
    foreach (var item in dic)
    {
        if (item.Value > 1)
        {
            output[j] = Convert.ToInt16(item.Key);
            j++;
        }
    }
 
    return output;
    
}