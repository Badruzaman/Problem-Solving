
using Interview.LargestElements;

var list = new List<int> { 2, 4, 1, 4, 3, 3 };

int third = ILargest.getThirdLargest(list);
Console.WriteLine($"Third Largest {third}");
Console.ReadKey();
