namespace launcher.c6.Command;

public class MakeStickCommand : ProductionCommand
{
    public override void Execute(List<Gift> gifts, Gift newItem)
    {
        newItem.Type = "RÓZGA";
        gifts.Add(newItem);
        Console.WriteLine($"Przygotowano rózgę: {newItem.Name}");
    }
}