namespace launcher.c1;

// Masz klasę AdvancedHandler, która zawiera wiele metod zaprojektowanych z myślą o potencjalnych przyszłych wymaganiach, ale żadna z tych metod nie jest używana. Twoim zadaniem jest uproszczenie tej klasy, usuwając zbędną ogólność.

public class HttpRequest
{
    public required string Url { get; set; }
}

public class FileRequest
{
    public required string FileName { get; set; }
}
public class AdvancedHandler
{
    public void HandleHttpRequest(HttpRequest request)
    {
        Console.WriteLine($"Handling HTTP request: {request.Url}");
    }

    public void HandleFileRequest(FileRequest request)
    {
        Console.WriteLine($"Handling file request: {request.FileName}");
    }
}

// Kroki do wykonania:
// Usuń nieużywane metody (HandleRequest) oraz niepotrzebne abstrakcje.
// Zachowaj tylko metody, które są faktycznie wykorzystywane (HandleHttpRequest, HandleFileRequest).
