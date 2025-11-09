namespace launcher.c6.Factory;

public class Garnizon
{
    public Wojownik WyszkolWojownika(string profession, string name)
    {
        switch (profession.ToLower())
        {
            case "piechur":
                return new Piechur(name);
            case "strzelec":
                return new Strzelec(name);
            case "konny":
                return new Konny(name);
            default:
                throw new ArgumentException("nieznana profesja: " + profession);
        }
    }
}