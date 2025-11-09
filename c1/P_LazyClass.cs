namespace launcher.c1;

// Masz klasę NotificationSender, która ma bardzo mało odpowiedzialności. Twoim zadaniem jest przeniesienie jej funkcji do bardziej odpowiedniej klasy.
public class MessagingService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Notification sent: {message}");
    }
}

// Kroki do wykonania:
// Przenieś metodę SendNotification do innej klasy, która zarządza komunikacją (np. MessagingService).
// Usuń klasę NotificationSender.
