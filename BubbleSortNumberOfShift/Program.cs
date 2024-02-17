
int[] arr = { 1, 3, 6, 2 ,4};
//int[] result = solution(arr);
//foreach (int item in arr)
//{
//    Console.Write(item + " ");
//}
int result = solution01(arr);
Console.WriteLine(result);
Console.ReadLine();

//int[] solution(int[] arr)
//{
//    bool isSorted = false;
//    int counter = 0;
//    while (!isSorted)
//    {
//        isSorted = true;
//        for (int i = 0; i < arr.Length - 1 - counter; i++)
//        {
//            if (arr[i] > arr[i + 1])
//            {
//                int temp = arr[i];
//                arr[i] = arr[i + 1];
//                arr[i + 1] = temp;
//                isSorted = false;
//            }
//        }
//        counter++;
//    }
//    return arr;
//}
int solution01(int[] arr)
{
    int[] newarr = new int[arr.Length];
    Array.Copy(arr, newarr, arr.Length);
    Array.Sort(arr);
    
    return 1;
}
