namespace launcher.c6.Decorator;

public class RedirectToHomeDecorator : PaymentDecorator
{
    public RedirectToHomeDecorator(IPayment payment) : base(payment) { }

    public override void Pay(double amount)
    {
        base.Pay(amount);
        Console.WriteLine(" Płatność zakończona, przekierowanie na stronę główną..");
    }
}