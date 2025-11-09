namespace launcher.c6.Factory;

public class Konny : Wojownik
{
    public Konny(string name) : base(name) { }

    public override void Fight()
    {
        Console.WriteLine($"{Name} walczy czym walczy konny");
    }
}