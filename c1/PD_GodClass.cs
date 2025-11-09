namespace launcher.c1;

public class AdminPanel
{
    private readonly UserManager _userManager = new();
    private readonly SystemConfigurator _configurator = new();
    private readonly LogRegistrar _logRegistrar = new();
    private readonly SystemReportGenerator _reportGenerator = new();
    
    public void RunTasks()
    {
        _userManager.ManageUsers();
        _configurator.ConfigureSystem();
        _logRegistrar.RegisterLog("log test");
        _reportGenerator.GenerateSystemReport();
    }
}

public class UserManager
{
    public void ManageUsers()
    {
        Console.WriteLine("Managing users.");
    }
}

public class SystemConfigurator
{
    public void ConfigureSystem()
    {
        Console.WriteLine("Configuring system.");
    }
}

public class LogRegistrar
{
    public void RegisterLog(string log)
    {
        Console.WriteLine($"Log: {log}");
    }
}

public class SystemReportGenerator
{
    public void GenerateSystemReport()
    {
        Console.WriteLine("System report generated.");
    }
}

// Kroki do wykonania:
//
// Utwórz osobne klasy UserManager, SystemConfigurator, LogRegistrar, i SystemReportGenerator.
// Przenieś odpowiednie metody do tych nowych klas.
// Usuń zbędne metody z klasy AdminPanel i zachowaj tylko te, które są faktycznie związane z zarządzaniem panelem administratora na wysokim poziomie.
