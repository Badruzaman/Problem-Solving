


int input = 1331;
bool result = solution(input);
Console.Write(result);
Console.ReadKey();

bool solution(int Num)
{
    int sum = 0;
    int orginalNum = Num;
    while (Num > 0)
    {
        int remainder = Num % 10;
        sum = sum * 10 + remainder;
        Num /= 10;
    }
    return orginalNum == sum;
}

