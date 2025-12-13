namespace launcher.c6.Decorator;

public class Shop
{
    public void MakePurchase(string paymentMethod, double amount)
    {
        var method = paymentMethod.ToLower();
        if (method != "karta" && method != "gotowka" && method != "przelew")
        {
            Console.WriteLine("Nieznana metoda płatności");
            return;
        }

        IPayment paymentProcess = new BasePayment();

        if (method == "karta")
        {
            paymentProcess = new SmsNotificationDecorator(paymentProcess);
            paymentProcess = new LoyaltyPointsDecorator(paymentProcess);
            paymentProcess = new RedirectToHomeDecorator(paymentProcess);
        }

        paymentProcess.Pay(amount);
    }
}