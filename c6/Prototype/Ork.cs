namespace launcher.c6.Prototype;
using Newtonsoft.Json;
public class Ork
{
    public int Damage;
    public int Strength;
    
    public Ork(int damage, int strength)
    {
        Damage = damage;
        Strength = strength;
    }
    
    public Ork Clone()
    {
        var jsonOrk = JsonConvert.SerializeObject(this);
        var orkCopy = JsonConvert.DeserializeObject<Ork>(jsonOrk);
        var rnd = new Random();
        orkCopy!.Strength = rnd.Next(20, 100);
        return orkCopy;
    }

    public override string ToString()
    {
        return $"Damage: {Damage}, Strength: {Strength}";
    }
}