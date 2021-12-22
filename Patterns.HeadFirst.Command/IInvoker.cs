namespace Patterns.HeadFirst;

public interface IInvoker
{
    void Invoke();
    void SetCommand(ICommand command);
}