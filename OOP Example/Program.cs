// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public abstract class Customer
{
    public string Name { get; set; }
    public string CustomerId { get; set; }
    public string Address { get; set; }
    public abstract void TotalAmount();

}
public class SavingsAccount : Customer
{
    public override void TotalAmount()
    {
        //logic to calculate the amount here 
    }
}

public class CurrentAccount : Customer
{
    public override void TotalAmount()
    {
        //logic to calculate the amount here 
    }
}