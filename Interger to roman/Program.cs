
using System.Text;
int num = 1994; // Example integer
char[] romanNumeral = IntToRoman(num);
Console.WriteLine(romanNumeral);
Console.ReadKey();
 char[] IntToRoman(int num)
{
    int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    StringBuilder result = new StringBuilder();
    int i = 0;
    while (num > 0)
    {
        while (num >= values[i])
        {
            num -= values[i];
            result.Append(symbols[i]);
        }
        i++;
    }
    //char[] chars = new char[result.Length];
    //for (int j = 0; j < result.Length; j++)
    //{
    //    chars[j] = result[j];
    //}
    char[] chars = result.ToString().ToCharArray();
    return chars;
}





