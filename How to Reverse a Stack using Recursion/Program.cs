

int[] arr = { 1, 2, 3, 4 };
solution(arr);
Console.ReadKey();
void solution(int[] arr)
{
    Stack<int> stack = new Stack<int>();
	for (int i = 0; i < arr.Length; i++)
	{
        stack.Push(arr[i]);
    }
	foreach (var item in stack)
	{
		Console.Write(item + " ");
	}

}

