

int res = FindMaxDigitFrequency(1225622);
Console.WriteLine(res);
Console.ReadKey();

int solution(int num)
{
    Dictionary<char, int> digitCount = new Dictionary<char, int>();
    string str = num.ToString();
    for (char digit = '0'; digit <= '9'; digit++)
    {
        digitCount[digit] = 0;
    }
    foreach (char digit in str)
    {
        if (char.IsDigit(digit))
        {
            if (digitCount.ContainsKey(digit))
            {
                digitCount[digit]++;
            }
        }
    }
    return digitCount.Max(it => it.Value);
}

int FindMaxDigitFrequency(int number)
{
    // Initialize an array to store the count of each digit (0-9)
    int[] digitCount = new int[10];

    // Initialize maximum frequency and the digit with the maximum frequency
    int maxFrequency = 0;
    int maxDigit = 0;

    // Process each digit in the number
    while (number > 0)
    {
        int digit = number % 10; // Get the last digit
        digitCount[digit]++;    // Increment the count for that digit

        // Check if the current digit has a higher frequency
        if (digitCount[digit] > maxFrequency)
        {
            maxFrequency = digitCount[digit];
            maxDigit = digit;
        }

        number /= 10; // Remove the last digit
    }

    return maxFrequency;
}