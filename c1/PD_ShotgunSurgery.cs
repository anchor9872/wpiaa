namespace launcher.c1;

// Masz klasy Customer i Order, gdzie zarówno Customer jak i Order mają metody dotyczące logiki zamówienia. Twoim zadaniem jest skoncentrowanie odpowiedzialności dotyczących zamówienia w jednej klasie.

public class Customer
{
    public required string Name { get; set; }
}

public class ShotgunSurgeryOrder
{
    public required string OrderId { get; set; }
}

public class OrderService
{
    public void SaveOrder(ShotgunSurgeryOrder order)
    {
        Console.WriteLine($"Order {order.OrderId} saved.");
    }
    public ShotgunSurgeryOrder CreateOrder(Customer customer, string id)
    {
        Console.WriteLine($"Order created for customer {customer.Name}.");
        return new ShotgunSurgeryOrder{OrderId = id};
    }
}
// Kroki do wykonania:
// Utwórz centralną klasę OrderService, która zajmie się zarządzaniem zamówieniami.
// Przenieś odpowiedzialności dotyczące zamówień do tej klasy.
