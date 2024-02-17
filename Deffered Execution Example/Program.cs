
Permanent permanent = new Permanent();
IEmployee employee = new Permanent();
permanent.CalculateBonus(1000);
permanent.ProcessSalary(10000);
permanent.DateOfBirth = DateTime.Now;

List<int> numbers = new List<int> { 1, 2, 3, 4 };
var evenNumbers = numbers.Where(it => it % 2 != 0);
numbers.Add(5);
Console.Write(string.Join(", ", evenNumbers));
Console.ReadKey();

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public abstract Decimal CalculateBonus(decimal amount);
    public DateTime DateOfBirth { get; set; }
}

public interface IEmployee
{
    decimal ProcessSalary(decimal amount);
}

public class Permanent : Employee, IEmployee
{
    public override Decimal CalculateBonus(decimal amount)
    {
        return amount * .1M;
    }
   public decimal ProcessSalary(decimal amount)
    {
        return amount + 10;
    }
}
public class Contract : Employee
{
    public override Decimal CalculateBonus(decimal amount)
    {
        return amount * .01M;
    }
}