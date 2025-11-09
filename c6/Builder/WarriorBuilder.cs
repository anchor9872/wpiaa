namespace launcher.c6.Builder;
using launcher.c6.Factory;


public abstract class WarriorBuilder
{
    protected Wojownik wojownik;

    // Gets sandwich instance
    public Wojownik GetWojownik() => wojownik;

    // Abstract build methods
    public abstract void CreateWarrior(string name);
    public abstract void AddWeapons();
    public abstract void TrainCombat();
}