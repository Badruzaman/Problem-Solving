
using System.Text;

string str = "462839";
int numDigit = 2;
string result = solution(str, numDigit);
Console.Write(result);
Console.ReadKey();

string solution(string number, int numdigit)
{
    Stack<char> stack = new Stack<char>();
    for (int i = 0; i < number.Length; i++)
    {
        char character = number[i];
        while (numDigit > 0 && stack.Count > 0 && character > stack.Peek())
        {
            numDigit--;
            stack.Pop();
        }
        stack.Push(character);
    }
    while (numDigit > 0)
    {
        numDigit--;
        stack.Pop();
    }
    StringBuilder stringBuilder = new StringBuilder();
    while (stack.Count > 0)
    {
        stringBuilder.Append(stack.Pop());
    }
    var charArray = stringBuilder.ToString().ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}