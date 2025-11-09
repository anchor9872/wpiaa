namespace launcher.c1;

// public class MessageChains
// {
//     
// }
public class Car
{
    public Engine GetEngine()
    {
        return new Engine();
    }

    public string GetCylinderSize()
    {
        var engine = GetEngine();
        var cylinder = engine.GetCylinder();
        return cylinder.GetSize();
    }
}

public class Engine
{
    public Cylinder GetCylinder()
    {
        return new Cylinder();
    }
}

public class Cylinder
{
    public string GetSize()
    {
        return "2.0L";
    }
}

// Przykład wywołania
// Car car = new Car();
// string cylinderSize = car.GetEngine().GetCylinder().GetSize();