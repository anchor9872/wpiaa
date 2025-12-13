namespace launcher.c6.Composite;

public class MenuCategory : IMenuComponent
{
    public string Name { get; set; }
    
    private List<IMenuComponent> _items = new List<IMenuComponent>();

    public MenuCategory(string name)
    {
        Name = name;
    }
    
    public void AddComponent(IMenuComponent component)
    {
        _items.Add(component);
    }

    public void RemoveComponent(IMenuComponent component)
    {
        _items.Remove(component);
    }

    public void DisplayMenu(int indent)
    {
        string indentation = new string(' ', indent);
    
        Console.WriteLine($"{indentation}+ {Name.ToUpper()}");

        foreach (var item in _items)
        {
            item.DisplayMenu(indent + 3); 
        }
    }
}