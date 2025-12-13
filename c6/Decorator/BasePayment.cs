namespace launcher.c6.Decorator;

public class BasePayment : IPayment
{
    public void Pay(double amount)
    {
        if (amount >= 0)
        {
            Console.WriteLine($"Pobrano kwotę: {amount}");
        }
    }
}