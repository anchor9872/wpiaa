namespace launcher.c6.Command;

public class SantaClausFactory
{
    public List<Gift> producedGifts { get; set; }

    public SantaClausFactory()
    {
        producedGifts = new List<Gift>();
    }

    public void ExecuteCommand(ProductionCommand command, Gift item)
    {
        command.Execute(this.producedGifts, item);
    }

    public void ShowInventory()
    {
        Console.WriteLine("---------------------------------");
        foreach (var item in producedGifts)
        {
            item.Display();
        }
        Console.WriteLine("---------------------------------");
    }
}