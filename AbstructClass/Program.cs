
EmpImplementation empImplementation = new EmpImplementation("Badru", "Zaman","badru.cse@gmail.com");
string result = empImplementation.GetEmployeeName();
Console.WriteLine(result +" and salary "+ empImplementation.getSalary());
Console.ReadKey();
public abstract class Employee
{
    public string FistName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Employee(string fistName, string lastName, string email)
    {
        FistName = fistName;
        LastName = lastName;
        Email = email;
    }

    public decimal getSalary()
    {
        return 10000;
    }
    internal abstract string GetEmployeeName();
}

public class EmpImplementation : Employee
{
    public EmpImplementation(string firstName, string lastName, string  email) : base(firstName, lastName, email) 
    {

    }
    internal override string GetEmployeeName()
    {
        return FistName + " " + LastName;
    }
}

