namespace launcher.c1;

// public class LongParameterList
// {
//     public void RegisterProduct(string productName, string category, decimal price, int stock, string supplierName, string supplierContact)
//     {
//         // Rejestracja produktu
//         Console.WriteLine($"Product: {productName}, Category: {category}, Price: {price:C}, Stock: {stock}, Supplier: {supplierName}, Contact: {supplierContact}");
//     }
// }

internal class LongParameterList
{
    public void RegisterProduct(Product product)
    {
        // Rejestracja produktu
        Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.Price:C}, Stock: {product.Stock}, Supplier: {product.SupplierName}, Contact: {product.SupplierContact}");
    }
}

internal class Product
{
    public required string ProductName { get; set; }
    public required string Category { get; set; }
    public required decimal Price { get; set; }
    public int Stock { get; set; }
    public required string SupplierName { get; set; }
    public required string SupplierContact { get; set; }
}