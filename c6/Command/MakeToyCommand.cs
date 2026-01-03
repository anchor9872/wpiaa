namespace launcher.c6.Command;

public class MakeToyCommand : ProductionCommand
{
    public override void Execute(List<Gift> gifts, Gift newItem)
    {
        newItem.Type = "ZABAWKA";
        gifts.Add(newItem);
        Console.WriteLine($"Wyprodukowano zabawkę: {newItem.Name}");
    }
}