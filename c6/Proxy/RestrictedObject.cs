namespace launcher.c6.Proxy;

public class RestrictedObject : IFileAccess
{
    public string GetFile(string fileName)
    {
        Console.WriteLine($"dostep do {fileName} przyznany");
        return $"--- zawartosc pliku {fileName} ---";
    }
}