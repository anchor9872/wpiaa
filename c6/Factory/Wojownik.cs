namespace launcher.c6.Factory;

public abstract class Wojownik
{
    public string Name { get; set; }

    public Wojownik(string name)
    {
        Name = name;
    }

    public abstract void Fight();

}