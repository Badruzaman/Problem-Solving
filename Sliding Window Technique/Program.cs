
int[] numbers = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
int k = 4;
int max_sum = int.MinValue;
int len = numbers.Length;
for (int i = 0; i <= len - k; i++)
{
    int current_sum = 0;
    for (int j = 0; j < k; j++)
    {
        current_sum += numbers[i + j];
    }
    max_sum = Math.Max(current_sum, max_sum);
}
Console.Write(max_sum);
Console.WriteLine();

int maxsum = 0;
for (int i = 0; i < k; i++)
    maxsum += numbers[i];

int window_sum = maxsum;
for (int i = k; i < len; i++)
{
    window_sum += numbers[i] - numbers[i - k];
    maxsum = Math.Max(maxsum, window_sum);
}
Console.Write($"Second output : {maxsum}");
Console.ReadKey();
