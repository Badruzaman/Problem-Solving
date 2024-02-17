

using System.Runtime.CompilerServices;

string[] input = { "abc", "bcd", "cbaccd" };
//var result = solution(input);
//foreach (var item in result)
//{
// Console.WriteLine(item);
//}
string[] res = solution03(input);
foreach (var item in res)
{
    Console.WriteLine(item);
}

Console.ReadKey();
List<char> solution(string[] words)
{
    HashSet<char> commonChars = new HashSet<char>(words[0]);
    for (int i = 1; i < words.Length; i++)
    {
        HashSet<char> wordChars = new HashSet<char>(words[i]);
        commonChars.IntersectWith(wordChars);
    }
    string[] result = new string[commonChars.Count];
    int j = 0;
    foreach (var item in commonChars)
    {
        result[j++] = item.ToString();
    }

    return commonChars.ToList();
}

List<string> solution01(string[] words)
{
    string firstWord = words[0];
    HashSet<char> commonChars = new HashSet<char>(firstWord);
    foreach (var c in commonChars)
    {
        for (int i = 1; i < words.Length; i++)
        {
            bool result = isCharExist(words[i], c);
        }
    }
    return new List<string>();
}

bool isCharExist(string word, char c)
{
    if (word.Contains(c))
    {
        return true;
    }
    return false;
}
string[] solution03(string[] words)
{
    HashSet<char> commonChars = new HashSet<char>(words[0]);
    for (int i = 1; i < words.Length; i++)
    {
        HashSet<char> wordChars = new HashSet<char>(words[i]);
        commonChars.IntersectWith(wordChars);
    }
    string[] result = new string[commonChars.Count];
    //var arr = commonChars.ToArray();
    //for (int i = 0; i < arr.Length; i++)
    //{
    //    result[i] = arr[i].ToString();
    //}
    int j = 0;
    foreach (var item in commonChars)
    {
        result[j++] = item.ToString();
    }
    return result;
}

