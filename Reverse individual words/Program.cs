
string str = "Hello World";
solution01(str);
Console.ReadKey();
void solution(string str)
{
    Stack<char> stack = new Stack<char>();
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')
        {
            stack.Push(str[i]);
        }
        else
        {
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
    while (stack.Count > 0)
    {
        Console.Write(stack.Pop());
    }
}
void solution01(string str)
{
    foreach (string w in str.Split(' '))
    {
        var word = new string(w.Reverse().ToArray());
        Console.Write(word + " ");
    }
}
