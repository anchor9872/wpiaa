namespace launcher.c1;

// Masz metodę PerformTransaction z kilkoma komentarzami opisującymi kroki transakcji. Twoim zadaniem jest przekształcenie komentarzy w bardziej opisowe nazwy metod.
public class Transaction
{
    public bool VerifyDetails()
    {
        return true;
    }
}

public class PaymentProcessor
{
    public void PerformTransaction(Transaction transaction)
    {
        // Weryfikuje szczegóły transakcji
        if (transaction.VerifyDetails())
        {
            ProcessPayment(transaction);
            UpdateAccountBalance(transaction);
            CreateReceipt(transaction);
        }
    }
    private void ProcessPayment(Transaction transaction)
    {
        Console.WriteLine("processing payment.");
    }

    private void UpdateAccountBalance(Transaction transaction)
    {
        Console.WriteLine("updating account balance");
    }

    private void CreateReceipt(Transaction transaction)
    {
        Console.WriteLine("generating receipt for the transaction.");
    }
}
// Kroki do wykonania:
//
// Zastąp komentarze bardziej opisowymi nazwami metod.
// Wyodrębnij bloki kodu do osobnych metod.
