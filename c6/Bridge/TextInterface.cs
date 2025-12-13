namespace launcher.c6.Bridge;

public class TextInterface : IUserInterface
{
    public void DisplayMenu(string systemName)
    {
        Console.WriteLine($"{systemName} - interfejs tekstowy");
        Console.WriteLine("Programy: cat, nano, htop");
    }
}