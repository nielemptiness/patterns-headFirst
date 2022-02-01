namespace Patterns.HeadFirst.Proxy;

public class SomeSubject : ISubject
{
    private const int ReallyHardResult = 1;

    public SomeSubject()
    {
        Console.WriteLine("Creating real subject!");
    }
    public int DoSomeWork()
    {
        Console.WriteLine("Uff... Hard work!");
        return ReallyHardResult;
    }
}