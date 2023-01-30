

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int start = 0;
int end = arr.Length;
int target = 3;
int restult = binarySearch(arr, start, end, target);
Console.Write(restult);
Console.ReadKey();
//int binarySearch(int[] arr, int start, int end, int target)
//{
//    if (start > end)
//        return -1;
//    else
//    {
//        int mid = (start + end) / 2;
//        if (arr[mid] == target)
//        {
//            return mid;
//        }
//        else if (arr[mid] < target)
//        {
//            return binarySearch(arr, mid + 1, end, target);
//        }
//        else
//        {
//            return binarySearch(arr, start, mid - 1, target);
//        }
//    }
//}
int binarySearch(int[] arr, int start, int end, int target)
{
    while (start <= end)
    {
        int mid = (start + end) / 2;
        if (arr[mid] == target)
        {
            return mid;
        }
        else if (arr[mid] < target)
        {
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        }
    }
    return -1;
}