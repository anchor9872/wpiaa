namespace launcher.c1;

// Kroki do wykonania:
//
// Utwórz osobne klasy AuthenticationService i UserReportGenerator dla odpowiednich odpowiedzialności.
// Przenieś odpowiednie metody do tych nowych klas.
// Usuń zbędne metody z klasy UserAccount i zachowaj tylko właściwości oraz metody bezpośrednio związane z kontem użytkownika.

public class AuthenticationService
{
    public void Login(UserAccount user)
    {
        // Logika logowania
        Console.WriteLine("User logged in.");
    }

    public void Logout(UserAccount user)
    {
        // Logika wylogowania
        Console.WriteLine("User logged out.");
    }
}

public class UserReportGenerator
{
    public void GenerateReport(UserAccount user)
    {
        // Logika generowania raportu
        Console.WriteLine("Generating user report.");
    }
}

public class UserAccount
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}