namespace launcher.c6.Bridge;

public class GraphicInterface : IUserInterface
{
    public void DisplayMenu(string systemName)
    {
        Console.WriteLine($"{systemName} - interfejs graficzny");
        Console.WriteLine("Programy: Firefox, Edytor tekstu, Kalkulator");
    }
}