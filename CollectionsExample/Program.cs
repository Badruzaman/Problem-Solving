

using System.Collections;

ArrayList al = new ArrayList();
string str = "kiran teja jallepalli";
int x = 7;
DateTime d = DateTime.Parse("8-oct-1985");
al.Add(str);
al.Add(x);
al.Add(d);

foreach (object o in al)
{
    Console.WriteLine(o);
}

ICollection<int> ints = new List<int>() { 4,5,1,6,4};

foreach (int ite in ints)
{
    Console.WriteLine(ite);
}
ICollection<float> floats = new List<float>();



Console.ReadKey();

