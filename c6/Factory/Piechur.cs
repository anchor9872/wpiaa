namespace launcher.c6.Factory;

public class Piechur : Wojownik
{
    public Piechur(string name) : base(name) { }

    public override void Fight()
    {
        Console.WriteLine($"{Name} walczy mieczem");
    }

}