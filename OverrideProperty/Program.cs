
//BaseClass instance = new DerivedClass();
//string value = instance.Name; // Calls the overridden getter
//instance.Name = "derived";

DerivedClass derivedClass = new DerivedClass();
derivedClass.Id = 50;
BaseClass baseClass = new BaseClass();
Test test = new Test(2);
Console.WriteLine(baseClass.Id);
Console.WriteLine(derivedClass.Id);
Console.ReadKey();

//public class BaseClass
//{
//    public virtual string Name 
//    {
//        get { return "Base"; }
//        set { Console.WriteLine("BaseClass setter called."); }
//    }
//}
//public class DerivedClass : BaseClass
//{
//    public override string Name 
//    {
//        get
//        {
//            Console.WriteLine("DerivedClass getter called.");
//            return base.Name; // Call the base implementation
//        }
//        set { Console.WriteLine("DerivedClass setter called."); }
//    }
//}

internal class BaseClass
{
    private int _id = 10;
    internal virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    int _id2 = 20;
    internal int code
    {
        get { return _id2; }
        set { _id2 = value; }
    }

}
internal class DerivedClass : BaseClass
{
    internal override int Id
    {
        get
        {
            return base.Id;
        }
        set
        {
            base.Id = value;
        }
    }
}

public abstract class AbsClass
{
    public AbsClass()
    {

    }
    public AbsClass(int i)
    {

    }
    public AbsClass(double i)
    {

    }
    public int getValue()
    {
        return 0;
    }
    public abstract int get();
}

public class Test : AbsClass
{
    public Test(double i) : base(i)
    {

    }
    public override int get()
    {
        throw new NotImplementedException();
    }
}