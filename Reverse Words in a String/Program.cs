

using System.Text;

string s = "  hello world  ";
string res = solution(s);
Console.WriteLine(res);
Console.ReadKey();

string solution(string s)
{
    StringBuilder sb = new StringBuilder();
    string[] sArray = s.Split(' ');
    if (s.Length == 0)
        return s;
    for (int i = sArray.Length - 1; i >= 0; i--)
    {
        if (sArray[i] != "")
        {
            if(i != 0)
            {
                sb.Append(sArray[i] + " ");
            }
            else
            {
                sb.Append(sArray[i]);
            }
        }
    }
    return sb.ToString();
}
