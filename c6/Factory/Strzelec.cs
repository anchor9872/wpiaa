namespace launcher.c6.Factory;

public class Strzelec : Wojownik
{
    public Strzelec(string name) : base(name) { }

    public override void Fight()
    {
        Console.WriteLine($"{Name} strzela z łuku");
    }
}