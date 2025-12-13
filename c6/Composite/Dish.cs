namespace launcher.c6.Composite;

public class Dish : IMenuComponent
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Dish(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void DisplayMenu(int indent)
    {
        string indentation = new string(' ', indent);
        Console.WriteLine($"{indentation}- {Name} ({Price:F2} PLN)");
    }
}