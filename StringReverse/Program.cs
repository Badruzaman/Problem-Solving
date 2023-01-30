
string str = "Badruzzaman";
string result = getResult(str);
Console.WriteLine(result);
Console.ReadKey();

string getResult(string arr)
{
    string output = string.Empty;
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        output += arr[i];
    }
    return output;
}

