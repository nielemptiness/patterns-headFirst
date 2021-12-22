namespace Patterns.HeadFirst;

public class Invoker : IInvoker
{
    private ICommand _command;
    
    public void Invoke()
    {
        _command.Execute();
    }

    public void SetCommand(ICommand command)
    {
        _command = command;
    }
}