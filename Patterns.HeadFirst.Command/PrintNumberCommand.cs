namespace Patterns.HeadFirst;

public class PrintNumberCommand : ICommand
{
    public void Execute()
    {
        Shared.PrintNumber();
    }
}