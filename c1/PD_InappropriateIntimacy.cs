namespace launcher.c1;

public class Course
{
    private int _credits;
    private bool _isCompleted;

    public int Credits
    {
        get { return _credits; }
    }

    public bool IsCompleted
    {
        get { return _isCompleted; }
    }
    
    public void SetCredits(int credits)
    {
        _credits = credits;
    }

    public void SetComplete()
    {
        _isCompleted = true;
    }
}

public class Student
{
    public void CompleteCourse(Course course)
    {
        course.SetCredits(3); 
        course.SetComplete(); 
    }
}