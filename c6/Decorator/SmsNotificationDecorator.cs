namespace launcher.c6.Decorator;

public class SmsNotificationDecorator : PaymentDecorator
{
    public SmsNotificationDecorator(IPayment payment) : base(payment) { }

    public override void Pay(double amount)
    {
        base.Pay(amount);
        Console.WriteLine(" Wysłano potwierdzenie transakcji na numer klienta");
    }
}