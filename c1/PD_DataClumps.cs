namespace launcher.c1;

    public class EventDetails
    {
        public required string Name {get; set;}
        public DateTime Date {get; set;}
        public required string Location {get; set;}
    }
    
    public class EventService
    {
        public void RegisterEvent(EventDetails details)
        {
            Console.WriteLine($"Event: {details.Name}, Date: {details.Date}, Location: {details.Location}");
        }
    }