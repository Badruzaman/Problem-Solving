
int[] array = { 0, 4, 0, 5, 6, 0, 0 };
int toMove = 0;
int left = 0;
int right = array.Length - 1;

while (left < right)
{
    while (left < right && array[right] == toMove)
    {
        right--;
    }
    if (array[left] == toMove)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;
    }
    left++;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.ReadKey();