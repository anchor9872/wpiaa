namespace launcher.c6.Adapter;

public class Club
{
    public bool CheckEntry(Adult adult)
    {
        if (adult.IsAdult())
        {
            Console.WriteLine($"baw się dobrze, {adult.Name}!");
            return true;
        }
        else
        {
            Console.WriteLine($"jesteś za młody, {adult.Name}");
            return false;
        }
    }
}