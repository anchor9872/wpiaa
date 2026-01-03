namespace launcher.c6.Command;

public abstract class ProductionCommand
{
    public abstract void Execute(List<Gift> gifts, Gift newItem);
}