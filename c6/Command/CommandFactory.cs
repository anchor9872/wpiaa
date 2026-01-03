namespace launcher.c6.Command;

public class CommandFactory
{
    public ProductionCommand GetCommand(int commandOption)
    {
        switch (commandOption)
        {
            case 1:
                return new MakeToyCommand();
            case 2:
                return new MakeStickCommand();
            default:
                return new MakeToyCommand();
        }
    }
}