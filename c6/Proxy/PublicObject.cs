namespace launcher.c6.Proxy;

public class PublicObject: IFileAccess
{
    public string GetFile(string fileName)
    {
        Console.WriteLine($"dostep do publicznego {fileName} przyznany");
        return $"--- zawartosc pliku {fileName} ---";
    }

}