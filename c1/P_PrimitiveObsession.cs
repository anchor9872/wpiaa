namespace launcher.c1;

// Masz metodę RegisterProduct w klasie ProductManager, która przyjmuje wiele parametrów związanych z produktem (name, category, price, quantity). Twoim zadaniem jest utworzenie nowej klasy ProductDetails i zastąpienie parametrów odpowiednim obiektem.
public class ProductDetails
{
    public required string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public required string Category { get; set; }
}
public class ProductManager
{
    public void RegisterProduct(ProductDetails product)
    {
        Console.WriteLine($"Product: {product.Name}, Category: {product.Category}, Price: {product.Price}, Quantity: {product.Quantity}");
    }
}
// Kroki do wykonania:
// Utwórz nową klasę ProductDetails, która będzie zawierała pola Name, Category, Price, Quantity.
// Zastąp listę parametrów w metodzie RegisterProduct jednym obiektem ProductDetails.
// Zaktualizuj logikę metody, aby korzystała z nowego obiektu.
