namespace launcher.c6.Proxy;

public class FileAccessProxy : IFileAccess
{
    private RestrictedObject? _restrictedObject;
    private PublicObject? _publicObject;
    private readonly string _correctPassword = "tajnehaslo";
    private readonly List<string> _restrictedFiles = new List<string>
    {
        "tajny_plik1.xls",
        "tajny_plik2.pdf"
    };   
    public string GetFile(string fileName)
    {
        if (_restrictedFiles.Contains(fileName.ToLower()))
        {
            Console.Write($"Plik '{fileName}' jest chroniony. Podaj hasło: ");
            var password = Console.ReadLine() ?? "";

            if (CheckPassword(password))
            {
                return GetRestrictedObject().GetFile(fileName);
            }
            else
            {
                Console.WriteLine("Hasło jest niepoprawne");
                return "";
            }
        }
        else
        {
            return GetPublicObject().GetFile(fileName);
        }
    }
    private bool CheckPassword(string password)
    {
        return password == _correctPassword;
    }
    
    private RestrictedObject GetRestrictedObject()
    {
        if (_restrictedObject == null)
        {
            _restrictedObject = new RestrictedObject();
        }
        return _restrictedObject;
    }

    private PublicObject GetPublicObject()
    {
        if (_publicObject == null)
        {
            _publicObject = new PublicObject();
        }
        return _publicObject;
    }

}