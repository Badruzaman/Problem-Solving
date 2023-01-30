
using System.Collections;

ArrayList arrayList = new ArrayList();
int[] arr = new int[2] { 2, 5 };
arrayList.Add(45);
arrayList.Add("Zaman");
arrayList.Add(arr);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}
Console.ReadKey();

