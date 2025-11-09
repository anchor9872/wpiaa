namespace launcher.c1;

// Kroki do wykonania:
//
// Usuń klasy bazowe (BaseLogger i BaseExporter).
// Wprowadź interfejsy ILogger i IExporter.
// Przenieś metody do interfejsów i zastąp hierarchię klas bazowych implementacjami interfejsów.
// Dostosuj klasy pochodne, aby implementowały odpowiednie interfejsy.

public interface ILogger
{
    public void LogMessage();
}

public class FileLogger : ILogger
{
    public void LogMessage()
    {
        Console.WriteLine("file logger log");
    }
}

public class DatabaseLogger : ILogger
{
    public void LogMessage() { /* Implementacja dla bazy danych */ }
}

public interface IExporter
{
    public void ExportData();
}

public class XmlExporter : IExporter
{
    public void ExportData() { /* Implementacja dla XML */ }
}

public class JsonExporter : IExporter
{
    public void ExportData()
    {
        Console.WriteLine("json exporter data export");
    }
}
