
//CreditCardFactory creditCardFactory = new CreditCardFactory();
//ICreditCard card = creditCardFactory.GetCreditCard("Platinum");
//Console.Write($"Type {card.CreditCardType()} credit limit {card.CreditLimit()} charge {card.AnnualFee()}");

ICreditCard platinumFactory = new PlatinumFactory().CreateCreditCard();
ICreditCardAddtionalFeature platinumFactory1 = new PlatinumAdditionalFactory().CreateCreditCard();
Console.Write($"Type {platinumFactory.CreditCardType()} credit limit {platinumFactory.CreditLimit()} charge {platinumFactory.AnnualFee()} and calculation {platinumFactory1.CalculateAnnualPoint()}");
Console.ReadKey();
public interface ICreditCard
{
    string CreditCardType();
    double AnnualFee();
    double CreditLimit();
}

public interface ICreditCardAddtionalFeature
{
    double CalculateAnnualPoint();
}
public class Platinum : ICreditCard, ICreditCardAddtionalFeature
{
    public double AnnualFee()
    {
        return 100;
    }
    public string CreditCardType()
    {
        return "Platinum";
    }
    public double CreditLimit()
    {
        return 200;
    }
    public double CalculateAnnualPoint()
    {
        return 10;
    }
}
public class Titanium : ICreditCard
{
    public double AnnualFee()
    {
        return 150;
    }
    public string CreditCardType()
    {
        return "Titanium";
    }
    public double CreditLimit()
    {
        return 300;
    }
}

// factory creator 
public abstract class CreditCardFactory
{
    protected abstract ICreditCard MakeProduct();
    public ICreditCard CreateCreditCard()
    {
        return MakeProduct();
    }
}
public abstract class CreditCardAdditionalFactory
{
    protected abstract ICreditCardAddtionalFeature MakeProduct();
    public ICreditCardAddtionalFeature CreateCreditCard()
    {
        return MakeProduct();
    }
}
public class PlatinumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new Platinum();
        return product;
    }
}
public class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new Titanium();
        return product;
    }
}
public class PlatinumAdditionalFactory : CreditCardAdditionalFactory
{
    protected override ICreditCardAddtionalFeature MakeProduct()
    {
        ICreditCardAddtionalFeature product = new Platinum();
        return product;
    }
}