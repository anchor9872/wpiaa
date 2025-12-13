namespace launcher.c6.Flyweight;

public class Texture
{
    public string Filename { get; private set; }
    public Texture(string filename)
    {
        Filename = filename;
        Console.WriteLine($"Załadowano '{filename}' z dysku");
    }
    public void Render(int x, int y)
    {
        Console.WriteLine($"Rysowanie '{Filename}' na koordynatach ({x}, {y})");
    }
}