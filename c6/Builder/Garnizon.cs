namespace launcher.c6.Builder;
using launcher.c6.Factory;

public class Garnizon
{
    public Wojownik WyszkolWojownika(WarriorBuilder builder, string name)
    {
        builder.CreateWarrior(name); 
        builder.AddWeapons();     
        builder.TrainCombat();     

        return builder.GetWojownik();
    }
}