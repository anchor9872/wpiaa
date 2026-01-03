namespace launcher.c6.Command;

public class Gift
{
    public string Name { get; set; }
    public string Type { get; set; }

    public Gift(string name)
    {
        Name = name;
        Type = "-";
    }

    public void Display()
    {
        Console.WriteLine($"Produkt: {Name} | Typ: {Type}");
    }
}