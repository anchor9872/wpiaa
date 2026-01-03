namespace launcher.c6.Command;

public class SantasHelper
{
    private ProductionCommand? _command;
    private Gift? _gift;
    private SantaClausFactory _factory;

    public SantasHelper()
    {
        _factory = new SantaClausFactory();
    }

    public void SetCommand(int commandOption)
    {
        _command = new CommandFactory().GetCommand(commandOption);
    }

    public void SetGift(Gift gift)
    {
        _gift = gift;
    }

    public void ExecuteCommand()
    {
        if (_command != null && _gift != null)
        {
            _factory.ExecuteCommand(_command, _gift);
        }
        else
        {
            Console.WriteLine("nie ustawiono komendy");
        }
    }

    public void ShowProducedItems()
    {
        _factory.ShowInventory();
    }
}