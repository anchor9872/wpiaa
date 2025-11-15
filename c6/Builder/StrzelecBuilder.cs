namespace launcher.c6.Builder;
using launcher.c6.Factory;

public class StrzelecBuilder: WarriorBuilder
{
    public override void CreateWarrior(string name)
    {
        wojownik = new Strzelec(name);
        Console.WriteLine($"{name} zapisuje sie do armii");
    }

    public override void AddWeapons()
    {
        Console.WriteLine($"{wojownik!.Name} dostaje łuk");
    }

    public override void TrainCombat()
    {
        Console.WriteLine($"{wojownik!.Name} strzela do tarcz");
    }
}