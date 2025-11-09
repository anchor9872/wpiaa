namespace launcher.c1;

public interface IEmployee
{
    void Work();
    void AttendMeeting();
}

public class Employee
{
    public required string Name { get; set; }
    public required string Position { get; set; }
    public void Work() { /* Implementacja */ }
    public void AttendMeeting() { /* Implementacja */ }
}

public class Manager : Employee
{
    public void ManageTeam() { /* Implementacja */ }
}