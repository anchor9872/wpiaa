namespace launcher.c6.Builder;
using launcher.c6.Factory;

public class PiechurBuilder: WarriorBuilder
{
    public override void CreateWarrior(string name)
    {
        wojownik = new Piechur(name);
        Console.WriteLine($"{name} zapisuje sie do armii");
    }

    public override void AddWeapons()
    {
        Console.WriteLine($"{wojownik.Name} dostaje miecz i tarczę");
    }

    public override void TrainCombat()
    {
        Console.WriteLine($"{wojownik.Name} trenuje walke wrecz");
    }
}