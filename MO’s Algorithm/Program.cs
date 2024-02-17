

using System.Collections;

int[] a = { 1, 1, 2, 1, 3, 4, 5, 2, 8 };
int n = a.Length;
ArrayList q = new ArrayList();
q.Add(new Query(0, 4));
q.Add(new Query(1, 3));
q.Add(new Query(2, 4));
int m = q.Count;
printQuerySums(a, n, q, m);
Console.ReadKey();

// O(mn)
// O(1)
void printQuerySums(int[] a, int n, ArrayList q, int m)
{
    for (int i = 0; i < m; i++)
    {
        int L = ((Query)q[i]).L;
        int R = ((Query)q[i]).R;
        int sum = 0;
        for (int j = L; j <= R; j++)
            sum += a[j];
        Console.Write("Sum of [" + L + ", " + R + "] is " + sum + "\n");
    }
}
class Query
{
    public int L;
    public int R;
    public Query(int L, int R)
    {
        this.L = L;
        this.R = R;
    }
}

