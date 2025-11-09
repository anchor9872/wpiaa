namespace launcher.c1;

// Masz klasę Product z właściwościami, które są tylko publicznymi polami przechowującymi dane. Twoim zadaniem jest dodanie metod zawierających logikę biznesową dotyczącą danych przechowywanych w tej klasie.

public class ProductDataClass
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    public string GetFormattedPrice()
    {
        return $"{Price:0.00} PLN";
    }

    public bool IsInStock()
    {
        return StockQuantity > 0;
    }
}

// Kroki do wykonania:
// Dodaj logikę biznesową bezpośrednio do klasy Product.
// Dodaj metodę GetFormattedPrice, która zwraca cenę sformatowaną jako tekst.
// Dodaj metodę IsInStock, która zwraca true, jeśli StockQuantity jest większe niż 0.
