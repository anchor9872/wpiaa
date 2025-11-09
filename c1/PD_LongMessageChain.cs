namespace launcher.c1;

public class School
{
    public Classroom GetClassroom()
    {
        return new Classroom();
    }

    public string GetTeacherName()
    {
        Classroom cr = new Classroom();
        return cr.GetTeacher().GetName();
    }
}

public class Classroom
{
    public Teacher GetTeacher()
    {
        return new Teacher();
    }
}

public class Teacher
{
    public string GetName()
    {
        return "John Smith";
    }
}
