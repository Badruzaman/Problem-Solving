

Account account = new Account();
account.Balance = 100;
SavingAccount saveAcc = new SavingAccount();
double res = saveAcc.CalculateInterest(account);
Console.WriteLine(res);
Console.ReadKey();
public class Account
{
    public string Name { get; set; }
    public string Address { get; set; }
    public double Balance { get; set; }
    //public double CalculateInterest(string type)
    //{
    //    if (type == "Saving")
    //    {
    //        return Balance * .5;
    //    }
    //    else
    //    {
    //        return Balance * .7;
    //    }
    //}
}
public interface IAccount
{
    double CalculateInterest(Account account);
}

public class SavingAccount : IAccount
{
    public double CalculateInterest(Account account)
    {
       return account.Balance * .7; 
    }
}
public class CurrentAccount : IAccount
{
    public double CalculateInterest(Account account)
    {
        return account.Balance * .9;
    }
}