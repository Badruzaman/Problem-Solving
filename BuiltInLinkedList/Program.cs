

LinkedList<string> list = new LinkedList<string>();
list.AddLast("a");
list.AddLast("b");
list.AddLast("c");
list.AddLast("d");
list.AddLast("e");
Console.WriteLine("Add Last");

foreach (string item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("Add First");
LinkedList<string> listfirst = new LinkedList<string>();
listfirst.AddFirst("a");
listfirst.AddFirst("b");
listfirst.AddFirst("c");
listfirst.AddFirst("d");
listfirst.AddFirst("e");

foreach (string item in listfirst)
{
    Console.WriteLine(item);
}
Console.ReadKey();