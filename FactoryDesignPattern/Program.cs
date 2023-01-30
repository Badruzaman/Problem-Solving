

string cardType = "MoneyBack";
CreditCard cardDetails = null;
if (cardType == "MoneyBack")
{
    cardDetails = new MoneyBack();
}
else if (cardType == "Titanium")
{
    cardDetails = new Titanium();
}
else if (cardType == "Platinum")
{
    cardDetails = new Platinum();
}
if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCardLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetCardAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}

CreditCard cardDetail = CreditCardFactory.GetCreditCard("Platinum");

if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetail.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetail.GetCardLimit());
    Console.WriteLine("AnnualCharge :" + cardDetail.GetCardLimit());
}
else
{
    Console.Write("Invalid Card Type");
}

Console.ReadKey();

interface CreditCard
{
    string GetCardType();
    Decimal GetCardLimit();
    decimal GetCardAnnualCharge();
}

public class MoneyBack : CreditCard
{
    public string GetCardType()
    {
        return "MoneyBack";
    }
    public decimal GetCardLimit()
    {
        return 50000;
    }
    public decimal GetCardAnnualCharge()
    {
        return 5000;
    }
}
public class Platinum : CreditCard
{
    public string GetCardType()
    {
        return "Platinum";
    }
    public decimal GetCardLimit()
    {
        return 600000;
    }
    public decimal GetCardAnnualCharge()
    {
        return 6000;
    }
}

public class Titanium : CreditCard
{
    public string GetCardType()
    {
        return "Titanium";
    }
    public decimal GetCardLimit()
    {
        return 70000;
    }
    public decimal GetCardAnnualCharge()
    {
        return 7000;
    }
}

class CreditCardFactory
{
    public static CreditCard GetCreditCard(string cardType)
    {
        CreditCard cardDetails = null;
        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBack();
        }
        else if (cardType == "Titanium")
        {
            cardDetails = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new Platinum();
        }
        return cardDetails;
    }
}