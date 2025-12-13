namespace launcher.c6.Decorator;

public abstract class PaymentDecorator : IPayment
{
    protected IPayment _payment;

    public PaymentDecorator(IPayment payment)
    {
        _payment = payment;
    }

    public virtual void Pay(double amount)
    {
        _payment.Pay(amount);
    }
}