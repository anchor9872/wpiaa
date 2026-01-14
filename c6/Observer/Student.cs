namespace launcher.c6.Observer;

public class Student : IStudentObserver
{
    public int Id { get; set; }

    public Student(int id)
    {
        Id = id;
    }
    
    public void Update(bool hasPassed)
    {
        if (hasPassed)
        {
            Console.WriteLine($"{Id}:Zdałem egzamin!");
        }
        else
        {
            Console.WriteLine($"{Id}:Nie zdałem egzaminu.");
        }
    }
}

