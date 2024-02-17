
ICreditCard creditCard = new PlatinumFactory().MakeProduct();
Console.WriteLine(creditCard.CardAnnualCharge());
Console.ReadKey();

public interface ICreditCard
{
    string CardType();
    double CardAnnualCharge();
    double CardLimit();
}

public class Platinum : ICreditCard
{
    public double CardAnnualCharge()
    {
        return 30;
    }
    public double CardLimit()
    {
        return 1000;
    }
    public string CardType()
    {
        return "Platinum";
    }
}

public class Titanium : ICreditCard
{
    public double CardAnnualCharge()
    {
        return 25;
    }

    public double CardLimit()
    {
        return 1500;
    }
    public string CardType()
    {
        return "Titanium";
    }
}
public abstract class CreditCardFactory
{
    internal abstract ICreditCard MakeProduct();
}
public class PlatinumFactory : CreditCardFactory
{
    internal override ICreditCard MakeProduct()
    {
        return new Platinum();
    }
}
public class TataniumFactory : CreditCardFactory
{
    internal override ICreditCard MakeProduct()
    {
        return new Titanium();
    }
}