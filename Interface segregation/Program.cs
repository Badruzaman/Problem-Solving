BusinessInkjetPrinter businessInkjetPrinter = new BusinessInkjetPrinter();
businessInkjetPrinter.Print("hello inkjet printer ");
businessInkjetPrinter.Scan();
Console.ReadKey();
public interface IPrinter
{
    void Print(string message);
    //void Scan();
}
public interface IScanner
{
    void Scan();
}
public class BusinessInkjetPrinter : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
    public void Scan()
    {
        Console.WriteLine("scanned");
    }
}
public class HomeInkjetPrinter : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
    //public void Scan()
    //{
    //    throw new NotImplementedException();
    //}
}