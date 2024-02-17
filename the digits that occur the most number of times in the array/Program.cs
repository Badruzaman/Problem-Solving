
int[] result = solution();
foreach (var item in result)
{
	Console.Write(item + " ");
}
Console.ReadKey();

int[] solution()
{
	int[] arr = { 25, 2, 3, 57, 38, 41 };
	int[] counts = new int[10];
	for (int i = 0; i < arr.Length; i++)
	{
		int currentNum = arr[i];
		while (currentNum > 0)
		{
			int remainder = currentNum % 10;
			counts[remainder]++;
            currentNum /= 10;
		}
	}
	List<int> list = new List<int>();
    int maxCount = counts.Max();
    for (int i = 0; i < 10; i++)
	{
		if (counts[i] == maxCount)
		{
			list.Add(i);
		}
	}
	list.Sort();
	return list.ToArray();
}
