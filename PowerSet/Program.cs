
List<int> arr = new List<int> { 1, 2, 3 };
var list = solution(arr);
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.ReadKey();

List<List<int>> solution(List<int> array)
{
    List<List<int>> subsets = new List<List<int>>();
    subsets.Add(new List<int>());
    foreach (var ele in array)
    {
        int length = subsets.Count;
        for (int i = 0; i < length; i++)
        {
            List<int> currentSubset = new List<int>(subsets[i]);
            currentSubset.Add(ele);
            subsets.Add(currentSubset);
        }
    }
    return subsets;
}
