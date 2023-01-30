

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
for (int i = 0; i < stack.Count; i++)
{
    Console.WriteLine(stack.ElementAt(i));
}

Console.ReadKey();
