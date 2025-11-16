namespace launcher.c6.Adapter;

public class FakeAdult : Adult
{
    private int _realAge;

    public FakeAdult(string name, int realAge) : base(name, realAge)
    {
        _realAge = realAge;
    }
    public override bool IsAdult()
    {
        return true;
    }
}

