namespace Patterns.HeadFirst.Proxy;

public class SimpleProxy : ISubject
{
    private ISubject? _subject;
    
    public int DoSomeWork()
    {
        _subject ??= new SomeSubject();

        return _subject.DoSomeWork();
    }
}