

using System.ComponentModel.Design;
using System.Text.RegularExpressions;

string sen = "Hello world123 567";
string reuslt = solution(sen);
Console.WriteLine(reuslt);
Console.ReadKey();

string solution(string sen)
{
    int wordLength = 0;
    string longestWord = string.Empty;
   // string sentence = Regex.Replace(sen,@"");

    string[] words = sen.Split(' ');
    foreach (string word in words)
    {
        int currentWordLength = word.Length;
        if (wordLength < currentWordLength)
        {
            wordLength = currentWordLength;
            longestWord = word;
        }
    }
    return longestWord;
}

