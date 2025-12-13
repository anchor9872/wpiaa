namespace launcher.c6.Decorator;

public class LoyaltyPointsDecorator : PaymentDecorator
{
    public LoyaltyPointsDecorator(IPayment payment) : base(payment) { }

    public override void Pay(double amount)
    {
        base.Pay(amount);
            
        int points = (int)amount / 10;
        Console.WriteLine($" Przyznano {points} punktów lojalnościowych");
    }
}