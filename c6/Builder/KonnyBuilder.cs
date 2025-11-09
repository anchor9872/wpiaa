namespace launcher.c6.Builder;
using launcher.c6.Factory;

public class KonnyBuilder: WarriorBuilder
{
    public override void CreateWarrior(string name)
    {
        wojownik = new Konny(name);
        Console.WriteLine($"{name} zapisuje sie do armii");
    }

    public override void AddWeapons()
    {
        Console.WriteLine($"{wojownik.Name} dostaje bron konnego");
    }

    public override void TrainCombat()
    {
        Console.WriteLine($"{wojownik.Name} trenuje walke konno");
    }
}