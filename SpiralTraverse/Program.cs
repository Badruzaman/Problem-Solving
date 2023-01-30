

using System.Diagnostics;

int[,] input = {
            {1, 2, 3, 4},
            {12, 13, 14, 5},
            {11, 16, 15, 6},
            {10, 9, 8, 7},
        };

var result = new List<int>();
int startRow = 0;
int endRow = input.GetLength(0) - 1;
int startCol = 0;
int endCol = input.GetLength(1) - 1;

for (int i = 0; i <input.GetLength(0); i++)
{
    for (int j = 0; j < input.GetLength(1); j++)
    {
        Console.Write(input[i,j] + " ");
    }
}
var stus = "SC. BW, RCC Drain, Misc. & Doc. Charges Paid,  Mutation & tax Update. ";
if (!string.IsNullOrEmpty(stus))
{
    Console.WriteLine("empty");
}

Console.ReadKey();