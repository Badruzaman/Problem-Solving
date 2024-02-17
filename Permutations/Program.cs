
using System;

Account account = new Account();
account.Balance = 100;
var result = account.CalculateInterest("Saving");
Console.WriteLine(result);
Console.ReadKey();  

public class Account
{
    public string Name { get; set; }
    public string Address { get; set; }
    public double Balance { get; set; }

    public double CalculateInterest(string type)
    {
        if(type == "Saving")
        {
            return Balance * .5;
        }
        else
        {
            return Balance * .7;
        }
    }
}