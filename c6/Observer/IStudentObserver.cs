namespace launcher.c6.Observer;

public interface IStudentObserver
{
    int Id { get; }
    void Update(bool hasPassed); 
}