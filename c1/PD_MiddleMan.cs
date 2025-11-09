namespace launcher.c1;

// Masz klasę InvoiceService, która jedynie deleguje wywołania metod do klasy InvoiceRepository. Twoim zadaniem jest usunięcie klasy pośrednika i bezpośrednie użycie klasy InvoiceRepository.
public class Invoice
{
    public int Id { get; set; }
}

public class InvoiceRepository
{
    public Invoice GetInvoiceById(int id)
    {
        return new Invoice{Id = id};
    }
    public void SaveInvoice(Invoice invoice)
    {
        Console.WriteLine($"Saving invoice {invoice.Id}");
    }
}

// Kroki do wykonania:
//
// Usuń klasę InvoiceService.
// Zastąp wszystkie odwołania do InvoiceService bezpośrednimi odwołaniami do InvoiceRepository.
// Upewnij się, że kod nadal działa poprawnie po usunięciu klasy pośrednika.

