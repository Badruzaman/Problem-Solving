
int[] arr = { 5, 2, 9, 3, 6, 1 };
QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine("Sorted Array:");
foreach (int num in arr)
    Console.Write(num + " ");
Console.ReadKey();
void QuickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        int pivotIndex = Partition(arr, low, high);
        QuickSort(arr, low, pivotIndex - 1);
        QuickSort(arr, pivotIndex + 1, high);
    }
}

int Partition(int[] arr, int low, int high)
{
    // Choose the rightmost element as the pivot
    int pivotNum = arr[high];
    // Index of the smaller element
    int i = low - 1;
    for (int j = low; j < high; j++)
    {
        if (arr[j] < pivotNum)
        {
            i++;
            swap(arr, i, j);
        }
    }
    swap(arr, i + 1, high);
    return i + 1;
}

void swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
