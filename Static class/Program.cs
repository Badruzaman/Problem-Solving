

EmployeePaymentCalculation employeePaymentCalculation = new EmployeePaymentCalculation("Badruzzaman", 100);
EmployeePaymentCalculation employeePayment = new EmployeePaymentCalculation("Rahman", 200);
var employeeList = new List<EmployeePaymentCalculation> { employeePaymentCalculation, employeePayment };
foreach (var item in employeeList)
{
    item.Print();
}
EmployeeBasic employeeBasic = new EmployeeBasic("Md Ali", 100, 1200);
employeeBasic.Print();
Console.ReadKey();

public class EmployeePaymentCalculation
{
    public EmployeePaymentCalculation(string name,double promotionSalary)
    {
        this.promotionSalary = promotionSalary;
        this.Name = name;
    }
    public string Name { get; set; }
    public double promotionSalary { get; set; }
    public double Salary
    {
        get { return promotionSalary * 10; }
    }
    public virtual void Print()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Salary);
    }
}

public class EmployeeBasic : EmployeePaymentCalculation
{
    private double _basicSalary;
    public EmployeeBasic(string name, double promotionSalary, double basicSalary) : base(name, promotionSalary)
    {
        _basicSalary = basicSalary;
    }
    public override void Print()
    {
        Console.WriteLine(Name);
        Console.WriteLine(_basicSalary);
    }

}