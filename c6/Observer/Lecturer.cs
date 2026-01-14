namespace launcher.c6.Observer;

public class Lecturer
{
    private readonly Dictionary<IStudentObserver, bool?> _examResults = new Dictionary<IStudentObserver, bool?>();

    public void SignStudentForExamResults(IStudentObserver student)
    {
        if (!_examResults.ContainsKey(student))
        {
            _examResults.Add(student, null);
            Console.WriteLine($"Zapisano studenta {student.Id}.");
        }
    }

    public void GradeStudent(IStudentObserver student, bool hasPassed)
    {
        if (_examResults.ContainsKey(student))
        {
            _examResults[student] = hasPassed;
        }
        else
        {
            Console.WriteLine($"Student {student.Id} nie jest zapisany na ten egzamin");
        }
    }

    public void AnnounceResults()
    {
        Console.WriteLine("\n--- Ogłoszenie wyników ---");

        foreach (var entry in _examResults)
        {
            var student = entry.Key;
            var result = entry.Value;

            if (result.HasValue)
            {
                student.Update(result.Value);
            }
            else
            {
                Console.WriteLine($"Student {student.Id} nie został oceniony.");
            }
        }
    }
}