namespace launcher.c1;

// Switch Statements (Instrukcje warunkowe)
// Masz metodę DeterminePaymentFee w klasie Payment z wieloma instrukcjami switch/case, która obsługuje różne metody płatności. Twoim zadaniem jest zastosowanie wzorca strategii, aby uniknąć nadmiarowych instrukcji warunkowych.
public interface IPaymentFeeStrategy
{
    decimal DeterminePaymentFee(decimal amount);
}

public class CreditCardFeeStrategy : IPaymentFeeStrategy
{
    public decimal DeterminePaymentFee(decimal amount)
    {
        return amount * 0.02m;
    }
}

public class PayPalFeeStrategy : IPaymentFeeStrategy
{
    public decimal DeterminePaymentFee(decimal amount)
    {
        return amount * 0.03m;
    }
}

public class BankTransferFeeStrategy : IPaymentFeeStrategy
{
    public decimal DeterminePaymentFee(decimal amount)
    {
        return amount * 0.01m;
    }
}

public class Payment
{
    private readonly IPaymentFeeStrategy _feeStrategy;

    public Payment(IPaymentFeeStrategy feeStrategy)
    {
        _feeStrategy = feeStrategy;
    }

    public decimal DeterminePaymentFee(decimal amount)
    {
        return _feeStrategy.DeterminePaymentFee(amount);
    }
}
// Kroki do wykonania:
//
// Utwórz interfejs IPaymentFeeStrategy z metodą DeterminePaymentFee.
// Utwórz osobne klasy implementujące IPaymentFeeStrategy dla każdej metody płatności (CreditCardFeeStrategy, PayPalFeeStrategy, BankTransferFeeStrategy).
// Zamień instrukcje switch na wybór odpowiedniej strategii, wstrzykując strategię do klasy Payment.
