

int res = solution(1225622);
Console.WriteLine(res);
Console.ReadKey();

int solution(int num)
{
    Dictionary<char, int> digitCount = new Dictionary<char, int>();
    string str = num.ToString();
    foreach (char digit in str)
    {
        if (char.IsDigit(digit))
        {
            if (!digitCount.ContainsKey(digit))
            {
                digitCount[digit]=0;
            }
            digitCount[digit]++;
        }
    }
    var res = digitCount.MaxBy(it => it.Value).Key;
    int number;
    bool success = int.TryParse(res.ToString(), out number);
    return number;
}

int FindMaxDigitFrequency(int number)
{
    int[] digitCount = new int[10];
    int maxFrequency = 0;
    int maxDigit = 0;
    while (number > 0)
    {
        int digit = number % 10; 
        digitCount[digit]++;  
        if (digitCount[digit] > maxFrequency)
        {
            maxFrequency = digitCount[digit];
            maxDigit = digit;
        }
        number /= 10; 
    }
    return maxFrequency;
}