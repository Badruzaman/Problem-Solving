
int result = StaircaseTraversal(4, 2);
Console.WriteLine(result);
Console.ReadKey();

int StaircaseTraversal(int height, int Maxstep)
{
    if(height <= 1)
    {
        return 1;
    }
    int NumberOfWays = 0;
    for (int step = 1; step < Math.Min(Maxstep, height) + 1; step++)
    {
        NumberOfWays += StaircaseTraversal(height - step, Maxstep);
    }
    return NumberOfWays;
}
