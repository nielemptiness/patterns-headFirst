namespace Patterns.HeadFirst;

public class PrintStringCommand : ICommand
{
    public void Execute()
    {
        Shared.PrintString();
    }
}