namespace launcher.c6.Bridge;

public class LinuxSystem : OperationSystem
{
    public override void PressMenuButton()
    {
        _ui.DisplayMenu("Linux");
    }
}