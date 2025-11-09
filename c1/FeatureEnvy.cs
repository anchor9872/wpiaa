namespace launcher.c1;

public class ShippingDetails
{
    public required string ShippingMethod { get; set; }
    public required string Destination { get; set; }
    public decimal CalculateShippingCost(decimal amount)
    {
        if (ShippingMethod == "Air")
        {
            return amount * 0.2m;
        }
        else if (ShippingMethod == "Sea")
        {
            return amount * 0.1m;
        }
        return amount * 0.15m;
    }
}

public class Order
{
    public required ShippingDetails ShippingDetails { get; set; }
    public decimal Amount { get; set; }
}
// Kroki do wykonania:
//
// Przenieś metodę CalculateShippingCost do klasy ShippingDetails.
// Zaktualizuj logikę metody tak, aby przyjmowała jako parametr kwotę zamówienia (Amount).
// Usuń metodę CalculateShippingCost z klasy Order.