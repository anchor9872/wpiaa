namespace launcher.c6.Adapter;

public class Adult
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Adult(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual bool IsAdult()
    {
        return Age >= 18;
    }
}
