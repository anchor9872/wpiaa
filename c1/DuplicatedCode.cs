namespace launcher.c1;

internal class DuplicatedCode
{
    // public void LogError(string message, DateTime timestamp)
    // {
    //     string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
    //     string formattedMessage = $"ERROR: [{formattedTimestamp}] {message}";
    //     Console.WriteLine(formattedMessage);
    // }
    //
    // public void LogWarning(string message, DateTime timestamp)
    // {
    //     string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
    //     string formattedMessage = $"WARNING: [{formattedTimestamp}] {message}";
    //     Console.WriteLine(formattedMessage);
    // }
    public void LogError(string message, DateTime timestamp)
    {
        string logMessage = FormatLogMessage("ERROR", message, timestamp);
        Console.WriteLine(logMessage);
    }
    
    public void LogWarning(string message, DateTime timestamp)
    {
        string logMessage = FormatLogMessage("WARNING", message, timestamp);
        Console.WriteLine(logMessage);
    }

    private string FormatLogMessage(string logType, string message, DateTime timestamp)
    {
        string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
        string formattedMessage = $"{logType}: [{formattedTimestamp}] {message}";
        return formattedMessage;
    }
}


