
int n = 9;
int[] res = generateFibonacci(n);
foreach (int i in res)
{
    Console.Write(i + " ");
}
Console.ReadKey();

int solution(int n)
{
    if(n == 1)
    {
        return 0;
    }
    else if(n == 2)
    {
        return 1;
    }
    else
    {
        return solution(n - 2) + solution(n - 1);
    }
}

int[] generateFibonacci(int n)
{
    
    int num = 0;
    int[] fibo = new int[n];
    for (int i = 1; i <= n; i++)
    {
        num = solution(i);
        fibo[i-1] = num;
    }
    return fibo;
}